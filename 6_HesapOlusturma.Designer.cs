namespace BankaOtomasyonu
{
    partial class HesapOlusturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapOlusturma));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(248, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 781);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(0, 222, 192);
            groupBox1.Location = new Point(184, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 595);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap Oluşturma";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 39);
            textBox1.TabIndex = 8;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox2.ForeColor = Color.FromArgb(64, 64, 64);
            checkBox2.Location = new Point(29, 165);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 31);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Vadesiz";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox1.ForeColor = Color.FromArgb(64, 64, 64);
            checkBox1.Location = new Point(31, 117);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 31);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Vadeli";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 222, 192);
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 417);
            button1.Name = "button1";
            button1.Size = new Size(554, 49);
            button1.TabIndex = 0;
            button1.Text = "Hesap Oluştur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(247, 308);
            label5.Name = "label5";
            label5.Size = new Size(38, 27);
            label5.TabIndex = 5;
            label5.Text = "TL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(29, 78);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 3;
            label3.Text = "Hesap Türü :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(31, 258);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 4;
            label4.Text = "Bakiye Giriniz  :";
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1451, 805);
            axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tan;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(248, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(997, 70);
            panel3.TabIndex = 9;
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
            label1.Location = new Point(328, 15);
            label1.Name = "label1";
            label1.Size = new Size(315, 43);
            label1.TabIndex = 0;
            label1.Text = "Hesap Oluşturma";
            // 
            // HesapOlusturma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 805);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "HesapOlusturma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hesap Olusturma";
            Load += HesapOlusturma_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private GroupBox groupBox1;
        private Button button1;
        private Label label5;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private Panel panel3;
        private Label label2;
        private Label label1;
    }
}