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

namespace GSN
{
    public partial class frmProfileView : Form
    {
        public frmProfileView(string resultString)
        {
            InitializeComponent();
            XmlDocument Profile = new XmlDocument();
            Profile.LoadXml(resultString);
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
    }
}
