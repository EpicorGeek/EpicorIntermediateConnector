namespace StrategicCustomerManagement
{
    partial class StrategicCustomerForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.connectionPage = new System.Windows.Forms.TabPage();
            this.grpConnectionInfo = new System.Windows.Forms.GroupBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtEpicorPassword = new System.Windows.Forms.TextBox();
            this.txtEpicorUsr = new System.Windows.Forms.TextBox();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.txtApplicationServer = new System.Windows.Forms.TextBox();
            this.grpLine = new System.Windows.Forms.GroupBox();
            this.lblEpicorPsw = new System.Windows.Forms.Label();
            this.lblEpicorUsr = new System.Windows.Forms.Label();
            this.lblEpicorApplication = new System.Windows.Forms.Label();
            this.lblEpicorServer = new System.Windows.Forms.Label();
            this.actionPage = new System.Windows.Forms.TabPage();
            this.allCustomersList = new System.Windows.Forms.ListBox();
            this.customerList = new System.Windows.Forms.Label();
            this.lblFriendList = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.strategicList = new System.Windows.Forms.ListBox();
            this.grpStrategicCustomerInfo = new System.Windows.Forms.GroupBox();
            this.grpStrategic = new System.Windows.Forms.GroupBox();
            this.lblStrategic = new System.Windows.Forms.Label();
            this.chkIsStrategicCustomer = new System.Windows.Forms.CheckBox();
            this.lblStrategicDescription = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.chkInterest = new System.Windows.Forms.CheckedListBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnCustomerAction = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnCommitChanges = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.connectionPage.SuspendLayout();
            this.grpConnectionInfo.SuspendLayout();
            this.actionPage.SuspendLayout();
            this.grpStrategicCustomerInfo.SuspendLayout();
            this.grpStrategic.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(76, 17);
            this.statusLbl.Text = "Last Request:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.connectionPage);
            this.tabControl1.Controls.Add(this.actionPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 530);
            this.tabControl1.TabIndex = 15;
            // 
            // connectionPage
            // 
            this.connectionPage.Controls.Add(this.grpConnectionInfo);
            this.connectionPage.Location = new System.Drawing.Point(4, 22);
            this.connectionPage.Name = "connectionPage";
            this.connectionPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionPage.Size = new System.Drawing.Size(701, 504);
            this.connectionPage.TabIndex = 0;
            this.connectionPage.Text = "Connection";
            this.connectionPage.UseVisualStyleBackColor = true;
            // 
            // grpConnectionInfo
            // 
            this.grpConnectionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConnectionInfo.Controls.Add(this.btnTestConnection);
            this.grpConnectionInfo.Controls.Add(this.txtEpicorPassword);
            this.grpConnectionInfo.Controls.Add(this.txtEpicorUsr);
            this.grpConnectionInfo.Controls.Add(this.txtApplicationName);
            this.grpConnectionInfo.Controls.Add(this.txtApplicationServer);
            this.grpConnectionInfo.Controls.Add(this.grpLine);
            this.grpConnectionInfo.Controls.Add(this.lblEpicorPsw);
            this.grpConnectionInfo.Controls.Add(this.lblEpicorUsr);
            this.grpConnectionInfo.Controls.Add(this.lblEpicorApplication);
            this.grpConnectionInfo.Controls.Add(this.lblEpicorServer);
            this.grpConnectionInfo.Location = new System.Drawing.Point(18, 22);
            this.grpConnectionInfo.Name = "grpConnectionInfo";
            this.grpConnectionInfo.Size = new System.Drawing.Size(664, 229);
            this.grpConnectionInfo.TabIndex = 2;
            this.grpConnectionInfo.TabStop = false;
            this.grpConnectionInfo.Text = "Epicor Connection Information";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConnection.Location = new System.Drawing.Point(518, 143);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(114, 28);
            this.btnTestConnection.TabIndex = 9;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            // 
            // txtEpicorPassword
            // 
            this.txtEpicorPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpicorPassword.Location = new System.Drawing.Point(128, 104);
            this.txtEpicorPassword.Name = "txtEpicorPassword";
            this.txtEpicorPassword.PasswordChar = '*';
            this.txtEpicorPassword.Size = new System.Drawing.Size(504, 20);
            this.txtEpicorPassword.TabIndex = 8;
            // 
            // txtEpicorUsr
            // 
            this.txtEpicorUsr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpicorUsr.Location = new System.Drawing.Point(128, 81);
            this.txtEpicorUsr.Name = "txtEpicorUsr";
            this.txtEpicorUsr.Size = new System.Drawing.Size(504, 20);
            this.txtEpicorUsr.TabIndex = 7;
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplicationName.Location = new System.Drawing.Point(128, 47);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(504, 20);
            this.txtApplicationName.TabIndex = 6;
            // 
            // txtApplicationServer
            // 
            this.txtApplicationServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplicationServer.Location = new System.Drawing.Point(128, 25);
            this.txtApplicationServer.Name = "txtApplicationServer";
            this.txtApplicationServer.Size = new System.Drawing.Size(504, 20);
            this.txtApplicationServer.TabIndex = 5;
            // 
            // grpLine
            // 
            this.grpLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLine.Location = new System.Drawing.Point(14, 67);
            this.grpLine.Name = "grpLine";
            this.grpLine.Size = new System.Drawing.Size(636, 10);
            this.grpLine.TabIndex = 4;
            this.grpLine.TabStop = false;
            // 
            // lblEpicorPsw
            // 
            this.lblEpicorPsw.AutoSize = true;
            this.lblEpicorPsw.Location = new System.Drawing.Point(33, 107);
            this.lblEpicorPsw.Name = "lblEpicorPsw";
            this.lblEpicorPsw.Size = new System.Drawing.Size(89, 13);
            this.lblEpicorPsw.TabIndex = 3;
            this.lblEpicorPsw.Text = "Epicor Password:";
            // 
            // lblEpicorUsr
            // 
            this.lblEpicorUsr.AutoSize = true;
            this.lblEpicorUsr.Location = new System.Drawing.Point(57, 84);
            this.lblEpicorUsr.Name = "lblEpicorUsr";
            this.lblEpicorUsr.Size = new System.Drawing.Size(65, 13);
            this.lblEpicorUsr.TabIndex = 2;
            this.lblEpicorUsr.Text = "Epicor User:";
            // 
            // lblEpicorApplication
            // 
            this.lblEpicorApplication.AutoSize = true;
            this.lblEpicorApplication.Location = new System.Drawing.Point(29, 50);
            this.lblEpicorApplication.Name = "lblEpicorApplication";
            this.lblEpicorApplication.Size = new System.Drawing.Size(93, 13);
            this.lblEpicorApplication.TabIndex = 1;
            this.lblEpicorApplication.Text = "Application Name:";
            // 
            // lblEpicorServer
            // 
            this.lblEpicorServer.AutoSize = true;
            this.lblEpicorServer.Location = new System.Drawing.Point(26, 28);
            this.lblEpicorServer.Name = "lblEpicorServer";
            this.lblEpicorServer.Size = new System.Drawing.Size(96, 13);
            this.lblEpicorServer.TabIndex = 0;
            this.lblEpicorServer.Text = "Application Server:";
            // 
            // actionPage
            // 
            this.actionPage.Controls.Add(this.allCustomersList);
            this.actionPage.Controls.Add(this.customerList);
            this.actionPage.Controls.Add(this.lblFriendList);
            this.actionPage.Controls.Add(this.btnRefreshList);
            this.actionPage.Controls.Add(this.strategicList);
            this.actionPage.Controls.Add(this.grpStrategicCustomerInfo);
            this.actionPage.Location = new System.Drawing.Point(4, 22);
            this.actionPage.Name = "actionPage";
            this.actionPage.Padding = new System.Windows.Forms.Padding(3);
            this.actionPage.Size = new System.Drawing.Size(701, 504);
            this.actionPage.TabIndex = 1;
            this.actionPage.Text = "Strategic Management";
            this.actionPage.UseVisualStyleBackColor = true;
            // 
            // allCustomersList
            // 
            this.allCustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allCustomersList.FormattingEnabled = true;
            this.allCustomersList.Location = new System.Drawing.Point(538, 257);
            this.allCustomersList.Name = "allCustomersList";
            this.allCustomersList.Size = new System.Drawing.Size(144, 173);
            this.allCustomersList.TabIndex = 30;
            // 
            // customerList
            // 
            this.customerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerList.AutoSize = true;
            this.customerList.Location = new System.Drawing.Point(535, 240);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(73, 13);
            this.customerList.TabIndex = 29;
            this.customerList.Text = "Customer List:";
            // 
            // lblFriendList
            // 
            this.lblFriendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFriendList.AutoSize = true;
            this.lblFriendList.Location = new System.Drawing.Point(535, 19);
            this.lblFriendList.Name = "lblFriendList";
            this.lblFriendList.Size = new System.Drawing.Size(104, 13);
            this.lblFriendList.TabIndex = 28;
            this.lblFriendList.Text = "Strategic Customers:";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.Image = global::StrategicCustomerManagement.Properties.Resources.refreshImg;
            this.btnRefreshList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshList.Location = new System.Drawing.Point(538, 436);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(144, 28);
            this.btnRefreshList.TabIndex = 27;
            this.btnRefreshList.Text = "Refresh Lists";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            // 
            // strategicList
            // 
            this.strategicList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.strategicList.FormattingEnabled = true;
            this.strategicList.Location = new System.Drawing.Point(538, 40);
            this.strategicList.Name = "strategicList";
            this.strategicList.Size = new System.Drawing.Size(144, 173);
            this.strategicList.TabIndex = 25;
            // 
            // grpStrategicCustomerInfo
            // 
            this.grpStrategicCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStrategicCustomerInfo.Controls.Add(this.grpStrategic);
            this.grpStrategicCustomerInfo.Controls.Add(this.lblInterest);
            this.grpStrategicCustomerInfo.Controls.Add(this.chkInterest);
            this.grpStrategicCustomerInfo.Controls.Add(this.lblCustID);
            this.grpStrategicCustomerInfo.Controls.Add(this.lblCountry);
            this.grpStrategicCustomerInfo.Controls.Add(this.lblCity);
            this.grpStrategicCustomerInfo.Controls.Add(this.txtCountry);
            this.grpStrategicCustomerInfo.Controls.Add(this.btnCustomerAction);
            this.grpStrategicCustomerInfo.Controls.Add(this.txtCity);
            this.grpStrategicCustomerInfo.Controls.Add(this.btnCommitChanges);
            this.grpStrategicCustomerInfo.Controls.Add(this.btnRemove);
            this.grpStrategicCustomerInfo.Controls.Add(this.txtName);
            this.grpStrategicCustomerInfo.Controls.Add(this.txtCustID);
            this.grpStrategicCustomerInfo.Controls.Add(this.lblName);
            this.grpStrategicCustomerInfo.Location = new System.Drawing.Point(17, 19);
            this.grpStrategicCustomerInfo.Name = "grpStrategicCustomerInfo";
            this.grpStrategicCustomerInfo.Size = new System.Drawing.Size(512, 464);
            this.grpStrategicCustomerInfo.TabIndex = 8;
            this.grpStrategicCustomerInfo.TabStop = false;
            this.grpStrategicCustomerInfo.Text = "Customer Information";
            // 
            // grpStrategic
            // 
            this.grpStrategic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStrategic.Controls.Add(this.lblStrategic);
            this.grpStrategic.Controls.Add(this.chkIsStrategicCustomer);
            this.grpStrategic.Controls.Add(this.lblStrategicDescription);
            this.grpStrategic.Location = new System.Drawing.Point(6, 240);
            this.grpStrategic.Name = "grpStrategic";
            this.grpStrategic.Size = new System.Drawing.Size(486, 43);
            this.grpStrategic.TabIndex = 31;
            this.grpStrategic.TabStop = false;
            // 
            // lblStrategic
            // 
            this.lblStrategic.AutoSize = true;
            this.lblStrategic.Location = new System.Drawing.Point(41, 16);
            this.lblStrategic.Name = "lblStrategic";
            this.lblStrategic.Size = new System.Drawing.Size(99, 13);
            this.lblStrategic.TabIndex = 33;
            this.lblStrategic.Text = "Strategic Customer:";
            // 
            // chkIsStrategicCustomer
            // 
            this.chkIsStrategicCustomer.AutoSize = true;
            this.chkIsStrategicCustomer.Location = new System.Drawing.Point(146, 16);
            this.chkIsStrategicCustomer.Name = "chkIsStrategicCustomer";
            this.chkIsStrategicCustomer.Size = new System.Drawing.Size(15, 14);
            this.chkIsStrategicCustomer.TabIndex = 32;
            this.chkIsStrategicCustomer.UseVisualStyleBackColor = true;
            // 
            // lblStrategicDescription
            // 
            this.lblStrategicDescription.AutoSize = true;
            this.lblStrategicDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrategicDescription.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStrategicDescription.Location = new System.Drawing.Point(167, 17);
            this.lblStrategicDescription.Name = "lblStrategicDescription";
            this.lblStrategicDescription.Size = new System.Drawing.Size(250, 13);
            this.lblStrategicDescription.TabIndex = 31;
            this.lblStrategicDescription.Text = "Is current customer strategic or key for my company?";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(101, 125);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(45, 13);
            this.lblInterest.TabIndex = 26;
            this.lblInterest.Text = "Interest:";
            // 
            // chkInterest
            // 
            this.chkInterest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInterest.CheckOnClick = true;
            this.chkInterest.Enabled = false;
            this.chkInterest.FormattingEnabled = true;
            this.chkInterest.Items.AddRange(new object[] {
            "Sports",
            "Gaming",
            "Work",
            "Computing",
            "Romantic"});
            this.chkInterest.Location = new System.Drawing.Point(152, 125);
            this.chkInterest.Name = "chkInterest";
            this.chkInterest.ScrollAlwaysVisible = true;
            this.chkInterest.Size = new System.Drawing.Size(340, 109);
            this.chkInterest.TabIndex = 27;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(125, 24);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(21, 13);
            this.lblCustID.TabIndex = 17;
            this.lblCustID.Text = "ID:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(100, 102);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Country:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(119, 76);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City:";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.Enabled = false;
            this.txtCountry.Location = new System.Drawing.Point(152, 99);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(340, 20);
            this.txtCountry.TabIndex = 12;
            // 
            // btnCustomerAction
            // 
            this.btnCustomerAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerAction.Image = global::StrategicCustomerManagement.Properties.Resources.newImg;
            this.btnCustomerAction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerAction.Location = new System.Drawing.Point(48, 417);
            this.btnCustomerAction.Name = "btnCustomerAction";
            this.btnCustomerAction.Size = new System.Drawing.Size(144, 28);
            this.btnCustomerAction.TabIndex = 20;
            this.btnCustomerAction.Text = "Create Customer";
            this.btnCustomerAction.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(152, 73);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(340, 20);
            this.txtCity.TabIndex = 11;
            // 
            // btnCommitChanges
            // 
            this.btnCommitChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommitChanges.Enabled = false;
            this.btnCommitChanges.Image = global::StrategicCustomerManagement.Properties.Resources.saveImg;
            this.btnCommitChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommitChanges.Location = new System.Drawing.Point(198, 417);
            this.btnCommitChanges.Name = "btnCommitChanges";
            this.btnCommitChanges.Size = new System.Drawing.Size(144, 28);
            this.btnCommitChanges.TabIndex = 19;
            this.btnCommitChanges.Text = "Commit Changes";
            this.btnCommitChanges.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Image = global::StrategicCustomerManagement.Properties.Resources.deleteImg;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(348, 417);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 28);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(152, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtCustID
            // 
            this.txtCustID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustID.Enabled = false;
            this.txtCustID.Location = new System.Drawing.Point(152, 21);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(340, 20);
            this.txtCustID.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(108, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // StrategicCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "StrategicCustomerForm";
            this.ShowIcon = false;
            this.Text = "Strategic Customer Management";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.connectionPage.ResumeLayout(false);
            this.grpConnectionInfo.ResumeLayout(false);
            this.grpConnectionInfo.PerformLayout();
            this.actionPage.ResumeLayout(false);
            this.actionPage.PerformLayout();
            this.grpStrategicCustomerInfo.ResumeLayout(false);
            this.grpStrategicCustomerInfo.PerformLayout();
            this.grpStrategic.ResumeLayout(false);
            this.grpStrategic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage connectionPage;
        private System.Windows.Forms.GroupBox grpConnectionInfo;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TextBox txtEpicorPassword;
        private System.Windows.Forms.TextBox txtEpicorUsr;
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.TextBox txtApplicationServer;
        private System.Windows.Forms.GroupBox grpLine;
        private System.Windows.Forms.Label lblEpicorPsw;
        private System.Windows.Forms.Label lblEpicorUsr;
        private System.Windows.Forms.Label lblEpicorApplication;
        private System.Windows.Forms.Label lblEpicorServer;
        private System.Windows.Forms.TabPage actionPage;
        private System.Windows.Forms.ListBox allCustomersList;
        private System.Windows.Forms.Label customerList;
        private System.Windows.Forms.Label lblFriendList;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.ListBox strategicList;
        private System.Windows.Forms.GroupBox grpStrategicCustomerInfo;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.CheckedListBox chkInterest;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnCustomerAction;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnCommitChanges;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpStrategic;
        private System.Windows.Forms.Label lblStrategic;
        private System.Windows.Forms.CheckBox chkIsStrategicCustomer;
        private System.Windows.Forms.Label lblStrategicDescription;
    }
}

