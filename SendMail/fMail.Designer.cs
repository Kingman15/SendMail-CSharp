namespace SendMail
{
    partial class fMail
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
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            dgvMails = new Krypton.Toolkit.KryptonDataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            btnRefresh = new Krypton.Toolkit.KryptonButton();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            lbLastRefresh = new Krypton.Toolkit.KryptonLabel();
            btnSend = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvMails).BeginInit();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel1.Location = new Point(12, 12);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(45, 24);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Chat";
            // 
            // dgvMails
            // 
            dgvMails.AllowUserToAddRows = false;
            dgvMails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMails.BorderStyle = BorderStyle.None;
            dgvMails.ColumnHeadersHeight = 36;
            dgvMails.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            dgvMails.Location = new Point(12, 42);
            dgvMails.Name = "dgvMails";
            dgvMails.RowHeadersWidth = 51;
            dgvMails.Size = new Size(776, 359);
            dgvMails.TabIndex = 3;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Expeditaire";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 117;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Sujet";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.Location = new Point(676, 407);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 31);
            btnRefresh.TabIndex = 4;
            btnRefresh.Values.Text = "Actualiser";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel2.Location = new Point(12, 414);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(185, 24);
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.Values.Text = "Dernier rafraichissement :";
            // 
            // lbLastRefresh
            // 
            lbLastRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbLastRefresh.Location = new Point(203, 414);
            lbLastRefresh.Name = "lbLastRefresh";
            lbLastRefresh.Size = new Size(18, 24);
            lbLastRefresh.TabIndex = 6;
            lbLastRefresh.Values.Text = "-";
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Location = new Point(558, 407);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 31);
            btnSend.TabIndex = 7;
            btnSend.Values.Text = "Nouveau";
            btnSend.Click += btnSend_Click;
            // 
            // fMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(lbLastRefresh);
            Controls.Add(kryptonLabel2);
            Controls.Add(btnRefresh);
            Controls.Add(dgvMails);
            Controls.Add(kryptonLabel1);
            Name = "fMail";
            Text = "Chat";
            Load += fMail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonDataGridView dgvMails;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Krypton.Toolkit.KryptonButton btnRefresh;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lbLastRefresh;
        private Krypton.Toolkit.KryptonButton btnSend;
    }
}