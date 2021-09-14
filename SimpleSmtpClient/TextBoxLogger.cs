using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MailKit;

namespace SimpleSmtpClient {
    public class TextBoxLogger : IProtocolLogger {
        private readonly TextBox txtBox;

        public TextBoxLogger(TextBox txt) {
            txtBox = txt;
        }

        public IAuthenticationSecretDetector AuthenticationSecretDetector { get; set; }

        public void Dispose() {
            GC.SuppressFinalize(this);
        }

        public void LogConnect(Uri uri) {
            log($"Connect {uri}");
        }

        public void LogClient(byte[] buffer, int offset, int count) {
            logBuffer(true, buffer, offset, count);
        }

        public void LogServer(byte[] buffer, int offset, int count) {
            logBuffer(false, buffer, offset, count);
        }

        private void log(string msg) {
            txtBox.AppendText(msg + Environment.NewLine);
        }

        private void logBuffer(bool isRequest, byte[] buffer, int offset, int count) {
            var logData = buffer.Skip(offset).Take(count).ToArray();
            log($"{(isRequest ? "> " : "")}{Encoding.UTF8.GetString(logData)}");
        }
    }
}