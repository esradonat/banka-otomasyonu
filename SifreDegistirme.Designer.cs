namespace BankaOtomasyonu
{
    partial class SifreDegistirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistirme));
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            txtYeniTekrar = new TextBox();
            label4 = new Label();
            txtYeniSifre = new TextBox();
            label3 = new Label();
            txtEskiSifre = new TextBox();
            lbleski = new Label();
            btnSifreDegistirme = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tan;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(248, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(997, 70);
            panel3.TabIndex = 12;
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
            label1.Location = new Point(346, 15);
            label1.Name = "label1";
            label1.Size = new Size(296, 43);
            label1.TabIndex = 0;
            label1.Text = "Şifre Değiştirme";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(248, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 781);
            panel1.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtYeniTekrar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtYeniSifre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtEskiSifre);
            groupBox2.Controls.Add(lbleski);
            groupBox2.Controls.Add(btnSifreDegistirme);
            groupBox2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(0, 192, 192);
            groupBox2.Location = new Point(138, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 649);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şifre Değiştirme";
            // 
            // txtYeniTekrar
            // 
            txtYeniTekrar.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtYeniTekrar.ImeMode = ImeMode.NoControl;
            txtYeniTekrar.Location = new Point(275, 315);
            txtYeniTekrar.Name = "txtYeniTekrar";
            txtYeniTekrar.Size = new Size(313, 34);
            txtYeniTekrar.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(43, 314);
            label4.Name = "label4";
            label4.Size = new Size(226, 33);
            label4.TabIndex = 16;
            label4.Text = "Yeni Şifre Tekrar : ";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtYeniSifre.ImeMode = ImeMode.NoControl;
            txtYeniSifre.Location = new Point(275, 232);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(313, 34);
            txtYeniSifre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(133, 233);
            label3.Name = "label3";
            label3.Size = new Size(136, 33);
            label3.TabIndex = 14;
            label3.Text = "Yeni Şifre: ";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtEskiSifre.ImeMode = ImeMode.NoControl;
            txtEskiSifre.Location = new Point(275, 146);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.Size = new Size(313, 34);
            txtEskiSifre.TabIndex = 13;
            // 
            // lbleski
            // 
            lbleski.AutoSize = true;
            lbleski.Font = new Font("Cambria", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbleski.ForeColor = Color.Black;
            lbleski.Location = new Point(119, 146);
            lbleski.Name = "lbleski";
            lbleski.Size = new Size(136, 33);
            lbleski.TabIndex = 12;
            lbleski.Text = "Eski Şifre: ";
            // 
            // btnSifreDegistirme
            // 
            btnSifreDegistirme.BackColor = Color.FromArgb(0, 222, 210);
            btnSifreDegistirme.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSifreDegistirme.ForeColor = Color.White;
            btnSifreDegistirme.Location = new Point(275, 400);
            btnSifreDegistirme.Name = "btnSifreDegistirme";
            btnSifreDegistirme.Size = new Size(313, 46);
            btnSifreDegistirme.TabIndex = 0;
            btnSifreDegistirme.Text = "Onayla";
            btnSifreDegistirme.UseVisualStyleBackColor = false;
            btnSifreDegistirme.Click += btnSifreDegistirme_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1451, 805);
            axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // SifreDegistirme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 805);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "SifreDegistirme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifreDegistirme";
            Load += SifreDegistirme_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private GroupBox groupBox2;
        private Button btnSifreDegistirme;
        private TextBox txtYeniTekrar;
        private Label label4;
        private TextBox txtYeniSifre;
        private Label label3;
        private TextBox txtEskiSifre;
        private Label lbleski;
    }
}