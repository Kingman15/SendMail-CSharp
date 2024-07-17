using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.NetworkInformation;

namespace SendMail
{
    public partial class fSendEmail : Form
    {
        List<string> _fichiersJoint = null;

        public fSendEmail()
        {
            InitializeComponent();

            _fichiersJoint = new List<string>();
        }

        public void SendEmail()
        {
            string destinataire = tbDestinataire.Text.Trim();
            string objet = tbObjet.Text.Trim();
            string message = tbMessage.Text.Trim();

            string fromEmail = "your.email@gmail.com";
            string fromPassword = "your_app_password";

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true
            };

            var mailMessage = new MailMessage()
            {
                From = new MailAddress(fromEmail),
                Subject = objet,
                Body = message,
                IsBodyHtml = true
            };
            mailMessage.To.Add(destinataire);

            try
            {
                var contentType = new ContentType() { MediaType = MediaTypeNames.Application.Octet };

                foreach (string filePath in _fichiersJoint)
                {
                    contentType.Name = System.IO.Path.GetFileName(filePath); ;
                    mailMessage.Attachments.Add(new Attachment(filePath, contentType));
                }

                client.Send(mailMessage);
                MessageBox.Show("Email envoyé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'envoie : {ex.Message}");
            }
        }

        private void bEnvoyer_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()
            {
                Filter = "Fichiers PDF (*.pdf)|*.pdf|Tous les fichiers (*.*)|*.*",
                Title = "Choisir un fichier à joindre"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    string fileName = System.IO.Path.GetFileName(filePath);

                    if (_fichiersJoint.Contains(filePath))
                    {
                        MessageBox.Show("Fichier joint existant !");
                        return;
                    }

                    _fichiersJoint.Add(filePath);

                    dgvFiles.Rows.Add(fileName);
                    dgvFiles.Rows[dgvFiles.Rows.Count - 1].Tag = filePath;
                }
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            tbDestinataire.Clear();
            tbMessage.Clear();
            tbObjet.Clear();

            _fichiersJoint.Clear();
            dgvFiles.Rows.Clear();
        }

        private void dgvFiles_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string filePath = e.Row.Tag.ToString();
            _fichiersJoint.Remove(filePath);
        }
    }
}
