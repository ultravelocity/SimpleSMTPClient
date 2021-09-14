using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace SimpleSmtpClient {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        private void guiUseCredentials_CheckedChanged(object sender, EventArgs e) {
            guiUser.ReadOnly = true;
            guiPassword.ReadOnly = true;
            if (guiUseCredentials.Checked) {
                guiUser.ReadOnly = false;
                guiPassword.ReadOnly = false;
            }
        }

        private void guiSendMail_Click(object sender, EventArgs e) {
            try {
                using (var client = new SmtpClient(new TextBoxLogger(guiDebug))) {
                    client.Connect(guiServerName.Text, Convert.ToInt32(guiPort.Text), guiUseSsl.Checked);
                    if (guiUseCredentials.Checked) {
                        client.Authenticate(guiUser.Text, guiPassword.Text);
                    }

                    var message = CreateMailMessage();
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                log(ex.ToString());
            }
        }

        private void log(string msg) {
            guiDebug.AppendText(msg + Environment.NewLine);
        }

        private MimeMessage CreateMailMessage() {
            var mailMessage = new MimeMessage();
            mailMessage.To.Add(new MailboxAddress(string.Empty, guiEmailTo.Text));
            mailMessage.Subject = guiEmailSubject.Text;
            mailMessage.Body = new TextPart("plain") {Text = guiEmailBody.Text + getDebugInfo()};
            mailMessage.From.Add(new MailboxAddress(string.Empty, guiEmailFrom.Text));
            if (!string.IsNullOrWhiteSpace(guiEmailSender.Text))
                mailMessage.Sender = new MailboxAddress(string.Empty, guiEmailReplyTo.Text);
            if (!string.IsNullOrWhiteSpace(guiEmailReplyTo.Text))
                mailMessage.ReplyTo.Add(new MailboxAddress(string.Empty, guiEmailReplyTo.Text));
            mailMessage.To.Add(new MailboxAddress(string.Empty, guiEmailTo.Text));
            return mailMessage;
        }

        private string getDebugInfo() {
            if (!chkIncludeDebug.Checked)
                return string.Empty;
            var debugInfo = Environment.NewLine;
            debugInfo += Environment.NewLine;
            debugInfo += "---[ Details ]---" + Environment.NewLine;
            debugInfo += "Server: " + guiServerName.Text + Environment.NewLine;
            debugInfo += "Port: " + guiPort.Text + Environment.NewLine;
            debugInfo += "SSL: " + guiUseSsl.Checked + Environment.NewLine;
            debugInfo += "Auth: " + guiUseCredentials.Checked + Environment.NewLine;
            debugInfo += "From: " + guiEmailFrom.Text + Environment.NewLine;
            debugInfo += "Sender: " + guiEmailSender.Text + Environment.NewLine;
            debugInfo += "To: " + guiEmailTo.Text + Environment.NewLine;
            debugInfo += "Reply-To: " + guiEmailReplyTo.Text + Environment.NewLine;
            debugInfo += "Sent: " + DateTime.Now + Environment.NewLine;
            debugInfo += Environment.NewLine;
            return debugInfo;
        }

        private void btnClearLog_Click(object sender, EventArgs e) {
            guiDebug.Clear();
        }

    }
}