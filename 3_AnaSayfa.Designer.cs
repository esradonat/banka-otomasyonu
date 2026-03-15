namespace BankaOtomasyonu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            btnTumIslem = new Button();
            btnparatransfer = new Button();
            btnParayatir = new Button();
            btnParacekme = new Button();
            groupBox1 = new GroupBox();
            lblHesapTur2 = new Label();
            lblHesapTur1 = new Label();
            btnHesapHareket = new Button();
            lblBakiye = new Label();
            lblIban = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblcikis = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(248, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 781);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTumIslem);
            groupBox2.Controls.Add(btnparatransfer);
            groupBox2.Controls.Add(btnParayatir);
            groupBox2.Controls.Add(btnParacekme);
            groupBox2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(0, 192, 192);
            groupBox2.Location = new Point(163, 424);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(676, 325);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kısayollarım";
            // 
            // btnTumIslem
            // 
            btnTumIslem.BackColor = Color.FromArgb(0, 192, 192);
            btnTumIslem.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTumIslem.ForeColor = Color.White;
            btnTumIslem.Location = new Point(48, 261);
            btnTumIslem.Name = "btnTumIslem";
            btnTumIslem.Size = new Size(583, 49);
            btnTumIslem.TabIndex = 3;
            btnTumIslem.Text = "Tüm İşlemler";
            btnTumIslem.UseVisualStyleBackColor = false;
            btnTumIslem.Click += button5_Click;
            // 
            // btnparatransfer
            // 
            btnparatransfer.BackColor = Color.FromArgb(0, 192, 192);
            btnparatransfer.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnparatransfer.ForeColor = Color.White;
            btnparatransfer.Location = new Point(48, 196);
            btnparatransfer.Name = "btnparatransfer";
            btnparatransfer.Size = new Size(583, 49);
            btnparatransfer.TabIndex = 2;
            btnparatransfer.Text = "Para Transferi";
            btnparatransfer.UseVisualStyleBackColor = false;
            btnparatransfer.Click += btnparatransfer_Click;
            // 
            // btnParayatir
            // 
            btnParayatir.BackColor = Color.FromArgb(0, 192, 192);
            btnParayatir.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnParayatir.ForeColor = Color.White;
            btnParayatir.Location = new Point(48, 128);
            btnParayatir.Name = "btnParayatir";
            btnParayatir.Size = new Size(583, 49);
            btnParayatir.TabIndex = 1;
            btnParayatir.Text = "Para Yatırma";
            btnParayatir.UseVisualStyleBackColor = false;
            btnParayatir.Click += btnParayatir_Click;
            // 
            // btnParacekme
            // 
            btnParacekme.BackColor = Color.FromArgb(0, 192, 192);
            btnParacekme.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnParacekme.ForeColor = Color.White;
            btnParacekme.Location = new Point(48, 59);
            btnParacekme.Name = "btnParacekme";
            btnParacekme.Size = new Size(583, 49);
            btnParacekme.TabIndex = 0;
            btnParacekme.Text = "Para Çekme";
            btnParacekme.UseVisualStyleBackColor = false;
            btnParacekme.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblHesapTur2);
            groupBox1.Controls.Add(lblHesapTur1);
            groupBox1.Controls.Add(btnHesapHareket);
            groupBox1.Controls.Add(lblBakiye);
            groupBox1.Controls.Add(lblIban);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(0, 222, 192);
            groupBox1.Location = new Point(163, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 312);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesaplarım";
            // 
            // lblHesapTur2
            // 
            lblHesapTur2.AutoSize = true;
            lblHesapTur2.BackColor = Color.Tan;
            lblHesapTur2.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHesapTur2.ForeColor = Color.White;
            lblHesapTur2.Location = new Point(48, 50);
            lblHesapTur2.Name = "lblHesapTur2";
            lblHesapTur2.Size = new Size(255, 30);
            lblHesapTur2.TabIndex = 6;
            lblHesapTur2.Text = "             Vadesiz             ";
            lblHesapTur2.Click += lblHesapTur2_Click;
            // 
            // lblHesapTur1
            // 
            lblHesapTur1.AutoSize = true;
            lblHesapTur1.BackColor = Color.Tan;
            lblHesapTur1.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHesapTur1.ForeColor = Color.White;
            lblHesapTur1.Location = new Point(373, 50);
            lblHesapTur1.Name = "lblHesapTur1";
            lblHesapTur1.Size = new Size(258, 30);
            lblHesapTur1.TabIndex = 2;
            lblHesapTur1.Text = "              Vadeli               ";
            lblHesapTur1.Click += lblHesapTur1_Click;
            // 
            // btnHesapHareket
            // 
            btnHesapHareket.BackColor = Color.FromArgb(0, 222, 192);
            btnHesapHareket.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHesapHareket.ForeColor = Color.White;
            btnHesapHareket.Location = new Point(48, 242);
            btnHesapHareket.Name = "btnHesapHareket";
            btnHesapHareket.Size = new Size(583, 49);
            btnHesapHareket.TabIndex = 0;
            btnHesapHareket.Text = "Hesap Hareketleri";
            btnHesapHareket.UseVisualStyleBackColor = false;
            btnHesapHareket.Click += btnHesapHareket_Click;
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBakiye.ForeColor = Color.Black;
            lblBakiye.Location = new Point(48, 190);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(38, 27);
            lblBakiye.TabIndex = 5;
            lblBakiye.Text = "TL";
            // 
            // lblIban
            // 
            lblIban.AutoSize = true;
            lblIban.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblIban.ForeColor = Color.Black;
            lblIban.Location = new Point(48, 109);
            lblIban.Name = "lblIban";
            lblIban.Size = new Size(49, 33);
            lblIban.TabIndex = 3;
            lblIban.Text = "TR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(48, 156);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 4;
            label4.Text = "Bakiye";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(lblcikis);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(248, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 70);
            panel2.TabIndex = 8;
            // 
            // lblcikis
            // 
            lblcikis.AutoSize = true;
            lblcikis.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcikis.ForeColor = Color.White;
            lblcikis.Location = new Point(0, -3);
            lblcikis.Name = "lblcikis";
            lblcikis.Size = new Size(74, 74);
            lblcikis.TabIndex = 2;
            lblcikis.Text = "←";
            lblcikis.Click += lblcikis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(403, 18);
            label1.Name = "label1";
            label1.Size = new Size(188, 43);
            label1.TabIndex = 0;
            label1.Text = "İyi Günler";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 805);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel1;
        private Button btnHesapHareket;
        private Label lblHesapTur1;
        private Label label4;
        private Label lblIban;
        private Label lblBakiye;
        private GroupBox groupBox2;
        private Button btnTumIslem;
        private Button btnparatransfer;
        private Button btnParayatir;
        private Button btnParacekme;
        private GroupBox groupBox1;
        private Label lblHesapTur2;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblcikis;
    }
}