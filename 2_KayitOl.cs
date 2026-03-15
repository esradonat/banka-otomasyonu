using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BankaOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer1.windowlessVideo = true;

            // Paneli yuvarlak yap
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, panel1.Width - 1, panel1.Height - 1);
            panel1.Region = new Region(gp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAd.Text) ||
            string.IsNullOrWhiteSpace(textBoxSoyad.Text) ||
            string.IsNullOrWhiteSpace(textBoxTel.Text) ||
            string.IsNullOrWhiteSpace(textBoxSifre.Text))
            {
                MessageBox.Show(
                    "Lütfen tüm alanları doldurunuz!",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (textBoxSifre.Text.Length != 6 || !textBoxSifre.Text.All(char.IsDigit))
            {
                MessageBox.Show("Şifre 6 haneli ve sadece rakamlardan oluşmalıdır!");
                return;
            }


            SqlConnection connection = new SqlConnection("Data Source=ESRA\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuFinal;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Musteri (Ad, Soyad, Telefon, Sifre) VALUES (@Ad, @Soyad, @Telefon, @Sifre)", connection);

            command.Parameters.AddWithValue("@Ad", textBoxAd.Text);
            command.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            command.Parameters.AddWithValue("@Telefon", textBoxTel.Text);
            command.Parameters.AddWithValue("@Sifre", textBoxSifre.Text);

            command.ExecuteNonQuery();

            MessageBox.Show("Müşteri başarıyla kaydedildi!");

            Giris yeni = new Giris();
            yeni.Show();
            this.Hide();

            connection.Close();

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
