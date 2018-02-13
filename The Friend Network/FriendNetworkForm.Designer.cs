namespace The_Friend_Network
{
    partial class FriendNetworkForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpFriendInfo = new System.Windows.Forms.GroupBox();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblFriendList = new System.Windows.Forms.Label();
            this.lstFriendList = new System.Windows.Forms.ListBox();
            this.chkInterest = new System.Windows.Forms.CheckedListBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.btnNewFriend = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpConnectionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpFriendInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.grpConnectionInfo.Location = new System.Drawing.Point(12, 12);
            this.grpConnectionInfo.Name = "grpConnectionInfo";
            this.grpConnectionInfo.Size = new System.Drawing.Size(465, 181);
            this.grpConnectionInfo.TabIndex = 0;
            this.grpConnectionInfo.TabStop = false;
            this.grpConnectionInfo.Text = "Connection Information";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConnection.Location = new System.Drawing.Point(319, 143);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(114, 28);
            this.btnTestConnection.TabIndex = 9;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtEpicorPassword
            // 
            this.txtEpicorPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpicorPassword.Location = new System.Drawing.Point(128, 104);
            this.txtEpicorPassword.Name = "txtEpicorPassword";
            this.txtEpicorPassword.PasswordChar = '*';
            this.txtEpicorPassword.Size = new System.Drawing.Size(305, 20);
            this.txtEpicorPassword.TabIndex = 8;
            this.txtEpicorPassword.Text = "manager";
            // 
            // txtEpicorUsr
            // 
            this.txtEpicorUsr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpicorUsr.Location = new System.Drawing.Point(128, 81);
            this.txtEpicorUsr.Name = "txtEpicorUsr";
            this.txtEpicorUsr.Size = new System.Drawing.Size(305, 20);
            this.txtEpicorUsr.TabIndex = 7;
            this.txtEpicorUsr.Text = "manager";
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplicationName.Location = new System.Drawing.Point(128, 47);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(305, 20);
            this.txtApplicationName.TabIndex = 6;
            this.txtApplicationName.Text = "TestREST-11111-10.2.100.7";
            // 
            // txtApplicationServer
            // 
            this.txtApplicationServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplicationServer.Location = new System.Drawing.Point(128, 25);
            this.txtApplicationServer.Name = "txtApplicationServer";
            this.txtApplicationServer.Size = new System.Drawing.Size(305, 20);
            this.txtApplicationServer.TabIndex = 5;
            this.txtApplicationServer.Text = "MX0217-PC03SP46";
            // 
            // grpLine
            // 
            this.grpLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLine.Location = new System.Drawing.Point(14, 67);
            this.grpLine.Name = "grpLine";
            this.grpLine.Size = new System.Drawing.Size(437, 10);
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.ImageLocation = "EpicorImg.png";
            this.picLogo.Location = new System.Drawing.Point(503, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(206, 181);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // grpFriendInfo
            // 
            this.grpFriendInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFriendInfo.Controls.Add(this.btnRefreshList);
            this.grpFriendInfo.Controls.Add(this.lblFriendList);
            this.grpFriendInfo.Controls.Add(this.lstFriendList);
            this.grpFriendInfo.Controls.Add(this.chkInterest);
            this.grpFriendInfo.Controls.Add(this.lblInterest);
            this.grpFriendInfo.Controls.Add(this.btnNewFriend);
            this.grpFriendInfo.Controls.Add(this.btnUpdateInfo);
            this.grpFriendInfo.Controls.Add(this.btnRemove);
            this.grpFriendInfo.Controls.Add(this.lblCustID);
            this.grpFriendInfo.Controls.Add(this.lblCountry);
            this.grpFriendInfo.Controls.Add(this.lblCity);
            this.grpFriendInfo.Controls.Add(this.txtCountry);
            this.grpFriendInfo.Controls.Add(this.txtCity);
            this.grpFriendInfo.Controls.Add(this.txtName);
            this.grpFriendInfo.Controls.Add(this.txtCustID);
            this.grpFriendInfo.Controls.Add(this.lblName);
            this.grpFriendInfo.Enabled = false;
            this.grpFriendInfo.Location = new System.Drawing.Point(12, 199);
            this.grpFriendInfo.Name = "grpFriendInfo";
            this.grpFriendInfo.Size = new System.Drawing.Size(697, 318);
            this.grpFriendInfo.TabIndex = 6;
            this.grpFriendInfo.TabStop = false;
            this.grpFriendInfo.Text = "Friend Information";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.Location = new System.Drawing.Point(491, 281);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(200, 28);
            this.btnRefreshList.TabIndex = 26;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // lblFriendList
            // 
            this.lblFriendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFriendList.AutoSize = true;
            this.lblFriendList.Location = new System.Drawing.Point(480, 1);
            this.lblFriendList.Name = "lblFriendList";
            this.lblFriendList.Size = new System.Drawing.Size(58, 13);
            this.lblFriendList.TabIndex = 25;
            this.lblFriendList.Text = "Friend List:";
            // 
            // lstFriendList
            // 
            this.lstFriendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFriendList.FormattingEnabled = true;
            this.lstFriendList.Location = new System.Drawing.Point(491, 19);
            this.lstFriendList.Name = "lstFriendList";
            this.lstFriendList.Size = new System.Drawing.Size(200, 238);
            this.lstFriendList.TabIndex = 24;
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
            this.chkInterest.Location = new System.Drawing.Point(128, 145);
            this.chkInterest.Name = "chkInterest";
            this.chkInterest.ScrollAlwaysVisible = true;
            this.chkInterest.Size = new System.Drawing.Size(337, 109);
            this.chkInterest.TabIndex = 23;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(77, 168);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(45, 13);
            this.lblInterest.TabIndex = 22;
            this.lblInterest.Text = "Interest:";
            // 
            // btnNewFriend
            // 
            this.btnNewFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewFriend.Location = new System.Drawing.Point(111, 281);
            this.btnNewFriend.Name = "btnNewFriend";
            this.btnNewFriend.Size = new System.Drawing.Size(114, 28);
            this.btnNewFriend.TabIndex = 20;
            this.btnNewFriend.Text = "New Friend";
            this.btnNewFriend.UseVisualStyleBackColor = true;
            this.btnNewFriend.Click += new System.EventHandler(this.btnNewFriend_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateInfo.Enabled = false;
            this.btnUpdateInfo.Location = new System.Drawing.Point(231, 281);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(114, 28);
            this.btnUpdateInfo.TabIndex = 19;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(351, 281);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 28);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(101, 44);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(21, 13);
            this.lblCustID.TabIndex = 17;
            this.lblCustID.Text = "ID:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(76, 122);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Country:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(95, 100);
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
            this.txtCountry.Location = new System.Drawing.Point(128, 119);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(337, 20);
            this.txtCountry.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(128, 93);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(337, 20);
            this.txtCity.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(128, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(337, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtCustID
            // 
            this.txtCustID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustID.Enabled = false;
            this.txtCustID.Location = new System.Drawing.Point(128, 41);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(337, 20);
            this.txtCustID.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(76, 17);
            this.statusLbl.Text = "Last Request:";
            // 
            // FriendNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpFriendInfo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpConnectionInfo);
            this.Name = "FriendNetworkForm";
            this.ShowIcon = false;
            this.Text = "The Friend Network";
            this.grpConnectionInfo.ResumeLayout(false);
            this.grpConnectionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpFriendInfo.ResumeLayout(false);
            this.grpFriendInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpFriendInfo;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnNewFriend;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.CheckedListBox chkInterest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblFriendList;
        private System.Windows.Forms.ListBox lstFriendList;
    }
}

