using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class fMail : Form
    {
        const string IMAP_SERVER = "imap.gmail.com";
        const int IMAP_PORT = 993;
        const string USERNAME = "your.email@gmail.com";
        const string APP_PASSWORD = "your_app_password";

        public fMail()
        {
            InitializeComponent();
        }

        private void fMail_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                LoadMails();
            });
        }

        private void LoadMails()
        {
            dgvMails.Rows.Clear();

            using (var client = new ImapClient())
            {
                try
                {
                    // Connect to the IMAP server
                    client.Connect(IMAP_SERVER, IMAP_PORT, true);

                    // Authenticate
                    client.Authenticate(USERNAME, APP_PASSWORD);

                    // Select the inbox
                    client.Inbox.Open(FolderAccess.ReadOnly);

                    // Search for all unseen messages
                    var results = client.Inbox.Search(SearchQuery.NotSeen);

                    foreach (var uniqueId in results)
                    {
                        var message = client.Inbox.GetMessage(uniqueId);
                        dgvMails.Rows.Add(message.From, message.Subject);
                    }

                    // Disconnect
                    client.Disconnect(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue : {ex.Message}");
                }
            }

            lbLastRefresh.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMails();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (var f = new fSendEmail())
            {
                f.ShowDialog();
            }
        }
    }
}
