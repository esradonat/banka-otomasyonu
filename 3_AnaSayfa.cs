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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer1.windowlessVideo = true;

            HesapGetir("Vadesiz");

            GunlukFaizHesapla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _7_ParaCekme yeni = new _7_ParaCekme();
            yeni.Show();
            this.Hide();
        }

        private void btnHesapHareket_Click(object sender, EventArgs e)
        {
            _4_HesapHareketlerii yeni = new _4_HesapHareketlerii();
            yeni.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _5_TumIslemler yeni = new _5_TumIslemler();
            yeni.Show();
            this.Hide();
        }
        private void btnParayatir_Click(object sender, EventArgs e)
        {
            _8_ParaYatirma yeni = new _8_ParaYatirma();
            yeni.Show();
            this.Hide();
        }

        private void btnparatransfer_Click(object sender, EventArgs e)
        {
            _9_ParaTransferi yeni = new _9_ParaTransferi();
            yeni.Show();
            this.Hide();
        }

        SqlConnection connection = new SqlConnection("Data Source=ESRA\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuFinal;Integrated Security=True;TrustServerCertificate=True");

        //-------------------------------------------------- hesap getirme ------------------------------------------------------------
        void HesapGetir(string hesapTuru)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select HesapID, HesapTuru, Bakiye  from Hesap where musteriID=@musteriID and HesapTuru = @HesapTuru", connection);
            command.Parameters.AddWithValue("@MusteriID", Program.AktifMusteriID);
            command.Parameters.AddWithValue("@HesapTuru", hesapTuru);

            SqlDataReader oku = command.ExecuteReader();

            if (oku.Read())   //hesabı varsa
            {
                if (hesapTuru == "Vadeli")
                {
                    lblHesapTur1.Text = "             " + oku["HesapTuru"].ToString() + "              ";

                    lblHesapTur1.BorderStyle = BorderStyle.FixedSingle;
                    lblHesapTur1.BackColor = Color.BurlyWood;
                    //digeri ilk hale donsun diye
                    lblHesapTur2.BorderStyle = BorderStyle.None;
                    lblHesapTur2.BackColor = Color.Tan;
                }

                if (hesapTuru == "Vadesiz")
                {
                    lblHesapTur2.Text = "             " + oku["HesapTuru"].ToString() + "             ";

                    lblHesapTur2.BorderStyle = BorderStyle.FixedSingle;
                    lblHesapTur2.BackColor = Color.BurlyWood;
                    //digeri ilk hale donsun diye
                    lblHesapTur1.BorderStyle = BorderStyle.None;
                    lblHesapTur1.BackColor = Color.Tan;
                }

                lblIban.Text = oku["HesapID"].ToString();
                lblBakiye.Text = oku["Bakiye"].ToString() + " TL";
            }

            else   //hesabı yoksa
            {


                if (hesapTuru == "Vadeli")
                {
                    lblIban.Text = "Henüz vadeli hesabınız bulunmamaktadır.";
                    lblBakiye.Text = "0 TL";
                    lblHesapTur1.BorderStyle = BorderStyle.FixedSingle;
                    lblHesapTur1.BackColor = Color.BurlyWood;
                    //digeri ilk hale donsun diye
                    lblHesapTur2.BorderStyle = BorderStyle.None;
                    lblHesapTur2.BackColor = Color.Tan;
                }

                if (hesapTuru == "Vadesiz")
                {
                    lblIban.Text = "Henüz vadesiz hesabınız bulunmamaktadır.";
                    lblBakiye.Text = "0 TL";
                    lblHesapTur2.BorderStyle = BorderStyle.FixedSingle;
                    lblHesapTur2.BackColor = Color.BurlyWood;
                    //digeri ilk hale donsun diye
                    lblHesapTur1.BorderStyle = BorderStyle.None;
                    lblHesapTur1.BackColor = Color.Tan;
                }
            }
            connection.Close();
        }



        //---------------------------------------- Faiz -------------------------------------------------------------
        void GunlukFaizHesapla()
        {
            SqlConnection connectionGuncelle = new SqlConnection("Data Source=ESRA\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuFinal;Integrated Security=True;TrustServerCertificate=True");

            connection.Open();

            SqlCommand cmd = new SqlCommand(@"select HesapID, Bakiye, FaizOrani, SonFaizHesaplama from Hesap where MusteriID = @musteriID and HesapTuru = 'Vadeli' and VadeBitis >= GETDATE()", connection);
            cmd.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);

            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                string hesapID = oku["HesapID"].ToString();
                decimal bakiye = Convert.ToDecimal(oku["Bakiye"]);
                decimal faizOrani = Convert.ToDecimal(oku["FaizOrani"]);
                DateTime sonFaiz = Convert.ToDateTime(oku["SonFaizHesaplama"]);

                int gunSayisi = (DateTime.Now - sonFaiz).Days;
                if (gunSayisi <= 0) continue;

                decimal gunlukFaiz = faizOrani / 365;
                decimal faizTutari = bakiye * gunlukFaiz * gunSayisi;

                connectionGuncelle.Open();

                // Bakiye güncelle
                SqlCommand guncelle = new SqlCommand(@"update Hesap set Bakiye = Bakiye + @faiz, SonFaizHesaplama = GETDATE() where HesapID = @hesapID", connectionGuncelle);
                guncelle.Parameters.AddWithValue("@faiz", faizTutari);
                guncelle.Parameters.AddWithValue("@hesapID", hesapID);
                guncelle.ExecuteNonQuery();

                // Hareket ekle
                SqlCommand hareket = new SqlCommand(@"insert into HesapHareketleri
                (MusteriID, Tarih, Aciklama, Tutar, IslemTuru)
                values
                (@musteriID, GETDATE(), 'Günlük Vadeli Faiz', @tutar, 'Faiz')", connectionGuncelle);

                hareket.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
                hareket.Parameters.AddWithValue("@tutar", faizTutari);
                hareket.ExecuteNonQuery();

                connectionGuncelle.Close();
            }
            connection.Close();
        }

        private void lblHesapTur1_Click(object sender, EventArgs e)
        {
            HesapGetir("Vadeli");
        }

        private void lblHesapTur2_Click(object sender, EventArgs e)
        {
            HesapGetir("Vadesiz");
        }

        private void lblcikis_Click(object sender, EventArgs e)
        {
            Giris yeni = new Giris();
            yeni.Show();
            this.Hide();
        }
    }
}
