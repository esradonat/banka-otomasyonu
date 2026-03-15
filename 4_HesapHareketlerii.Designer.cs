namespace BankaOtomasyonu
{
    partial class _4_HesapHareketlerii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_4_HesapHareketlerii));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            btnFiltrele = new Button();
            dtBitis = new DateTimePicker();
            dtBaslangic = new DateTimePicker();
            pnlHareketler = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1451, 805);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnFiltrele);
            panel1.Controls.Add(dtBitis);
            panel1.Controls.Add(dtBaslangic);
            panel1.Controls.Add(pnlHareketler);
            panel1.Location = new Point(248, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 781);
            panel1.TabIndex = 1;
            // 
            // btnFiltrele
            // 
            btnFiltrele.BackColor = Color.FromArgb(0, 192, 192);
            btnFiltrele.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnFiltrele.ForeColor = Color.White;
            btnFiltrele.Location = new Point(659, 76);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(199, 37);
            btnFiltrele.TabIndex = 2;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = false;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // dtBitis
            // 
            dtBitis.Location = new Point(403, 81);
            dtBitis.Name = "dtBitis";
            dtBitis.Size = new Size(250, 27);
            dtBitis.TabIndex = 1;
            // 
            // dtBaslangic
            // 
            dtBaslangic.Location = new Point(147, 81);
            dtBaslangic.Name = "dtBaslangic";
            dtBaslangic.Size = new Size(250, 27);
            dtBaslangic.TabIndex = 0;
            dtBaslangic.Value = new DateTime(2024, 12, 25, 1, 27, 0, 0);
            // 
            // pnlHareketler
            // 
            pnlHareketler.AutoScroll = true;
            pnlHareketler.Location = new Point(105, 119);
            pnlHareketler.Name = "pnlHareketler";
            pnlHareketler.Size = new Size(781, 627);
            pnlHareketler.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(248, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 70);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, -12);
            label2.Name = "label2";
            label2.Size = new Size(74, 74);
            label2.TabIndex = 1;
            label2.Text = "←";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(322, 12);
            label1.Name = "label1";
            label1.Size = new Size(331, 43);
            label1.TabIndex = 0;
            label1.Text = "Hesap Hareketleri";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // _4_HesapHareketlerii
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 805);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "_4_HesapHareketlerii";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_4_HesapHareketlerii";
            Load += _4_HesapHareketlerii_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel pnlHareketler;
        private DateTimePicker dtBitis;
        private DateTimePicker dtBaslangic;
        private Button btnFiltrele;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}