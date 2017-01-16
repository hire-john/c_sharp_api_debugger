using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Threading;


namespace GSN
{
    public partial class frmMain : Form
    {
        private GSN_Class GSNObject;
        private bool searchThreadActive = false;
        private Thread searchThread;

        private void frmMain_Closing()
        {
            Application.Exit();
        }

        public frmMain()
        {
            InitializeComponent();
            this.GSNObject = new GSN_Class(false);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfileEditor_Click(object sender, EventArgs e)
        {
            grpProfileBrowser.Visible = false;
            grpEncryption.Visible = false;
            grpProfileEditor.Visible = true;
            grpAPIDocs.Visible = false;
            grpSearchAPI.Visible = false;
        }

        private void btnProfileBrowser_Click(object sender, EventArgs e)
        {
            grpProfileBrowser.Visible = true;
            grpEncryption.Visible = false;
            grpProfileEditor.Visible = false;
            grpAPIDocs.Visible = false;
            grpSearchAPI.Visible = false;
        }

        private void btnEncryptGrp_Click(object sender, EventArgs e)
        {
            grpProfileBrowser.Visible = false;
            grpProfileEditor.Visible = false;
            grpEncryption.Visible = true;
            grpAPIDocs.Visible = false;
            grpSearchAPI.Visible = false;
        }

        private void btnProfileSearch_Click(object sender, EventArgs e)
        {
            grpProfileBrowser.Visible = false;
            grpProfileEditor.Visible = false;
            grpEncryption.Visible = false;
            grpAPIDocs.Visible = false;
            grpSearchAPI.Visible = true;
        }

        private void btnApiDocs_Click(object sender, EventArgs e)
        {
            grpProfileBrowser.Visible = false;
            grpProfileEditor.Visible = false;
            grpEncryption.Visible = false;
            grpSearchAPI.Visible = false;
            grpAPIDocs.Visible = true;
        }

        private void lblKey_Click(object sender, EventArgs e)
        {

        }

        private void btnCovertEncrypt_Click(object sender, EventArgs e)
        {
            if (txtDecrypted.Text == "" && txtEncrypted.Text == "")
            {
                MessageBox.Show("You must provide either an encrypted or decrypted string!");
                return;
            }

            if (txtEncrypted.Text != "" && txtDecrypted.Text != "")
            {
                MessageBox.Show("You must provide either an encrypted or decrypted string... not both!");
                return;
            }

            if (txtEncrypted.Text == "" && txtDecrypted.Text != "")
            {
                txtEncrypted.Text = this.GSNObject.Encrypt(txtDecrypted.Text);
            }

            if (txtEncrypted.Text != "" && txtDecrypted.Text == "")
            {
                txtDecrypted.Text = this.GSNObject.Decrypt(txtEncrypted.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string xmlString = this.buildProfileString();
            string encryptedString = this.GSNObject.Encrypt(xmlString);
            this.GSNObject.SaveProfile(xmlString);
            if (this.GSNObject.ResultData.status)
            {
                MessageBox.Show("Profile: " + this.GSNObject.ResultData.decString + " has been success saved!");
            }
            else
            {
                MessageBox.Show(this.GSNObject.ResultData.decString);
            }
            txtXMLString.Text = xmlString;
            txtEncString.Text = encryptedString;
            txtDecResponse.Text = this.GSNObject.ResultData.decString;
            txtEncResponse.Text = this.GSNObject.ResultData.encString;
        }

        private string buildProfileString()
        {
            string[] txtFields = new String[14];
            string profileString = null;
            txtFields[0] = "<ProfileID>" + txtProfileID.Text + "</ProfileID>";
            txtFields[1] = "<City>" + txtCity.Text + "</City>";
            txtFields[2] = "<Email>" + txtEmail.Text + "</Email>";
            txtFields[3] = "<ExternalID>" + txtExternalID.Text + "</ExternalID>";
            txtFields[4] = "<FirstName>" + txtFirstName.Text + "</FirstName>";
            txtFields[5] = "<LastName>" + txtLastName.Text + "</LastName>";
            txtFields[6] = "<Password>" + txtPassword.Text + "</Password>";
            txtFields[7] = "<Phone>" + txtPhone.Text + "</Phone>";
            txtFields[8] = "<PostalCode>" + txtPostalCode.Text + "</PostalCode>";
            txtFields[9] = "<PrimaryAddress>" + txtPrimary.Text + "</PrimaryAddress>";
            txtFields[10] = "<SecondaryAddress>" + txtSecondary.Text + "</SecondaryAddress>";
            txtFields[11] = "<State>" + txtState.Text + "</State>";
            txtFields[12] = "<Username>" + txtUsername.Text + "</Username>";
            txtFields[13] = "<StoreNumber>" + txtStoreNumber.Text + "</StoreNumber>";

            for (int i = 0; i < txtFields.Length; ++i)
            {
                profileString += txtFields[i];
            }

            return profileString;
        }

        private void btnSwitchAPI_Click(object sender, EventArgs e)
        {
            if (cmbAPISelector.Text == "GSN BETA")
            {
                this.GSNObject.useLive = false;
                lblUsingApi.Text = "Using GSN BETA";
            }

            if (cmbAPISelector.Text == "GSN LIVE")
            {
                this.GSNObject.useLive = true;
                lblUsingApi.Text = "Using GSN LIVE";
            }
        }

        private void btnGetProfile_Click(object sender, EventArgs e)
        {
            pbRequestProgress.Value = 0;

            if (txtProfileID.Text == "0" || txtProfileID.Text == "")
            {
                MessageBox.Show("Please provide a valid non-zero ProfileID to get!");
                return;
            }

            int ProfileID = Convert.ToInt32(txtProfileID.Text);
            this.GSNObject.GetProfile(ProfileID);
            if (this.GSNObject.ResultData.status)
            {
                this.populateProfileForm(this.GSNObject.ResultData.decString);
            }
            else
            {
                MessageBox.Show(this.GSNObject.ResultData.decString);
            }
            txtXMLString.Text = this.GSNObject.ResultData.decString;
            txtEncString.Text = this.GSNObject.ResultData.encString;
        }

        private void populateProfileForm(string xmlString)
        {
            //92713053
            XmlDocument Profile = new XmlDocument();
            Profile.LoadXml(xmlString);
            txtProfileID.Text = Profile.DocumentElement.SelectSingleNode("ProfileID").InnerText;
            txtCity.Text = Profile.DocumentElement.SelectSingleNode("City").InnerText;
            txtEmail.Text = Profile.DocumentElement.SelectSingleNode("Email").InnerText;
            txtExternalID.Text = Profile.DocumentElement.SelectSingleNode("ExternalID").InnerText;
            txtFirstName.Text = Profile.DocumentElement.SelectSingleNode("FirstName").InnerText;
            txtLastName.Text = Profile.DocumentElement.SelectSingleNode("LastName").InnerText;
            txtPassword.Text = Profile.DocumentElement.SelectSingleNode("Password").InnerText;
            txtPhone.Text = Profile.DocumentElement.SelectSingleNode("Phone").InnerText;
            txtPostalCode.Text = Profile.DocumentElement.SelectSingleNode("PostalCode").InnerText;
            txtPrimary.Text = Profile.DocumentElement.SelectSingleNode("PrimaryAddress").InnerText;
            txtSecondary.Text = Profile.DocumentElement.SelectSingleNode("SecondaryAddress").InnerText;
            txtUsername.Text = Profile.DocumentElement.SelectSingleNode("UserName").InnerText;
            txtStoreNumber.Text = Profile.DocumentElement.SelectSingleNode("StoreNumber").InnerText;
        }

        private void btnLoadProfiles_Click(object sender, EventArgs e)
        {
            dgProfileResults.RowCount = 0;
            DateTime startDate = dateTimeProfiles.Value;
            this.GSNObject.ListProfiles(startDate);
            if (this.GSNObject.ResultData.status)
            {
                XmlDocument Profile = new XmlDocument();
                Profile.LoadXml(this.GSNObject.ResultData.decString);
                XmlElement root = Profile.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("Profile");
                int i = 0;
                foreach (XmlNode node in nodes)
                {
                    dgProfileResults.Rows.Add();
                    dgProfileResults.Rows[i].Cells[0].Value = node.SelectSingleNode("ProfileID").InnerText;
                    dgProfileResults.Rows[i].Cells[1].Value = node.SelectSingleNode("ModifyDate").InnerText;
                    i++;
                }
                lblTotalResults.Text = "Total Profiles: " + i;
            }
            txtEncProfileResult.Text = this.GSNObject.ResultData.encString;
            txtProfileResult.Text = this.GSNObject.ResultData.decString;
        }

        private void dgProfileResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int ProfileID = Convert.ToInt32(dgProfileResults.Rows[rowIndex].Cells[0].Value);
            this.GSNObject.GetProfile(ProfileID);
            if (this.GSNObject.ResultData.status)
            {
                Form ProfileViewer = new frmProfileView(this.GSNObject.ResultData.decString);
                ProfileViewer.Show();
            }
        }

        private void picCopyOne_Click(object sender, EventArgs e)
        {
            txtClipboard.Text = txtEncrypted.Text;
        }

        private void picCopyTwo_Click(object sender, EventArgs e)
        {
            txtClipboard.Text = txtDecrypted.Text;
        }

        private void btnClearDec_Click_1(object sender, EventArgs e)
        {
            txtDecrypted.Clear();
        }

        private void btnClearEnc_Click(object sender, EventArgs e)
        {
            txtEncrypted.Clear();
        }

        private void cmbUrlSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string URL;
            if (this.GSNObject.useLive)
            {
                URL = this.GSNObject.liveURL;
            }
            else
            {
                URL = this.GSNObject.betaURL;
            }

            switch (cmbUrlSelector.Text)
            {
                case "PROFILE":
                    {
                        URL += "profile.asmx";
                    } break;

                case "CIRCULAR":
                    {
                        URL += "circular.asmx";
                    } break;

                case "RECIPE":
                    {
                        URL += "recipe.asmx";
                    } break;

                case "SHOPPING LIST":
                    {
                        URL += "shoppinglist.asmx";
                    } break;

                case "ARTICLE":
                    {
                        URL += "article.asmx";
                    } break;

                case "COUPON":
                    {
                        URL += "coupon.asmx";
                    } break;
            }
            docBrowser.Navigate(URL);
            docBrowser.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.searchThreadActive)
            {
                this.searchThread.Abort();
            }
            else
            {
                dgSearchResults.RowCount = 0;
                string query = txtQuery.Text;
                string field = cmbSearchFields.Text;
                DateTime startDate = dtpSearchStart.Value;
                this.searchThread = new Thread(() => this.GSNObject.Search(query, field, startDate));
                this.searchThreadActive = true;
                this.searchThread.IsBackground = true;
                searchThread.Start();
            }
            
            
            
            int i = 0;
            XmlDocument Profile = new XmlDocument();
            XmlElement root;
            foreach (string profile in this.GSNObject.ResultData.searchResults)
            {
                Profile.LoadXml(profile);
                root = Profile.DocumentElement;
                dgSearchResults.Rows.Add();
                dgSearchResults.Rows[i].Cells[0].Value = root.SelectSingleNode("ProfileID").InnerText;
                dgSearchResults.Rows[i].Cells[1].Value = root.SelectSingleNode("Email").InnerText;
                dgSearchResults.Rows[i].Cells[2].Value = root.SelectSingleNode("UserName").InnerText;
                dgSearchResults.Rows[i].Cells[3].Value = root.SelectSingleNode("ExternalID").InnerText;
                dgSearchResults.Rows[i].Cells[4].Value = root.SelectSingleNode("FirstName").InnerText;
                dgSearchResults.Rows[i].Cells[5].Value = root.SelectSingleNode("LastName").InnerText;
                dgSearchResults.Rows[i].Cells[6].Value = root.SelectSingleNode("Phone").InnerText;
                i++;
            }
        }
    }
}