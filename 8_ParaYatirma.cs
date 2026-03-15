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
    public partial class _8_ParaYatirma : Form
    {
        public _8_ParaYatirma()
        {
            InitializeComponent();
        }

        private void _8_ParaYatirma_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer1.windowlessVideo = true;

            lblTutar.Visible = false;
            txtTutar.Visible = false;
            btnOnayla.Visible = false;

            HesapGetir("Vadesiz");
            HesapGetir("Vadeli");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            _5_TumIslemler yeni = new _5_TumIslemler();
            yeni.Show();
            this.Hide();
        }

        SqlConnection connection = new SqlConnection("Data Source=ESRA\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuFinal;Integrated Security=True;TrustServerCertificate=True");


        //---------------------------------------- hesap getirme metodu -------------------------------------------------

        void HesapGetir(string hesapTuru)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select HesapTuru, Bakiye  from Hesap where MusteriID=@musteriID and HesapTuru = @HesapTuru", connection);
            command.Parameters.AddWithValue("@MusteriID", Program.AktifMusteriID);
            command.Parameters.AddWithValue("@HesapTuru", hesapTuru);

            SqlDataReader oku = command.ExecuteReader();

            if (oku.Read())   //hesabı varsa
            {
                if (hesapTuru == "Vadeli")
                {
                    lblBakiyeVadeli.Text = " Bakiye : " + oku["Bakiye"].ToString() + " TL";
                }

                if (hesapTuru == "Vadesiz")
                {
                    lblBakiyeVadesiz.Text = " Bakiye : " + oku["Bakiye"].ToString() + " TL";

                }
            }

            else   //hesabı yoksa
            {
                if (hesapTuru == "Vadeli")
                {
                    lblBakiyeVadeli.Text = " - ";
                    checkBox2Vadeli.Visible = false;
                }

                if (hesapTuru == "Vadesiz")
                {
                    lblBakiyeVadesiz.Text = " - ";
                    checkBoxVadesiz.Visible = false;
                }
            }

            connection.Close();

        }

        string secilenHesap = "";
        //------------------------------ PARA yatirma metodu ------------------------------------------

        void ParaYatir(decimal yatirilacakTutar)
        {

            DateTime Tarih = DateTime.Now;
            if (checkBoxVadesiz.Checked)
            {
                secilenHesap = "Vadesiz";
            }

            else if (checkBox2Vadeli.Checked)
            {
                secilenHesap = "Vadeli";
            }

            else
            {
                MessageBox.Show("Lütfen hesap türü seçiniz!");
                return;
            }

            connection.Open();

            // bakiye cekme
            SqlCommand bakiyeKomut = new SqlCommand("SELECT Bakiye FROM Hesap WHERE MusteriID=@musteriID AND HesapTuru=@hesapTuru", connection);
            bakiyeKomut.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
            bakiyeKomut.Parameters.AddWithValue("@hesapTuru", secilenHesap);

            object sonuc = bakiyeKomut.ExecuteScalar();
            decimal bakiye = Convert.ToDecimal(sonuc);

            // yeni bakiye
            decimal yeniBakiye = bakiye + yatirilacakTutar;

            SqlCommand komut = new SqlCommand("UPDATE Hesap SET Bakiye=@yeniBakiye WHERE MusteriID=@musteriID AND HesapTuru=@hesapTuru", connection);
            komut.Parameters.AddWithValue("@yeniBakiye", yeniBakiye);
            komut.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
            komut.Parameters.AddWithValue("@hesapTuru", secilenHesap);

            komut.ExecuteNonQuery();

            // 3) HesapHareketleri kaydı
            SqlCommand kaydetme = new SqlCommand("INSERT INTO HesapHareketleri (MusteriID,Tarih,Aciklama, Tutar, IslemTuru) values (@musteriID, @tarih, @aciklama, @tutar, @islemTuru)", connection);

            kaydetme.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
            kaydetme.Parameters.AddWithValue("@tarih", Tarih);
            kaydetme.Parameters.AddWithValue("@aciklama", "ATM PARA Yatırma");
            kaydetme.Parameters.AddWithValue("@tutar",yatirilacakTutar);
            kaydetme.Parameters.AddWithValue("@islemTuru", "Para Yatırma");

            kaydetme.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("İşlem başarıyla tamamlandı.");

            HesapGetir(secilenHesap);

            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }


        //----------------------------onayla butonu-----------------------
        private void button7_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                ParaYatir(tutar);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz!");
            }
        }

        //------------------diger---------------------
        private void button6_Click(object sender, EventArgs e)
        {
            lblTutar.Visible = true;
            txtTutar.Visible = true;
            btnOnayla.Visible = true;
        }

        //-----------------------------------------
        private void checkBoxVadesiz_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVadesiz.Checked)
            {
                checkBox2Vadeli.Checked = false;
            }
            groupBox1.BackColor = Color.White;
            groupBox2.BackColor = Color.WhiteSmoke;
        }

        private void checkBox2Vadeli_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2Vadeli.Checked)
            {
                checkBoxVadesiz.Checked = false;
            }
            groupBox2.BackColor = Color.White;
            groupBox1.BackColor = Color.WhiteSmoke;
        }


        //------------------------buton 100 -----------------------------------
        private void btn100_Click(object sender, EventArgs e)
        {
            ParaYatir(100);
        }

        //-----------------------------------------------------------------------------

        private void btn500_Click(object sender, EventArgs e)
        {
            ParaYatir(500);
        }

        //-----------------------------------------------------------

        private void btn200_Click(object sender, EventArgs e)
        {
            ParaYatir(200);
        }


        //-------------------------------------------------------------------

        private void btn1000_Click(object sender, EventArgs e)
        {
            ParaYatir(1000);
        }

        //-------------------------------------------------
        private void btn400_Click(object sender, EventArgs e)
        {
            ParaYatir(400);
        }


    }
}

