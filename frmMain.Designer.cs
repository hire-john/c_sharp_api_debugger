namespace GSN
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUsingApi = new System.Windows.Forms.Label();
            this.btnApiDocs = new System.Windows.Forms.Button();
            this.btnProfileSearch = new System.Windows.Forms.Button();
            this.btnSwitchAPI = new System.Windows.Forms.Button();
            this.lblApiSelector = new System.Windows.Forms.Label();
            this.cmbAPISelector = new System.Windows.Forms.ComboBox();
            this.btnEncryptGrp = new System.Windows.Forms.Button();
            this.btnProfileBrowser = new System.Windows.Forms.Button();
            this.grpProgress = new System.Windows.Forms.GroupBox();
            this.pbRequestProgress = new System.Windows.Forms.ProgressBar();
            this.btnProfileEditor = new System.Windows.Forms.Button();
            this.grpProfileEditor = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEncResponse = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblResponseString = new System.Windows.Forms.Label();
            this.txtDecResponse = new System.Windows.Forms.TextBox();
            this.btnGetProfile = new System.Windows.Forms.Button();
            this.lblEncryptedProfileString = new System.Windows.Forms.Label();
            this.txtEncString = new System.Windows.Forms.TextBox();
            this.lblProfileString = new System.Windows.Forms.Label();
            this.txtXMLString = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSecondary = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrimary = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtExternalID = new System.Windows.Forms.TextBox();
            this.txtStoreNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtProfileID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEncryption = new System.Windows.Forms.GroupBox();
            this.picCopyTwo = new System.Windows.Forms.PictureBox();
            this.picCopyOne = new System.Windows.Forms.PictureBox();
            this.txtClipboard = new System.Windows.Forms.TextBox();
            this.lblExtraClipboard = new System.Windows.Forms.Label();
            this.btnClearEnc = new System.Windows.Forms.Button();
            this.btnClearDec = new System.Windows.Forms.Button();
            this.btnCovertEncrypt = new System.Windows.Forms.Button();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bgWrkGetProfile = new System.ComponentModel.BackgroundWorker();
            this.profileResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadProfiles = new System.Windows.Forms.Button();
            this.dateTimeProfiles = new System.Windows.Forms.DateTimePicker();
            this.lblProfileCreatedAfter = new System.Windows.Forms.Label();
            this.dgProfileResults = new System.Windows.Forms.DataGridView();
            this.ProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProfileResult = new System.Windows.Forms.TextBox();
            this.txtEncProfileResult = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpProfileBrowser = new System.Windows.Forms.GroupBox();
            this.lblTotalResults = new System.Windows.Forms.Label();
            this.grpSearchAPI = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpSearchStart = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dgSearchResults = new System.Windows.Forms.DataGridView();
            this.cmbSearchFields = new System.Windows.Forms.ComboBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAPIDocs = new System.Windows.Forms.GroupBox();
            this.cmbUrlSelector = new System.Windows.Forms.ComboBox();
            this.docBrowser = new System.Windows.Forms.WebBrowser();
            this.ProfileIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExternalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.grpProgress.SuspendLayout();
            this.grpProfileEditor.SuspendLayout();
            this.grpEncryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfileResults)).BeginInit();
            this.grpProfileBrowser.SuspendLayout();
            this.grpSearchAPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchResults)).BeginInit();
            this.grpAPIDocs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUsingApi);
            this.groupBox2.Controls.Add(this.btnApiDocs);
            this.groupBox2.Controls.Add(this.btnProfileSearch);
            this.groupBox2.Controls.Add(this.btnSwitchAPI);
            this.groupBox2.Controls.Add(this.lblApiSelector);
            this.groupBox2.Controls.Add(this.cmbAPISelector);
            this.groupBox2.Controls.Add(this.btnEncryptGrp);
            this.groupBox2.Controls.Add(this.btnProfileBrowser);
            this.groupBox2.Controls.Add(this.grpProgress);
            this.groupBox2.Controls.Add(this.btnProfileEditor);
            this.groupBox2.Location = new System.Drawing.Point(31, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 627);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPTIONS";
            // 
            // lblUsingApi
            // 
            this.lblUsingApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsingApi.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUsingApi.Location = new System.Drawing.Point(13, 259);
            this.lblUsingApi.Name = "lblUsingApi";
            this.lblUsingApi.Size = new System.Drawing.Size(173, 18);
            this.lblUsingApi.TabIndex = 11;
            this.lblUsingApi.Text = "Using GSN BETA";
            this.lblUsingApi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApiDocs
            // 
            this.btnApiDocs.Location = new System.Drawing.Point(14, 136);
            this.btnApiDocs.Name = "btnApiDocs";
            this.btnApiDocs.Size = new System.Drawing.Size(173, 23);
            this.btnApiDocs.TabIndex = 10;
            this.btnApiDocs.Text = "API DOCUMENTATION";
            this.btnApiDocs.UseVisualStyleBackColor = true;
            this.btnApiDocs.Click += new System.EventHandler(this.btnApiDocs_Click);
            // 
            // btnProfileSearch
            // 
            this.btnProfileSearch.Location = new System.Drawing.Point(14, 110);
            this.btnProfileSearch.Name = "btnProfileSearch";
            this.btnProfileSearch.Size = new System.Drawing.Size(173, 23);
            this.btnProfileSearch.TabIndex = 9;
            this.btnProfileSearch.Text = "PROFILE SEARCH";
            this.btnProfileSearch.UseVisualStyleBackColor = true;
            this.btnProfileSearch.Click += new System.EventHandler(this.btnProfileSearch_Click);
            // 
            // btnSwitchAPI
            // 
            this.btnSwitchAPI.Location = new System.Drawing.Point(14, 228);
            this.btnSwitchAPI.Name = "btnSwitchAPI";
            this.btnSwitchAPI.Size = new System.Drawing.Size(173, 23);
            this.btnSwitchAPI.TabIndex = 8;
            this.btnSwitchAPI.Text = "SWITCH API";
            this.btnSwitchAPI.UseVisualStyleBackColor = true;
            this.btnSwitchAPI.Click += new System.EventHandler(this.btnSwitchAPI_Click);
            // 
            // lblApiSelector
            // 
            this.lblApiSelector.AutoSize = true;
            this.lblApiSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApiSelector.Location = new System.Drawing.Point(14, 181);
            this.lblApiSelector.Name = "lblApiSelector";
            this.lblApiSelector.Size = new System.Drawing.Size(88, 13);
            this.lblApiSelector.TabIndex = 7;
            this.lblApiSelector.Text = "API Selection:";
            // 
            // cmbAPISelector
            // 
            this.cmbAPISelector.FormattingEnabled = true;
            this.cmbAPISelector.Items.AddRange(new object[] {
            "GSN BETA",
            "GSN LIVE"});
            this.cmbAPISelector.Location = new System.Drawing.Point(14, 201);
            this.cmbAPISelector.Name = "cmbAPISelector";
            this.cmbAPISelector.Size = new System.Drawing.Size(173, 21);
            this.cmbAPISelector.TabIndex = 6;
            this.cmbAPISelector.Text = "GSN BETA";
            // 
            // btnEncryptGrp
            // 
            this.btnEncryptGrp.Location = new System.Drawing.Point(14, 84);
            this.btnEncryptGrp.Name = "btnEncryptGrp";
            this.btnEncryptGrp.Size = new System.Drawing.Size(173, 23);
            this.btnEncryptGrp.TabIndex = 5;
            this.btnEncryptGrp.Text = "ENCRYPT/DECRYPT";
            this.btnEncryptGrp.UseVisualStyleBackColor = true;
            this.btnEncryptGrp.Click += new System.EventHandler(this.btnEncryptGrp_Click);
            // 
            // btnProfileBrowser
            // 
            this.btnProfileBrowser.Location = new System.Drawing.Point(14, 58);
            this.btnProfileBrowser.Name = "btnProfileBrowser";
            this.btnProfileBrowser.Size = new System.Drawing.Size(173, 23);
            this.btnProfileBrowser.TabIndex = 1;
            this.btnProfileBrowser.Text = "PROFILE BROWSER";
            this.btnProfileBrowser.UseVisualStyleBackColor = true;
            this.btnProfileBrowser.Click += new System.EventHandler(this.btnProfileBrowser_Click);
            // 
            // grpProgress
            // 
            this.grpProgress.Controls.Add(this.pbRequestProgress);
            this.grpProgress.Location = new System.Drawing.Point(14, 590);
            this.grpProgress.Name = "grpProgress";
            this.grpProgress.Size = new System.Drawing.Size(159, 31);
            this.grpProgress.TabIndex = 4;
            this.grpProgress.TabStop = false;
            this.grpProgress.Text = "REQUEST PROGRESS";
            // 
            // pbRequestProgress
            // 
            this.pbRequestProgress.Location = new System.Drawing.Point(11, 16);
            this.pbRequestProgress.Name = "pbRequestProgress";
            this.pbRequestProgress.Size = new System.Drawing.Size(142, 10);
            this.pbRequestProgress.Step = 50;
            this.pbRequestProgress.TabIndex = 0;
            // 
            // btnProfileEditor
            // 
            this.btnProfileEditor.Location = new System.Drawing.Point(14, 32);
            this.btnProfileEditor.Name = "btnProfileEditor";
            this.btnProfileEditor.Size = new System.Drawing.Size(173, 23);
            this.btnProfileEditor.TabIndex = 0;
            this.btnProfileEditor.Text = "PROFILE EDITOR";
            this.btnProfileEditor.UseVisualStyleBackColor = true;
            this.btnProfileEditor.Click += new System.EventHandler(this.btnProfileEditor_Click);
            // 
            // grpProfileEditor
            // 
            this.grpProfileEditor.Controls.Add(this.label18);
            this.grpProfileEditor.Controls.Add(this.textBox2);
            this.grpProfileEditor.Controls.Add(this.txtEncResponse);
            this.grpProfileEditor.Controls.Add(this.textBox1);
            this.grpProfileEditor.Controls.Add(this.lblResponseString);
            this.grpProfileEditor.Controls.Add(this.txtDecResponse);
            this.grpProfileEditor.Controls.Add(this.btnGetProfile);
            this.grpProfileEditor.Controls.Add(this.lblEncryptedProfileString);
            this.grpProfileEditor.Controls.Add(this.txtEncString);
            this.grpProfileEditor.Controls.Add(this.lblProfileString);
            this.grpProfileEditor.Controls.Add(this.txtXMLString);
            this.grpProfileEditor.Controls.Add(this.txtState);
            this.grpProfileEditor.Controls.Add(this.label16);
            this.grpProfileEditor.Controls.Add(this.txtSecondary);
            this.grpProfileEditor.Controls.Add(this.label15);
            this.grpProfileEditor.Controls.Add(this.txtPrimary);
            this.grpProfileEditor.Controls.Add(this.label14);
            this.grpProfileEditor.Controls.Add(this.txtPostalCode);
            this.grpProfileEditor.Controls.Add(this.label13);
            this.grpProfileEditor.Controls.Add(this.txtPhone);
            this.grpProfileEditor.Controls.Add(this.label12);
            this.grpProfileEditor.Controls.Add(this.txtLastName);
            this.grpProfileEditor.Controls.Add(this.label11);
            this.grpProfileEditor.Controls.Add(this.txtFirstName);
            this.grpProfileEditor.Controls.Add(this.label9);
            this.grpProfileEditor.Controls.Add(this.txtEmail);
            this.grpProfileEditor.Controls.Add(this.label8);
            this.grpProfileEditor.Controls.Add(this.txtCity);
            this.grpProfileEditor.Controls.Add(this.label7);
            this.grpProfileEditor.Controls.Add(this.btnSave);
            this.grpProfileEditor.Controls.Add(this.txtExternalID);
            this.grpProfileEditor.Controls.Add(this.txtStoreNumber);
            this.grpProfileEditor.Controls.Add(this.txtPassword);
            this.grpProfileEditor.Controls.Add(this.txtUsername);
            this.grpProfileEditor.Controls.Add(this.txtProfileID);
            this.grpProfileEditor.Controls.Add(this.label5);
            this.grpProfileEditor.Controls.Add(this.label4);
            this.grpProfileEditor.Controls.Add(this.label3);
            this.grpProfileEditor.Controls.Add(this.label2);
            this.grpProfileEditor.Controls.Add(this.label1);
            this.grpProfileEditor.Location = new System.Drawing.Point(246, 12);
            this.grpProfileEditor.Name = "grpProfileEditor";
            this.grpProfileEditor.Size = new System.Drawing.Size(855, 627);
            this.grpProfileEditor.TabIndex = 5;
            this.grpProfileEditor.TabStop = false;
            this.grpProfileEditor.Text = "PROFILE EDITOR";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(439, 466);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(218, 18);
            this.label18.TabIndex = 37;
            this.label18.Text = "Encrypted Response String:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(441, 487);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(395, 96);
            this.textBox2.TabIndex = 36;
            // 
            // txtEncResponse
            // 
            this.txtEncResponse.Location = new System.Drawing.Point(440, 487);
            this.txtEncResponse.Multiline = true;
            this.txtEncResponse.Name = "txtEncResponse";
            this.txtEncResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncResponse.Size = new System.Drawing.Size(395, 96);
            this.txtEncResponse.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 487);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(395, 96);
            this.textBox1.TabIndex = 34;
            // 
            // lblResponseString
            // 
            this.lblResponseString.AutoSize = true;
            this.lblResponseString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponseString.Location = new System.Drawing.Point(25, 466);
            this.lblResponseString.Name = "lblResponseString";
            this.lblResponseString.Size = new System.Drawing.Size(138, 18);
            this.lblResponseString.TabIndex = 35;
            this.lblResponseString.Text = "Response String:";
            // 
            // txtDecResponse
            // 
            this.txtDecResponse.Location = new System.Drawing.Point(25, 487);
            this.txtDecResponse.Multiline = true;
            this.txtDecResponse.Name = "txtDecResponse";
            this.txtDecResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecResponse.Size = new System.Drawing.Size(388, 96);
            this.txtDecResponse.TabIndex = 34;
            // 
            // btnGetProfile
            // 
            this.btnGetProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetProfile.Location = new System.Drawing.Point(134, 416);
            this.btnGetProfile.Name = "btnGetProfile";
            this.btnGetProfile.Size = new System.Drawing.Size(179, 22);
            this.btnGetProfile.TabIndex = 33;
            this.btnGetProfile.Text = "GET PROFILE";
            this.btnGetProfile.UseVisualStyleBackColor = true;
            this.btnGetProfile.Click += new System.EventHandler(this.btnGetProfile_Click);
            // 
            // lblEncryptedProfileString
            // 
            this.lblEncryptedProfileString.AutoSize = true;
            this.lblEncryptedProfileString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptedProfileString.Location = new System.Drawing.Point(546, 216);
            this.lblEncryptedProfileString.Name = "lblEncryptedProfileString";
            this.lblEncryptedProfileString.Size = new System.Drawing.Size(217, 18);
            this.lblEncryptedProfileString.TabIndex = 32;
            this.lblEncryptedProfileString.Text = "ENCRYPTED Profile String:";
            // 
            // txtEncString
            // 
            this.txtEncString.Location = new System.Drawing.Point(549, 237);
            this.txtEncString.Multiline = true;
            this.txtEncString.Name = "txtEncString";
            this.txtEncString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncString.Size = new System.Drawing.Size(300, 159);
            this.txtEncString.TabIndex = 31;
            // 
            // lblProfileString
            // 
            this.lblProfileString.AutoSize = true;
            this.lblProfileString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileString.Location = new System.Drawing.Point(546, 29);
            this.lblProfileString.Name = "lblProfileString";
            this.lblProfileString.Size = new System.Drawing.Size(154, 18);
            this.lblProfileString.TabIndex = 30;
            this.lblProfileString.Text = "RAW Profile String:";
            // 
            // txtXMLString
            // 
            this.txtXMLString.Location = new System.Drawing.Point(549, 50);
            this.txtXMLString.Multiline = true;
            this.txtXMLString.Name = "txtXMLString";
            this.txtXMLString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXMLString.Size = new System.Drawing.Size(300, 159);
            this.txtXMLString.TabIndex = 29;
            // 
            // txtState
            // 
            this.txtState.FormattingEnabled = true;
            this.txtState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming",
            "*",
            "District of Columbia",
            "Puerto Rico",
            "Guam",
            "American Samoa",
            "U.S. Virgin Islands",
            "Northern Mariana Islands"});
            this.txtState.Location = new System.Drawing.Point(211, 321);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(325, 21);
            this.txtState.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 18);
            this.label16.TabIndex = 27;
            this.label16.Text = "State:";
            // 
            // txtSecondary
            // 
            this.txtSecondary.Location = new System.Drawing.Point(211, 295);
            this.txtSecondary.Name = "txtSecondary";
            this.txtSecondary.Size = new System.Drawing.Size(325, 20);
            this.txtSecondary.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 18);
            this.label15.TabIndex = 25;
            this.label15.Text = "Secondary Address:";
            // 
            // txtPrimary
            // 
            this.txtPrimary.Location = new System.Drawing.Point(211, 269);
            this.txtPrimary.Name = "txtPrimary";
            this.txtPrimary.Size = new System.Drawing.Size(325, 20);
            this.txtPrimary.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Primary Address:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(211, 243);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(325, 20);
            this.txtPostalCode.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Postal Code:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(211, 217);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(325, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Phone:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(211, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(325, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "LastName:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(211, 139);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(325, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "FirstName:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(211, 61);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(325, 20);
            this.txtCity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "City";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(372, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE PROFILE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExternalID
            // 
            this.txtExternalID.Location = new System.Drawing.Point(211, 113);
            this.txtExternalID.Name = "txtExternalID";
            this.txtExternalID.Size = new System.Drawing.Size(325, 20);
            this.txtExternalID.TabIndex = 4;
            // 
            // txtStoreNumber
            // 
            this.txtStoreNumber.Location = new System.Drawing.Point(211, 374);
            this.txtStoreNumber.Name = "txtStoreNumber";
            this.txtStoreNumber.Size = new System.Drawing.Size(325, 20);
            this.txtStoreNumber.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(211, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(325, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(211, 348);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(325, 20);
            this.txtUsername.TabIndex = 13;
            // 
            // txtProfileID
            // 
            this.txtProfileID.Location = new System.Drawing.Point(211, 35);
            this.txtProfileID.Name = "txtProfileID";
            this.txtProfileID.Size = new System.Drawing.Size(325, 20);
            this.txtProfileID.TabIndex = 1;
            this.txtProfileID.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "ValuCard (External ID):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Store Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username (Email):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProfileID:";
            // 
            // grpEncryption
            // 
            this.grpEncryption.Controls.Add(this.picCopyTwo);
            this.grpEncryption.Controls.Add(this.picCopyOne);
            this.grpEncryption.Controls.Add(this.txtClipboard);
            this.grpEncryption.Controls.Add(this.lblExtraClipboard);
            this.grpEncryption.Controls.Add(this.btnClearEnc);
            this.grpEncryption.Controls.Add(this.btnClearDec);
            this.grpEncryption.Controls.Add(this.btnCovertEncrypt);
            this.grpEncryption.Controls.Add(this.txtDecrypted);
            this.grpEncryption.Controls.Add(this.label6);
            this.grpEncryption.Controls.Add(this.txtEncrypted);
            this.grpEncryption.Controls.Add(this.label10);
            this.grpEncryption.Location = new System.Drawing.Point(246, 12);
            this.grpEncryption.Name = "grpEncryption";
            this.grpEncryption.Size = new System.Drawing.Size(855, 627);
            this.grpEncryption.TabIndex = 7;
            this.grpEncryption.TabStop = false;
            this.grpEncryption.Text = "ENCRYPT/DECRYPT";
            this.grpEncryption.Visible = false;
            // 
            // picCopyTwo
            // 
            this.picCopyTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCopyTwo.Image = ((System.Drawing.Image)(resources.GetObject("picCopyTwo.Image")));
            this.picCopyTwo.Location = new System.Drawing.Point(803, 300);
            this.picCopyTwo.Name = "picCopyTwo";
            this.picCopyTwo.Size = new System.Drawing.Size(32, 42);
            this.picCopyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCopyTwo.TabIndex = 10;
            this.picCopyTwo.TabStop = false;
            this.picCopyTwo.Tag = "Copy from Extra Clipboard";
            this.picCopyTwo.Click += new System.EventHandler(this.picCopyTwo_Click);
            // 
            // picCopyOne
            // 
            this.picCopyOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCopyOne.Image = ((System.Drawing.Image)(resources.GetObject("picCopyOne.Image")));
            this.picCopyOne.Location = new System.Drawing.Point(803, 94);
            this.picCopyOne.Name = "picCopyOne";
            this.picCopyOne.Size = new System.Drawing.Size(32, 42);
            this.picCopyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCopyOne.TabIndex = 9;
            this.picCopyOne.TabStop = false;
            this.picCopyOne.Tag = "Copy from Extra Clipboard";
            this.picCopyOne.Click += new System.EventHandler(this.picCopyOne_Click);
            // 
            // txtClipboard
            // 
            this.txtClipboard.Location = new System.Drawing.Point(25, 552);
            this.txtClipboard.Multiline = true;
            this.txtClipboard.Name = "txtClipboard";
            this.txtClipboard.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtClipboard.Size = new System.Drawing.Size(772, 60);
            this.txtClipboard.TabIndex = 6;
            // 
            // lblExtraClipboard
            // 
            this.lblExtraClipboard.AutoSize = true;
            this.lblExtraClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraClipboard.Location = new System.Drawing.Point(22, 536);
            this.lblExtraClipboard.Name = "lblExtraClipboard";
            this.lblExtraClipboard.Size = new System.Drawing.Size(126, 13);
            this.lblExtraClipboard.TabIndex = 7;
            this.lblExtraClipboard.Text = "EXTRA CLIPBOARD:";
            // 
            // btnClearEnc
            // 
            this.btnClearEnc.Location = new System.Drawing.Point(736, 188);
            this.btnClearEnc.Name = "btnClearEnc";
            this.btnClearEnc.Size = new System.Drawing.Size(61, 23);
            this.btnClearEnc.TabIndex = 2;
            this.btnClearEnc.Text = "CLEAR";
            this.btnClearEnc.UseVisualStyleBackColor = true;
            this.btnClearEnc.Click += new System.EventHandler(this.btnClearEnc_Click);
            // 
            // btnClearDec
            // 
            this.btnClearDec.Location = new System.Drawing.Point(736, 385);
            this.btnClearDec.Name = "btnClearDec";
            this.btnClearDec.Size = new System.Drawing.Size(61, 23);
            this.btnClearDec.TabIndex = 4;
            this.btnClearDec.Text = "CLEAR";
            this.btnClearDec.UseVisualStyleBackColor = true;
            this.btnClearDec.Click += new System.EventHandler(this.btnClearDec_Click_1);
            // 
            // btnCovertEncrypt
            // 
            this.btnCovertEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCovertEncrypt.Location = new System.Drawing.Point(25, 402);
            this.btnCovertEncrypt.Name = "btnCovertEncrypt";
            this.btnCovertEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnCovertEncrypt.TabIndex = 5;
            this.btnCovertEncrypt.Text = "CONVERT";
            this.btnCovertEncrypt.UseVisualStyleBackColor = true;
            this.btnCovertEncrypt.Click += new System.EventHandler(this.btnCovertEncrypt_Click);
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(25, 258);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDecrypted.Size = new System.Drawing.Size(772, 121);
            this.txtDecrypted.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "DECRYPTED:";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(25, 61);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncrypted.Size = new System.Drawing.Size(772, 121);
            this.txtEncrypted.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "ENCRYPTED:";
            // 
            // bgWrkGetProfile
            // 
            this.bgWrkGetProfile.WorkerReportsProgress = true;
            this.bgWrkGetProfile.WorkerSupportsCancellation = true;
            // 
            // profileResponseBindingSource
            // 
            this.profileResponseBindingSource.DataSource = typeof(GSN.GSN_Profile.ProfileResponse);
            // 
            // btnLoadProfiles
            // 
            this.btnLoadProfiles.Location = new System.Drawing.Point(419, 35);
            this.btnLoadProfiles.Name = "btnLoadProfiles";
            this.btnLoadProfiles.Size = new System.Drawing.Size(113, 23);
            this.btnLoadProfiles.TabIndex = 0;
            this.btnLoadProfiles.Text = "LOAD PROFILES";
            this.btnLoadProfiles.UseVisualStyleBackColor = true;
            this.btnLoadProfiles.Click += new System.EventHandler(this.btnLoadProfiles_Click);
            // 
            // dateTimeProfiles
            // 
            this.dateTimeProfiles.Location = new System.Drawing.Point(209, 37);
            this.dateTimeProfiles.Name = "dateTimeProfiles";
            this.dateTimeProfiles.Size = new System.Drawing.Size(204, 20);
            this.dateTimeProfiles.TabIndex = 1;
            // 
            // lblProfileCreatedAfter
            // 
            this.lblProfileCreatedAfter.AutoSize = true;
            this.lblProfileCreatedAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileCreatedAfter.Location = new System.Drawing.Point(27, 40);
            this.lblProfileCreatedAfter.Name = "lblProfileCreatedAfter";
            this.lblProfileCreatedAfter.Size = new System.Drawing.Size(176, 13);
            this.lblProfileCreatedAfter.TabIndex = 2;
            this.lblProfileCreatedAfter.Text = "Select Profiles Created After: ";
            // 
            // dgProfileResults
            // 
            this.dgProfileResults.AllowUserToAddRows = false;
            this.dgProfileResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfileResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileID,
            this.ModifyDate});
            this.dgProfileResults.Location = new System.Drawing.Point(27, 70);
            this.dgProfileResults.Name = "dgProfileResults";
            this.dgProfileResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProfileResults.Size = new System.Drawing.Size(800, 208);
            this.dgProfileResults.TabIndex = 3;
            this.dgProfileResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfileResults_CellContentClick);
            // 
            // ProfileID
            // 
            this.ProfileID.HeaderText = "Profile ID";
            this.ProfileID.Name = "ProfileID";
            this.ProfileID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProfileID.Width = 370;
            // 
            // ModifyDate
            // 
            this.ModifyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ModifyDate.HeaderText = "Modify Date";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ModifyDate.Width = 370;
            // 
            // txtProfileResult
            // 
            this.txtProfileResult.Location = new System.Drawing.Point(27, 313);
            this.txtProfileResult.MaxLength = 2000000;
            this.txtProfileResult.Multiline = true;
            this.txtProfileResult.Name = "txtProfileResult";
            this.txtProfileResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProfileResult.Size = new System.Drawing.Size(386, 301);
            this.txtProfileResult.TabIndex = 4;
            // 
            // txtEncProfileResult
            // 
            this.txtEncProfileResult.Location = new System.Drawing.Point(441, 311);
            this.txtEncProfileResult.MaxLength = 2000000;
            this.txtEncProfileResult.Multiline = true;
            this.txtEncProfileResult.Name = "txtEncProfileResult";
            this.txtEncProfileResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncProfileResult.Size = new System.Drawing.Size(386, 301);
            this.txtEncProfileResult.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(26, 290);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 18);
            this.label19.TabIndex = 33;
            this.label19.Text = "RAW Result String:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(437, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 18);
            this.label17.TabIndex = 34;
            this.label17.Text = "ENCRYPTED Result String:";
            // 
            // grpProfileBrowser
            // 
            this.grpProfileBrowser.Controls.Add(this.lblTotalResults);
            this.grpProfileBrowser.Controls.Add(this.label17);
            this.grpProfileBrowser.Controls.Add(this.label19);
            this.grpProfileBrowser.Controls.Add(this.txtEncProfileResult);
            this.grpProfileBrowser.Controls.Add(this.txtProfileResult);
            this.grpProfileBrowser.Controls.Add(this.dgProfileResults);
            this.grpProfileBrowser.Controls.Add(this.lblProfileCreatedAfter);
            this.grpProfileBrowser.Controls.Add(this.dateTimeProfiles);
            this.grpProfileBrowser.Controls.Add(this.btnLoadProfiles);
            this.grpProfileBrowser.Location = new System.Drawing.Point(246, 12);
            this.grpProfileBrowser.Name = "grpProfileBrowser";
            this.grpProfileBrowser.Size = new System.Drawing.Size(855, 627);
            this.grpProfileBrowser.TabIndex = 6;
            this.grpProfileBrowser.TabStop = false;
            this.grpProfileBrowser.Text = "PROFILE BROWSER";
            this.grpProfileBrowser.Visible = false;
            // 
            // lblTotalResults
            // 
            this.lblTotalResults.AutoSize = true;
            this.lblTotalResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResults.Location = new System.Drawing.Point(562, 37);
            this.lblTotalResults.Name = "lblTotalResults";
            this.lblTotalResults.Size = new System.Drawing.Size(0, 20);
            this.lblTotalResults.TabIndex = 35;
            this.lblTotalResults.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // grpSearchAPI
            // 
            this.grpSearchAPI.Controls.Add(this.label24);
            this.grpSearchAPI.Controls.Add(this.label23);
            this.grpSearchAPI.Controls.Add(this.label22);
            this.grpSearchAPI.Controls.Add(this.dtpSearchStart);
            this.grpSearchAPI.Controls.Add(this.label21);
            this.grpSearchAPI.Controls.Add(this.dgSearchResults);
            this.grpSearchAPI.Controls.Add(this.cmbSearchFields);
            this.grpSearchAPI.Controls.Add(this.txtQuery);
            this.grpSearchAPI.Controls.Add(this.label20);
            this.grpSearchAPI.Controls.Add(this.btnSearch);
            this.grpSearchAPI.Location = new System.Drawing.Point(246, 12);
            this.grpSearchAPI.Name = "grpSearchAPI";
            this.grpSearchAPI.Size = new System.Drawing.Size(855, 627);
            this.grpSearchAPI.TabIndex = 36;
            this.grpSearchAPI.TabStop = false;
            this.grpSearchAPI.Text = "PROFILE SEARCH";
            this.grpSearchAPI.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(576, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "Search Field:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(369, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Start Date:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Search Term:";
            // 
            // dtpSearchStart
            // 
            this.dtpSearchStart.Location = new System.Drawing.Point(371, 38);
            this.dtpSearchStart.Name = "dtpSearchStart";
            this.dtpSearchStart.Size = new System.Drawing.Size(200, 20);
            this.dtpSearchStart.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(28, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 5;
            this.label21.Text = "RESULTS:";
            // 
            // dgSearchResults
            // 
            this.dgSearchResults.AllowUserToAddRows = false;
            this.dgSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileIDCol,
            this.Email,
            this.UserName,
            this.ExternalID,
            this.FirstName,
            this.LastName,
            this.Phone});
            this.dgSearchResults.Location = new System.Drawing.Point(29, 89);
            this.dgSearchResults.Name = "dgSearchResults";
            this.dgSearchResults.Size = new System.Drawing.Size(797, 523);
            this.dgSearchResults.TabIndex = 4;
            // 
            // cmbSearchFields
            // 
            this.cmbSearchFields.FormattingEnabled = true;
            this.cmbSearchFields.Items.AddRange(new object[] {
            "ProfileID",
            "City",
            "Email",
            "ExternalID",
            "Phone",
            "PrimaryAddress",
            "UserName"});
            this.cmbSearchFields.Location = new System.Drawing.Point(577, 38);
            this.cmbSearchFields.Name = "cmbSearchFields";
            this.cmbSearchFields.Size = new System.Drawing.Size(171, 21);
            this.cmbSearchFields.TabIndex = 3;
            this.cmbSearchFields.Text = "Select Field...";
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(27, 39);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(338, 20);
            this.txtQuery.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(530, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(297, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Profile searches can be lengthy! Please be patient.";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(754, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpAPIDocs
            // 
            this.grpAPIDocs.Controls.Add(this.cmbUrlSelector);
            this.grpAPIDocs.Controls.Add(this.docBrowser);
            this.grpAPIDocs.Location = new System.Drawing.Point(246, 12);
            this.grpAPIDocs.Name = "grpAPIDocs";
            this.grpAPIDocs.Size = new System.Drawing.Size(855, 627);
            this.grpAPIDocs.TabIndex = 37;
            this.grpAPIDocs.TabStop = false;
            this.grpAPIDocs.Text = "API DOCUMENTATION";
            this.grpAPIDocs.Visible = false;
            // 
            // cmbUrlSelector
            // 
            this.cmbUrlSelector.FormattingEnabled = true;
            this.cmbUrlSelector.Items.AddRange(new object[] {
            "PROFILE",
            "CIRCULAR",
            "RECIPE",
            "SHOPPING LIST",
            "ARTICLE",
            "COUPON"});
            this.cmbUrlSelector.Location = new System.Drawing.Point(586, 33);
            this.cmbUrlSelector.Name = "cmbUrlSelector";
            this.cmbUrlSelector.Size = new System.Drawing.Size(249, 21);
            this.cmbUrlSelector.TabIndex = 1;
            this.cmbUrlSelector.Text = "Select API Section...";
            this.cmbUrlSelector.SelectedIndexChanged += new System.EventHandler(this.cmbUrlSelector_SelectedIndexChanged);
            // 
            // docBrowser
            // 
            this.docBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.docBrowser.Location = new System.Drawing.Point(3, 64);
            this.docBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.docBrowser.Name = "docBrowser";
            this.docBrowser.Size = new System.Drawing.Size(849, 560);
            this.docBrowser.TabIndex = 0;
            this.docBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.docBrowser.Visible = false;
            // 
            // ProfileIDCol
            // 
            this.ProfileIDCol.HeaderText = "ProfileID";
            this.ProfileIDCol.Name = "ProfileIDCol";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // ExternalID
            // 
            this.ExternalID.HeaderText = "ExternalID";
            this.ExternalID.Name = "ExternalID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 651);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSearchAPI);
            this.Controls.Add(this.grpProfileBrowser);
            this.Controls.Add(this.grpEncryption);
            this.Controls.Add(this.grpProfileEditor);
            this.Controls.Add(this.grpAPIDocs);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSN Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpProgress.ResumeLayout(false);
            this.grpProfileEditor.ResumeLayout(false);
            this.grpProfileEditor.PerformLayout();
            this.grpEncryption.ResumeLayout(false);
            this.grpEncryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfileResults)).EndInit();
            this.grpProfileBrowser.ResumeLayout(false);
            this.grpProfileBrowser.PerformLayout();
            this.grpSearchAPI.ResumeLayout(false);
            this.grpSearchAPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchResults)).EndInit();
            this.grpAPIDocs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProfileBrowser;
        private System.Windows.Forms.Button btnProfileEditor;
        private System.Windows.Forms.GroupBox grpProgress;
        private System.Windows.Forms.ProgressBar pbRequestProgress;
        private System.Windows.Forms.GroupBox grpProfileEditor;
        private System.Windows.Forms.Button btnEncryptGrp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtExternalID;
        private System.Windows.Forms.TextBox txtStoreNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtProfileID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEncryption;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCovertEncrypt;
        private System.Windows.Forms.Button btnClearEnc;
        private System.Windows.Forms.Button btnClearDec;
        private System.Windows.Forms.ComboBox txtState;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSecondary;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrimary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClipboard;
        private System.Windows.Forms.Label lblExtraClipboard;
        private System.Windows.Forms.PictureBox picCopyTwo;
        private System.Windows.Forms.PictureBox picCopyOne;
        private System.Windows.Forms.TextBox txtXMLString;
        private System.Windows.Forms.Label lblProfileString;
        private System.Windows.Forms.Label lblEncryptedProfileString;
        private System.Windows.Forms.TextBox txtEncString;
        private System.Windows.Forms.Label lblApiSelector;
        private System.Windows.Forms.ComboBox cmbAPISelector;
        private System.Windows.Forms.Button btnSwitchAPI;
        private System.Windows.Forms.Button btnGetProfile;
        private System.ComponentModel.BackgroundWorker bgWrkGetProfile;
        private System.Windows.Forms.BindingSource profileResponseBindingSource;
        private System.Windows.Forms.Button btnApiDocs;
        private System.Windows.Forms.Button btnProfileSearch;
        private System.Windows.Forms.Button btnLoadProfiles;
        private System.Windows.Forms.DateTimePicker dateTimeProfiles;
        private System.Windows.Forms.Label lblProfileCreatedAfter;
        private System.Windows.Forms.DataGridView dgProfileResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.TextBox txtProfileResult;
        private System.Windows.Forms.TextBox txtEncProfileResult;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grpProfileBrowser;
        private System.Windows.Forms.GroupBox grpSearchAPI;
        private System.Windows.Forms.GroupBox grpAPIDocs;
        private System.Windows.Forms.WebBrowser docBrowser;
        private System.Windows.Forms.ComboBox cmbUrlSelector;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchFields;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgSearchResults;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtpSearchStart;
        private System.Windows.Forms.Label lblUsingApi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtEncResponse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblResponseString;
        private System.Windows.Forms.TextBox txtDecResponse;
        private System.Windows.Forms.Label lblTotalResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExternalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;

    }
}