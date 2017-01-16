using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSN
{
    public partial class apiSelection : Form
    {

        public apiSelection()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            if (cmbPresetKeys.Text == "")
            {
                MessageBox.Show("Please select a value from the list!");
            }else{
                txtKey.Text = cmbPresetKeys.Text;
            }
        }

        private void btnLoadUrl_Click(object sender, EventArgs e)
        {
            if (cmdPresetUrls.Text == "")
            {
                MessageBox.Show("Please select a value from the list!");
            }
            else
            {
                txtUrl.Text = cmdPresetUrls.Text;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "" || txtUrl.Text == "")
            {
                MessageBox.Show("You must supply or choose a Key and API URL!");
            }
            else
            {
                this.Hide();
                frmMain newMainForm = new frmMain(txtKey.Text, txtUrl.Text);
                newMainForm.ShowDialog();
                newMainForm.Dispose();
                
            }
            
        }

    }
}
