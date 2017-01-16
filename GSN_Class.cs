using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace GSN
{


    struct GSNResultData
    {
        public bool status;
        public string encString;
        public string decString;
        public List<string> searchResults;
    }

    class GSN_Class
    {

        public bool useLive;
        public GSNResultData ResultData = new GSNResultData();
        public string liveURL = "";
        public string betaURL = "";
        private string cryptoKey;
        private GSN_Profile.ProfileSoapClient liveWebservice;
        private GSN_Profile.ProfileResponse liveResponse;
        private string liveEndpoint;
        private BETAGSN_Profile.ProfileSoapClient betaWebservice;
        private BETAGSN_Profile.ProfileResponse betaResponse;
        private string betaEndpoint;

        public GSN_Class(bool useLive=false)
        {
            this.cryptoKey = "";
            this.useLive = useLive;
            this.setEndpoints();
            this.liveWebservice = new GSN_Profile.ProfileSoapClient(this.liveEndpoint);
            this.betaWebservice = new BETAGSN_Profile.ProfileSoapClient(this.betaEndpoint);
        }

        public void toggleLive()
        {
            if (this.useLive)
            {
                this.useLive = false;
            }
            else
            {
                this.useLive = true;
            }
        }

        public void setEndpoints(string endpoint=null)
        {
            if (endpoint != null)
            {
                endpoint.ToLower();
            }
            switch (endpoint)
            {
                case "soap 1.1":
                    {
                        this.liveEndpoint = "ProfileSoap";
                        this.betaEndpoint = "ProfileSoap1";
                    }break;
                case "soap 1.2":
                    {
                        this.liveEndpoint = "ProfileSoap12";
                        this.betaEndpoint = "ProfileSoap121";
                    } break;
                default:
                    {
                        this.liveEndpoint = "ProfileSoap";
                        this.betaEndpoint = "ProfileSoap1";
                    }break;
            }
        }

        public string Encrypt(string message)
        {
            LegacyCryptoKey ck = new LegacyCryptoKey();
            ck.BuildKey(this.cryptoKey);
            byte[] data = UTF8Encoding.UTF8.GetBytes(message);
            MemoryStream ms = new MemoryStream();
            DESCryptoServiceProvider csp = new DESCryptoServiceProvider();
            CryptoStream cs = new CryptoStream(ms, csp.CreateEncryptor(ck.Key, ck.IV), CryptoStreamMode.Write);
            cs.Write(data, 0, data.Length);
            cs.FlushFinalBlock();
            byte[] result = new byte[ms.Position];
            ms.Position = 0;
            ms.Read(result, 0, result.Length);
            cs.Close();
            ms.Close();
            string encrypted = Convert.ToBase64String(result);
            return encrypted;
        }

        public string Decrypt(string message)
        {
            if (message == "" || message == null)
            {
                return String.Empty;
            }
            byte[] bData = Convert.FromBase64String(message);
            LegacyCryptoKey ck = new LegacyCryptoKey();
            ck.BuildKey(this.cryptoKey);
            MemoryStream memoryStream = new MemoryStream(bData.Length);
            DESCryptoServiceProvider desCryptoServiceProvider = new DESCryptoServiceProvider();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, desCryptoServiceProvider.CreateDecryptor(ck.Key, ck.IV), CryptoStreamMode.Read);
            memoryStream.Write(bData, 0, bData.Length);
            memoryStream.Position = 0;
            string decrypted = new StreamReader(cryptoStream).ReadToEnd();
            cryptoStream.Close();
            return decrypted;
        }

        public void GetProfile(int ProfileID)
        {
            if (this.useLive)
            {
                this.liveResponse = liveWebservice.GetProfile(ProfileID);
                this.setResultData();
            }
            else
            {
                this.betaResponse = betaWebservice.GetProfile(ProfileID);
                this.setResultData();
            }
            
        }

        public void SaveProfile(string profileData)
        {
            profileData = this.Encrypt(profileData);
            if (this.useLive)
            {
                this.liveResponse = liveWebservice.SaveProfile(profileData);
                this.setResultData();
            }
            else
            {
                this.betaResponse = betaWebservice.SaveProfile(profileData);
                this.setResultData();
            }
        }

        public void ListProfiles(DateTime startDate)
        {
            if (this.useLive)
            {
                this.liveResponse = liveWebservice.ListProfiles(startDate);
                this.setResultData();
            }
            else
            {
                this.betaResponse = betaWebservice.ListProfiles(startDate);
                this.setResultData();
            }
        }

        public void Search(string query, string field, DateTime startDate)
        {
            this.ResultData.encString = null;
            this.ResultData.decString = null;
            this.ListProfiles(startDate);
            this.ResultData.searchResults = new List<string>();
            if (this.ResultData.status)
            {
                XmlDocument Profile = new XmlDocument();
                Profile.LoadXml(this.ResultData.decString);
                XmlElement root = Profile.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("Profile");
                
                // step
                List<int> IDList = new List<int>();
                foreach (XmlNode node in nodes)
                {
                    IDList.Add(Convert.ToInt32(node.SelectSingleNode("ProfileID").InnerText));
                }

                // step
                while (IDList.Count() > 1)
                {
                    this.GetProfile(IDList[0]);
                    if (this.ResultData.status)
                    {
                        this.ResultData.searchResults.Add(this.ResultData.decString);

                    }
                    IDList.Remove(IDList[0]);
                }
                IDList = null;

                // step
                for (int i = 0; i < this.ResultData.searchResults.Count(); i++)
                {
                    Profile.LoadXml(this.ResultData.searchResults[i]);
                    root = Profile.DocumentElement;
                    nodes = root.SelectNodes(field);
                    foreach (XmlNode node in nodes)
                    {
                        if (query != node.InnerText)
                        {
                            this.ResultData.searchResults.Remove(this.ResultData.searchResults[i]);
                            i--;
                        }
                    }   
                }
                this.ResultData.encString = null;
                this.ResultData.decString = null;
            }
        }

        private void setResultData()
        {
            if (this.useLive)
            {
                if (this.liveResponse.ErrorMessage == null)
                {
                    this.ResultData.status = true;
                    this.ResultData.encString = this.liveResponse.ProfileData;
                    this.ResultData.decString = this.Decrypt(this.liveResponse.ProfileData);
                }
                else
                {
                    this.ResultData.status = false;
                    this.ResultData.encString = this.liveResponse.ErrorMessage;
                    this.ResultData.decString = this.Decrypt(this.liveResponse.ErrorMessage);
                }
            }
            else
            {
                if (this.betaResponse.ErrorMessage == null)
                {
                    this.ResultData.status = true;
                    this.ResultData.encString = this.betaResponse.ProfileData;
                    this.ResultData.decString = this.Decrypt(this.betaResponse.ProfileData);
                }
                else
                {
                    this.ResultData.status = false;
                    this.ResultData.encString = this.betaResponse.ErrorMessage;
                    this.ResultData.decString = this.Decrypt(this.betaResponse.ErrorMessage);
                }
            }
        }

    }
}