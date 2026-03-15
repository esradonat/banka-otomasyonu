namespace BankaOtomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            label5 = new Label();
            textBoxSifre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBoxTel = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxAd = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxSifre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxTel);
            panel1.Controls.Add(textBoxSoyad);
            panel1.Controls.Add(textBoxAd);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(436, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 550);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(92, 362);
            label5.Name = "label5";
            label5.Size = new Size(97, 27);
            label5.TabIndex = 20;
            label5.Text = "Şifreniz :";
            // 
            // textBoxSifre
            // 
            textBoxSifre.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSifre.Location = new Point(211, 347);
            textBoxSifre.MaxLength = 6;
            textBoxSifre.Multiline = true;
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.PasswordChar = '*';
            textBoxSifre.Size = new Size(224, 42);
            textBoxSifre.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(61, 298);
            label4.Name = "label4";
            label4.Size = new Size(128, 27);
            label4.TabIndex = 18;
            label4.Text = "Telefon No :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(72, 234);
            label3.Name = "label3";
            label3.Size = new Size(117, 27);
            label3.TabIndex = 17;
            label3.Text = "Soyadınız :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(104, 171);
            label2.Name = "label2";
            label2.Size = new Size(85, 27);
            label2.TabIndex = 16;
            label2.Text = "Adınız :";
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(211, 427);
            button1.Name = "button1";
            button1.Size = new Size(224, 46);
            button1.TabIndex = 15;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxTel
            // 
            textBoxTel.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxTel.Location = new Point(211, 283);
            textBoxTel.MaxLength = 11;
            textBoxTel.Multiline = true;
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(224, 42);
            textBoxTel.TabIndex = 14;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSoyad.Location = new Point(211, 219);
            textBoxSoyad.Multiline = true;
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(224, 42);
            textBoxSoyad.TabIndex = 13;
            // 
            // textBoxAd
            // 
            textBoxAd.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxAd.Location = new Point(211, 156);
            textBoxAd.Multiline = true;
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(224, 42);
            textBoxAd.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(211, 76);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(156, 45);
            label1.TabIndex = 10;
            label1.Text = "Kayıt Ol";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 805);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ol";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBoxTel;
        private TextBox textBoxSoyad;
        private TextBox textBoxAd;
        private Label label1;
        private Label label5;
        private TextBox textBoxSifre;
    }
}