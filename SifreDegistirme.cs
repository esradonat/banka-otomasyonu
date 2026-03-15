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
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer1.windowlessVideo = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            _5_TumIslemler yeni = new _5_TumIslemler();
            yeni.Show();
            this.Hide();
        }

        SqlConnection connection = new SqlConnection("Data Source=ESRA\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuFinal;Integrated Security=True;TrustServerCertificate=True");


        //-----------------------------------------------------------------------
        void SifreDegistir()
        {
            if (txtEskiSifre.Text == "" || txtYeniSifre.Text == "" || txtYeniTekrar.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurunuz!");
                return;
            }

            if (txtYeniSifre.Text != txtYeniTekrar.Text)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor!");
                return;
            }

            if (txtEskiSifre.Text == txtYeniSifre.Text)
            {
                MessageBox.Show("Yeni şifre eski şifre ile aynı olamaz!");
                return;
            }

            if (txtYeniSifre.Text.Length != 6 || !txtYeniSifre.Text.All(char.IsDigit))
            {
                MessageBox.Show("Şifre 6 haneli ve sadece rakamlardan oluşmalıdır!");
                return;
            }


            connection.Open();
            SqlCommand kontrol = new SqlCommand( "select count(*) from Musteri where MusteriID=@musteriId and Sifre=@sifre",connection);
            kontrol.Parameters.AddWithValue("@musteriId", Program.AktifMusteriID);
            kontrol.Parameters.AddWithValue("@sifre", txtEskiSifre.Text);
            int sayi = (int)kontrol.ExecuteScalar();

            if (sayi == 0)
            {
                MessageBox.Show("Eski şifre yanlış!");
                connection.Close();
                return;
            }

            //guncelleme
            SqlCommand guncelle = new SqlCommand( "update Musteri SET Sifre=@yeniSifre WHERE MusteriID=@musteriId",connection);
            guncelle.Parameters.AddWithValue("@yeniSifre", txtYeniSifre.Text);
            guncelle.Parameters.AddWithValue("@musteriId", Program.AktifMusteriID);
            guncelle.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Şifre başarıyla değiştirildi.");
        }


        private void btnSifreDegistirme_Click(object sender, EventArgs e)
        {
            SifreDegistir();

        }
    }
}
