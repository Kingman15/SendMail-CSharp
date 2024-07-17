namespace SendMail
{
    partial class fSendEmail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bEnvoyer = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tbMessage = new Krypton.Toolkit.KryptonTextBox();
            tbObjet = new Krypton.Toolkit.KryptonTextBox();
            tbDestinataire = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            tabPage2 = new TabPage();
            btnAddFile = new Krypton.Toolkit.KryptonButton();
            dgvFiles = new Krypton.Toolkit.KryptonDataGridView();
            colNom = new DataGridViewTextBoxColumn();
            btnInit = new Krypton.Toolkit.KryptonButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFiles).BeginInit();
            SuspendLayout();
            // 
            // bEnvoyer
            // 
            bEnvoyer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bEnvoyer.Location = new Point(438, 291);
            bEnvoyer.Name = "bEnvoyer";
            bEnvoyer.Size = new Size(112, 31);
            bEnvoyer.TabIndex = 0;
            bEnvoyer.Values.Text = "Envoyer";
            bEnvoyer.Click += bEnvoyer_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel1.Location = new Point(12, 12);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(45, 24);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Chat";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 42);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(538, 239);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tbMessage);
            tabPage1.Controls.Add(tbObjet);
            tabPage1.Controls.Add(tbDestinataire);
            tabPage1.Controls.Add(kryptonLabel4);
            tabPage1.Controls.Add(kryptonLabel3);
            tabPage1.Controls.Add(kryptonLabel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(530, 206);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Formulaire";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbMessage
            // 
            tbMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMessage.Location = new Point(119, 78);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(395, 116);
            tbMessage.TabIndex = 25;
            // 
            // tbObjet
            // 
            tbObjet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbObjet.Location = new Point(119, 45);
            tbObjet.Name = "tbObjet";
            tbObjet.Size = new Size(395, 27);
            tbObjet.TabIndex = 24;
            // 
            // tbDestinataire
            // 
            tbDestinataire.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDestinataire.Location = new Point(119, 12);
            tbDestinataire.Name = "tbDestinataire";
            tbDestinataire.Size = new Size(395, 27);
            tbDestinataire.TabIndex = 23;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(16, 72);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(72, 24);
            kryptonLabel4.TabIndex = 22;
            kryptonLabel4.Values.Text = "Message";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(16, 42);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(49, 24);
            kryptonLabel3.TabIndex = 21;
            kryptonLabel3.Values.Text = "Objet";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(16, 12);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(93, 24);
            kryptonLabel2.TabIndex = 20;
            kryptonLabel2.Values.Text = "Destinataire";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAddFile);
            tabPage2.Controls.Add(dgvFiles);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(530, 206);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fichiers joints";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddFile
            // 
            btnAddFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddFile.Location = new Point(445, 6);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(79, 29);
            btnAddFile.TabIndex = 1;
            btnAddFile.Values.Text = "Ajouter";
            btnAddFile.Click += btnAddFile_Click;
            // 
            // dgvFiles
            // 
            dgvFiles.AllowUserToAddRows = false;
            dgvFiles.BorderStyle = BorderStyle.None;
            dgvFiles.ColumnHeadersHeight = 36;
            dgvFiles.Columns.AddRange(new DataGridViewColumn[] { colNom });
            dgvFiles.Location = new Point(6, 6);
            dgvFiles.Name = "dgvFiles";
            dgvFiles.RowHeadersWidth = 51;
            dgvFiles.Size = new Size(433, 194);
            dgvFiles.TabIndex = 0;
            dgvFiles.UserDeletingRow += dgvFiles_UserDeletingRow;
            // 
            // colNom
            // 
            colNom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNom.HeaderText = "Fichier";
            colNom.MinimumWidth = 6;
            colNom.Name = "colNom";
            colNom.ReadOnly = true;
            // 
            // btnInit
            // 
            btnInit.Location = new Point(320, 291);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(112, 31);
            btnInit.TabIndex = 9;
            btnInit.Values.Text = "Init";
            btnInit.Click += btnInit_Click;
            // 
            // fSendEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 334);
            Controls.Add(btnInit);
            Controls.Add(tabControl1);
            Controls.Add(kryptonLabel1);
            Controls.Add(bEnvoyer);
            Name = "fSendEmail";
            Text = "Chat";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton bEnvoyer;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Krypton.Toolkit.KryptonTextBox tbMessage;
        private Krypton.Toolkit.KryptonTextBox tbObjet;
        private Krypton.Toolkit.KryptonTextBox tbDestinataire;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnAddFile;
        private Krypton.Toolkit.KryptonDataGridView dgvFiles;
        private DataGridViewTextBoxColumn colNom;
        private Krypton.Toolkit.KryptonButton btnInit;
    }
}
