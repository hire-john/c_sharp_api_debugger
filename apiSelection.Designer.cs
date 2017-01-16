namespace GSN
{
    partial class apiSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdPresetUrls = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPresetKeys = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadUrl = new System.Windows.Forms.Button();
            this.btnLoadKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "API KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "API URL";
            // 
            // cmdPresetUrls
            // 
            this.cmdPresetUrls.FormattingEnabled = true;
            this.cmdPresetUrls.Items.AddRange(new object[] {
            "http://foodcity.gsnrecipes.com/webservice/external/",
            "http://foodcity.beta.groceryshopping.net/webservice/external/"});
            this.cmdPresetUrls.Location = new System.Drawing.Point(20, 93);
            this.cmdPresetUrls.Name = "cmdPresetUrls";
            this.cmdPresetUrls.Size = new System.Drawing.Size(472, 21);
            this.cmdPresetUrls.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL PRESETS";
            // 
            // cmbPresetKeys
            // 
            this.cmbPresetKeys.FormattingEnabled = true;
            this.cmbPresetKeys.Items.AddRange(new object[] {
            "db3a3d8862c83947",
            "db3a3d88-1d0e-472b-9980-de5b62c83947"});
            this.cmbPresetKeys.Location = new System.Drawing.Point(20, 42);
            this.cmbPresetKeys.Name = "cmbPresetKeys";
            this.cmbPresetKeys.Size = new System.Drawing.Size(472, 21);
            this.cmbPresetKeys.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PRESET API KEYS";
            // 
            // btnLoadUrl
            // 
            this.btnLoadUrl.Location = new System.Drawing.Point(508, 91);
            this.btnLoadUrl.Name = "btnLoadUrl";
            this.btnLoadUrl.Size = new System.Drawing.Size(75, 23);
            this.btnLoadUrl.TabIndex = 6;
            this.btnLoadUrl.Text = "LOAD URL";
            this.btnLoadUrl.UseVisualStyleBackColor = true;
            this.btnLoadUrl.Click += new System.EventHandler(this.btnLoadUrl_Click);
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.Location = new System.Drawing.Point(508, 40);
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(75, 23);
            this.btnLoadKey.TabIndex = 7;
            this.btnLoadKey.Text = "LOAD KEY";
            this.btnLoadKey.UseVisualStyleBackColor = true;
            this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadKey);
            this.groupBox1.Controls.Add(this.btnLoadUrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbPresetKeys);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmdPresetUrls);
            this.groupBox1.Location = new System.Drawing.Point(29, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API PRESETS";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(48, 41);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(555, 20);
            this.txtKey.TabIndex = 9;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(48, 100);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(555, 20);
            this.txtUrl.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(217, 139);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(214, 36);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // apiSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 337);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "apiSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSN Connector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdPresetUrls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPresetKeys;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadUrl;
        private System.Windows.Forms.Button btnLoadKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnConnect;
    }
}

