namespace BankaOtomasyonu
{
    partial class _9_ParaTransferi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_9_ParaTransferi));
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox5 = new GroupBox();
            txtTarih = new TextBox();
            label7 = new Label();
            txtAcıklama = new TextBox();
            label5 = new Label();
            btnOnayla = new Button();
            txtTutar = new TextBox();
            lblTutar = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            checkBox2Vadeli = new CheckBox();
            lblBakiyeVadeli = new Label();
            lblVadeli = new Label();
            groupBox4 = new GroupBox();
            checkBoxVadesiz = new CheckBox();
            lblBakiyeVadesiz = new Label();
            lblVadesiz = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label4 = new Label();
            txtIbanAlici = new TextBox();
            label3 = new Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
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
            label1.Location = new Point(376, 15);
            label1.Name = "label1";
            label1.Size = new Size(264, 43);
            label1.TabIndex = 0;
            label1.Text = "Para Transferi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(248, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 781);
            panel1.TabIndex = 11;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTarih);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(txtAcıklama);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(btnOnayla);
            groupBox5.Controls.Add(txtTutar);
            groupBox5.Controls.Add(lblTutar);
            groupBox5.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.FromArgb(0, 192, 192);
            groupBox5.Location = new Point(74, 542);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(854, 213);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tutar Belirleme";
            // 
            // txtTarih
            // 
            txtTarih.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtTarih.ImeMode = ImeMode.NoControl;
            txtTarih.Location = new Point(314, 157);
            txtTarih.Name = "txtTarih";
            txtTarih.ReadOnly = true;
            txtTarih.Size = new Size(225, 34);
            txtTarih.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(20, 160);
            label7.Name = "label7";
            label7.Size = new Size(293, 27);
            label7.TabIndex = 19;
            label7.Text = "İşlemin Gerçekleşeceği Tarih :";
            // 
            // txtAcıklama
            // 
            txtAcıklama.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtAcıklama.ImeMode = ImeMode.NoControl;
            txtAcıklama.Location = new Point(141, 99);
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.Size = new Size(695, 34);
            txtAcıklama.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(20, 106);
            label5.Name = "label5";
            label5.Size = new Size(117, 27);
            label5.TabIndex = 16;
            label5.Text = "Açıklama : ";
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(0, 192, 192);
            btnOnayla.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Location = new Point(569, 151);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(267, 44);
            btnOnayla.TabIndex = 15;
            btnOnayla.Text = "ONAYLA";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // txtTutar
            // 
            txtTutar.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtTutar.ImeMode = ImeMode.NoControl;
            txtTutar.Location = new Point(141, 52);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(225, 34);
            txtTutar.TabIndex = 14;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Cambria", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblTutar.ForeColor = Color.Black;
            lblTutar.Location = new Point(55, 59);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(82, 27);
            lblTutar.TabIndex = 13;
            lblTutar.Text = "Tutar : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(0, 192, 192);
            groupBox2.Location = new Point(74, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(854, 207);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gönderen Hesap";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(checkBox2Vadeli);
            groupBox3.Controls.Add(lblBakiyeVadeli);
            groupBox3.Controls.Add(lblVadeli);
            groupBox3.Location = new Point(447, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(378, 125);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // checkBox2Vadeli
            // 
            checkBox2Vadeli.AutoSize = true;
            checkBox2Vadeli.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox2Vadeli.Location = new Point(328, 53);
            checkBox2Vadeli.Name = "checkBox2Vadeli";
            checkBox2Vadeli.Size = new Size(18, 17);
            checkBox2Vadeli.TabIndex = 3;
            checkBox2Vadeli.UseVisualStyleBackColor = true;
            checkBox2Vadeli.CheckedChanged += checkBox2Vadeli_CheckedChanged;
            // 
            // lblBakiyeVadeli
            // 
            lblBakiyeVadeli.AutoSize = true;
            lblBakiyeVadeli.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBakiyeVadeli.ForeColor = Color.Black;
            lblBakiyeVadeli.Location = new Point(15, 66);
            lblBakiyeVadeli.Name = "lblBakiyeVadeli";
            lblBakiyeVadeli.Size = new Size(71, 21);
            lblBakiyeVadeli.TabIndex = 2;
            lblBakiyeVadeli.Text = "Bakiye :";
            // 
            // lblVadeli
            // 
            lblVadeli.AutoSize = true;
            lblVadeli.Font = new Font("Cambria", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblVadeli.ForeColor = Color.Black;
            lblVadeli.Location = new Point(15, 23);
            lblVadeli.Name = "lblVadeli";
            lblVadeli.Size = new Size(77, 27);
            lblVadeli.TabIndex = 1;
            lblVadeli.Text = "Vadeli";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.WhiteSmoke;
            groupBox4.Controls.Add(checkBoxVadesiz);
            groupBox4.Controls.Add(lblBakiyeVadesiz);
            groupBox4.Controls.Add(lblVadesiz);
            groupBox4.Location = new Point(20, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(378, 125);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // checkBoxVadesiz
            // 
            checkBoxVadesiz.AutoSize = true;
            checkBoxVadesiz.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBoxVadesiz.Location = new Point(328, 53);
            checkBoxVadesiz.Name = "checkBoxVadesiz";
            checkBoxVadesiz.Size = new Size(18, 17);
            checkBoxVadesiz.TabIndex = 3;
            checkBoxVadesiz.UseVisualStyleBackColor = true;
            checkBoxVadesiz.CheckedChanged += checkBoxVadesiz_CheckedChanged;
            // 
            // lblBakiyeVadesiz
            // 
            lblBakiyeVadesiz.AutoSize = true;
            lblBakiyeVadesiz.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBakiyeVadesiz.ForeColor = Color.Black;
            lblBakiyeVadesiz.Location = new Point(15, 66);
            lblBakiyeVadesiz.Name = "lblBakiyeVadesiz";
            lblBakiyeVadesiz.Size = new Size(71, 21);
            lblBakiyeVadesiz.TabIndex = 2;
            lblBakiyeVadesiz.Text = "Bakiye :";
            // 
            // lblVadesiz
            // 
            lblVadesiz.AutoSize = true;
            lblVadesiz.Font = new Font("Cambria", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblVadesiz.ForeColor = Color.Black;
            lblVadesiz.Location = new Point(15, 23);
            lblVadesiz.Name = "lblVadesiz";
            lblVadesiz.Size = new Size(92, 27);
            lblVadesiz.TabIndex = 1;
            lblVadesiz.Text = "Vadesiz";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIbanAlici);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(0, 192, 192);
            groupBox1.Location = new Point(74, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 190);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alıcı Hesap";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(447, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 34);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(447, 65);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 4;
            label4.Text = "Ad Soyad";
            // 
            // txtIbanAlici
            // 
            txtIbanAlici.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtIbanAlici.Location = new Point(20, 110);
            txtIbanAlici.Name = "txtIbanAlici";
            txtIbanAlici.Size = new Size(378, 34);
            txtIbanAlici.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 65);
            label3.Name = "label3";
            label3.Size = new Size(63, 27);
            label3.TabIndex = 2;
            label3.Text = "IBAN";
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
            // _9_ParaTransferi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 805);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "_9_ParaTransferi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_9_ParaTransferi";
            Load += _9_ParaTransferi_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox checkBox2Vadeli;
        private Label lblBakiyeVadeli;
        private Label lblVadeli;
        private GroupBox groupBox4;
        private CheckBox checkBoxVadesiz;
        private Label lblBakiyeVadesiz;
        private Label lblVadesiz;
        private TextBox textBox2;
        private Label label4;
        private TextBox txtIbanAlici;
        private Label label3;
        private GroupBox groupBox5;
        private TextBox txtAcıklama;
        private Label label5;
        private Button btnOnayla;
        private TextBox txtTutar;
        private Label lblTutar;
        private Label label7;
        private TextBox txtTarih;
    }
}