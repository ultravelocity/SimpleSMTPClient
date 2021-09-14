namespace SimpleSmtpClient
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.serverGroup = new System.Windows.Forms.GroupBox();
            this.guiUseSsl = new System.Windows.Forms.CheckBox();
            this.guiPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.guiUser = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guiUseCredentials = new System.Windows.Forms.CheckBox();
            this.guiPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.guiServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.emailGroup = new System.Windows.Forms.GroupBox();
            this.chkIncludeDebug = new System.Windows.Forms.CheckBox();
            this.guiEmailReplyTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guiEmailSender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guiEmailBody = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.guiEmailSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.guiEmailTo = new System.Windows.Forms.TextBox();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.guiEmailFrom = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.guiSendMail = new System.Windows.Forms.Button();
            this.guiDebug = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serverGroup.SuspendLayout();
            this.emailGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverGroup
            // 
            this.serverGroup.Controls.Add(this.guiUseSsl);
            this.serverGroup.Controls.Add(this.guiPassword);
            this.serverGroup.Controls.Add(this.lblPassword);
            this.serverGroup.Controls.Add(this.guiUser);
            this.serverGroup.Controls.Add(this.lblUserName);
            this.serverGroup.Controls.Add(this.guiUseCredentials);
            this.serverGroup.Controls.Add(this.guiPort);
            this.serverGroup.Controls.Add(this.lblPort);
            this.serverGroup.Controls.Add(this.guiServerName);
            this.serverGroup.Controls.Add(this.lblServerName);
            this.serverGroup.Location = new System.Drawing.Point(12, 10);
            this.serverGroup.Name = "serverGroup";
            this.serverGroup.Size = new System.Drawing.Size(495, 98);
            this.serverGroup.TabIndex = 0;
            this.serverGroup.TabStop = false;
            this.serverGroup.Text = "Server";
            // 
            // guiUseSsl
            // 
            this.guiUseSsl.AutoSize = true;
            this.guiUseSsl.Checked = true;
            this.guiUseSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.guiUseSsl.Location = new System.Drawing.Point(410, 22);
            this.guiUseSsl.Name = "guiUseSsl";
            this.guiUseSsl.Size = new System.Drawing.Size(68, 17);
            this.guiUseSsl.TabIndex = 10;
            this.guiUseSsl.Text = "Use SSL";
            this.guiUseSsl.UseVisualStyleBackColor = true;
            // 
            // guiPassword
            // 
            this.guiPassword.Location = new System.Drawing.Point(332, 58);
            this.guiPassword.Name = "guiPassword";
            this.guiPassword.ReadOnly = true;
            this.guiPassword.Size = new System.Drawing.Size(146, 20);
            this.guiPassword.TabIndex = 25;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(289, 60);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(28, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Pwd";
            // 
            // guiUser
            // 
            this.guiUser.Location = new System.Drawing.Point(132, 58);
            this.guiUser.Name = "guiUser";
            this.guiUser.ReadOnly = true;
            this.guiUser.Size = new System.Drawing.Size(137, 20);
            this.guiUser.TabIndex = 20;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(97, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(29, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User";
            // 
            // guiUseCredentials
            // 
            this.guiUseCredentials.AutoSize = true;
            this.guiUseCredentials.Location = new System.Drawing.Point(25, 60);
            this.guiUseCredentials.Name = "guiUseCredentials";
            this.guiUseCredentials.Size = new System.Drawing.Size(48, 17);
            this.guiUseCredentials.TabIndex = 15;
            this.guiUseCredentials.Text = "Auth";
            this.guiUseCredentials.UseVisualStyleBackColor = true;
            this.guiUseCredentials.CheckedChanged += new System.EventHandler(this.guiUseCredentials_CheckedChanged);
            // 
            // guiPort
            // 
            this.guiPort.Location = new System.Drawing.Point(332, 19);
            this.guiPort.Name = "guiPort";
            this.guiPort.Size = new System.Drawing.Size(50, 20);
            this.guiPort.TabIndex = 5;
            this.guiPort.Text = "587";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(293, 22);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // guiServerName
            // 
            this.guiServerName.Location = new System.Drawing.Point(96, 19);
            this.guiServerName.Name = "guiServerName";
            this.guiServerName.Size = new System.Drawing.Size(174, 20);
            this.guiServerName.TabIndex = 1;
            this.guiServerName.Text = "smtp-relay.gmail.com";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(22, 22);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(71, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "SMTP Server";
            // 
            // emailGroup
            // 
            this.emailGroup.Controls.Add(this.chkIncludeDebug);
            this.emailGroup.Controls.Add(this.guiEmailReplyTo);
            this.emailGroup.Controls.Add(this.label2);
            this.emailGroup.Controls.Add(this.guiEmailSender);
            this.emailGroup.Controls.Add(this.label1);
            this.emailGroup.Controls.Add(this.guiEmailBody);
            this.emailGroup.Controls.Add(this.lblBody);
            this.emailGroup.Controls.Add(this.guiEmailSubject);
            this.emailGroup.Controls.Add(this.lblSubject);
            this.emailGroup.Controls.Add(this.guiEmailTo);
            this.emailGroup.Controls.Add(this.lblEmailTo);
            this.emailGroup.Controls.Add(this.guiEmailFrom);
            this.emailGroup.Controls.Add(this.lblEmailFrom);
            this.emailGroup.Location = new System.Drawing.Point(12, 116);
            this.emailGroup.Name = "emailGroup";
            this.emailGroup.Size = new System.Drawing.Size(495, 303);
            this.emailGroup.TabIndex = 1;
            this.emailGroup.TabStop = false;
            this.emailGroup.Text = "Message";
            // 
            // chkIncludeDebug
            // 
            this.chkIncludeDebug.AutoSize = true;
            this.chkIncludeDebug.Checked = true;
            this.chkIncludeDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeDebug.Location = new System.Drawing.Point(75, 266);
            this.chkIncludeDebug.Name = "chkIncludeDebug";
            this.chkIncludeDebug.Size = new System.Drawing.Size(151, 17);
            this.chkIncludeDebug.TabIndex = 91;
            this.chkIncludeDebug.Text = "Include debug info in body";
            this.chkIncludeDebug.UseVisualStyleBackColor = true;
            // 
            // guiEmailReplyTo
            // 
            this.guiEmailReplyTo.Location = new System.Drawing.Point(332, 60);
            this.guiEmailReplyTo.Name = "guiEmailReplyTo";
            this.guiEmailReplyTo.Size = new System.Drawing.Size(146, 20);
            this.guiEmailReplyTo.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reply To";
            // 
            // guiEmailSender
            // 
            this.guiEmailSender.Location = new System.Drawing.Point(332, 18);
            this.guiEmailSender.Name = "guiEmailSender";
            this.guiEmailSender.Size = new System.Drawing.Size(146, 20);
            this.guiEmailSender.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sender";
            // 
            // guiEmailBody
            // 
            this.guiEmailBody.Location = new System.Drawing.Point(75, 146);
            this.guiEmailBody.Multiline = true;
            this.guiEmailBody.Name = "guiEmailBody";
            this.guiEmailBody.Size = new System.Drawing.Size(403, 101);
            this.guiEmailBody.TabIndex = 60;
            this.guiEmailBody.Text = "This is a test message. Please ignore.";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(21, 147);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Body";
            // 
            // guiEmailSubject
            // 
            this.guiEmailSubject.Location = new System.Drawing.Point(75, 101);
            this.guiEmailSubject.Name = "guiEmailSubject";
            this.guiEmailSubject.Size = new System.Drawing.Size(403, 20);
            this.guiEmailSubject.TabIndex = 50;
            this.guiEmailSubject.Text = "[TEST] This is an SMTP test message";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(21, 104);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            // 
            // guiEmailTo
            // 
            this.guiEmailTo.Location = new System.Drawing.Point(76, 60);
            this.guiEmailTo.Name = "guiEmailTo";
            this.guiEmailTo.Size = new System.Drawing.Size(194, 20);
            this.guiEmailTo.TabIndex = 40;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(22, 63);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(20, 13);
            this.lblEmailTo.TabIndex = 3;
            this.lblEmailTo.Text = "To";
            // 
            // guiEmailFrom
            // 
            this.guiEmailFrom.Location = new System.Drawing.Point(76, 19);
            this.guiEmailFrom.Name = "guiEmailFrom";
            this.guiEmailFrom.Size = new System.Drawing.Size(194, 20);
            this.guiEmailFrom.TabIndex = 30;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(22, 21);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(30, 13);
            this.lblEmailFrom.TabIndex = 1;
            this.lblEmailFrom.Text = "From";
            // 
            // guiSendMail
            // 
            this.guiSendMail.Location = new System.Drawing.Point(429, 374);
            this.guiSendMail.Name = "guiSendMail";
            this.guiSendMail.Size = new System.Drawing.Size(61, 31);
            this.guiSendMail.TabIndex = 70;
            this.guiSendMail.Text = "Send";
            this.guiSendMail.UseVisualStyleBackColor = true;
            this.guiSendMail.Click += new System.EventHandler(this.guiSendMail_Click);
            // 
            // guiDebug
            // 
            this.guiDebug.Location = new System.Drawing.Point(21, 26);
            this.guiDebug.Multiline = true;
            this.guiDebug.Name = "guiDebug";
            this.guiDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.guiDebug.Size = new System.Drawing.Size(266, 325);
            this.guiDebug.TabIndex = 80;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(216, 362);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(71, 31);
            this.btnClearLog.TabIndex = 90;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guiDebug);
            this.groupBox1.Controls.Add(this.btnClearLog);
            this.groupBox1.Location = new System.Drawing.Point(520, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 407);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guiSendMail);
            this.Controls.Add(this.emailGroup);
            this.Controls.Add(this.serverGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Simple SMTP Client";
            this.serverGroup.ResumeLayout(false);
            this.serverGroup.PerformLayout();
            this.emailGroup.ResumeLayout(false);
            this.emailGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox serverGroup;
        private System.Windows.Forms.TextBox guiPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox guiUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox guiUseCredentials;
        private System.Windows.Forms.TextBox guiPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox guiServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.GroupBox emailGroup;
        private System.Windows.Forms.TextBox guiEmailBody;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox guiEmailSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox guiEmailTo;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.TextBox guiEmailFrom;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.Button guiSendMail;
        private System.Windows.Forms.CheckBox guiUseSsl;
        private System.Windows.Forms.TextBox guiEmailSender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guiDebug;
        private System.Windows.Forms.TextBox guiEmailReplyTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIncludeDebug;
    }
}

