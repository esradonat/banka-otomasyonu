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
    public partial class _9_ParaTransferi : Form
    {
        public _9_ParaTransferi()
        {
            InitializeComponent();
        }

        private void _9_ParaTransferi_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer1.windowlessVideo = true;

            HesapGetir("Vadesiz");
            HesapGetir("Vadeli");

            txtTarih.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
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
            if (connection.State == ConnectionState.Closed)
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
            oku.Close();
            connection.Close();

        
        }
        //-------------------------------------PARA TRANSFER----------------------------------------------------------------------------

        string secilenHesap = "";
        void ParaTransfer(decimal transferTutar)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

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


            // bakiye cekme
            SqlCommand bakiyeKomut = new SqlCommand("select Bakiye from Hesap where MusteriID=@musteriID and HesapTuru=@hesapTuru", connection);

            bakiyeKomut.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
            bakiyeKomut.Parameters.AddWithValue("@hesapTuru", secilenHesap);

            decimal bakiye = Convert.ToDecimal(bakiyeKomut.ExecuteScalar());

            if (bakiye < transferTutar)
            {
                MessageBox.Show("Yetersiz bakiye!");
                return;
            }

            // gondren yeni bakiye
            decimal yeniBakiye = bakiye - transferTutar;

            SqlCommand komut = new SqlCommand("update Hesap SET Bakiye=@yeniBakiye where MusteriID=@musteriID and HesapTuru=@hesapTuru", connection);
            komut.Parameters.AddWithValue("@yeniBakiye", yeniBakiye);
            komut.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
            komut.Parameters.AddWithValue("@hesapTuru", secilenHesap);

            komut.ExecuteNonQuery();
            
            
            //alıcı yeni bakiye
            SqlCommand aliciBakiyeKomut = new SqlCommand("select Bakiye FROM Hesap where HesapID = @aliciHesapID", connection);
            aliciBakiyeKomut.Parameters.AddWithValue("@aliciHesapID", txtIbanAlici.Text);

            decimal aliciBakiye = Convert.ToDecimal(aliciBakiyeKomut.ExecuteScalar());
            decimal yeniAliciBakiye = aliciBakiye + transferTutar;

            SqlCommand aliciUpdate = new SqlCommand( "update Hesap SET Bakiye=@yeniBakiye where HesapID=@aliciHesapID",connection);
            aliciUpdate.Parameters.AddWithValue("@yeniBakiye", yeniAliciBakiye);
            aliciUpdate.Parameters.AddWithValue("@aliciHesapID", txtIbanAlici.Text);
            aliciUpdate.ExecuteNonQuery();

            MessageBox.Show("İşlem başarıyla tamamlandı.");

        }
        //------------------------------------ONAYLAMa----------------------------------------------------------------------------------------------------

        private void btnOnayla_Click(object sender, EventArgs e)
        {
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
                connection.Close();
                return;
            }
            
            string Aciklama = txtAcıklama.Text;
            DateTime Tarih = DateTime.Now;
            string aliciIban = txtIbanAlici.Text.Trim();
            
            connection.Open();

            // IBAN doğruluğunu kontrol et------------------------------------------
            
            SqlCommand ibanKontrolKomut = new SqlCommand( "select count(*) from Hesap where HesapID = @iban", connection);
            ibanKontrolKomut.Parameters.AddWithValue("@iban", aliciIban);
            int ibanVarMi = (int)ibanKontrolKomut.ExecuteScalar();

            if (ibanVarMi == 0)
            {
                MessageBox.Show("Girilen IBAN sistemde kayıtlı değil!");
                connection.Close();
                return;
            }

            //------------------------------------------------------------------
            if (decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                ParaTransfer(tutar);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz!");
                connection.Close();
                return;
            }


            //gonderen 
             //------------- HesapID sini diher yerlerde kullanmak için

            SqlCommand hesapkomut = new SqlCommand("select h.HesapID from Musteri m inner join Hesap h on m.MusteriID = h.MusteriID where m.MusteriID=@musteriID and h.HesapTuru=@hesapTuru", connection);
            hesapkomut.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
            hesapkomut.Parameters.AddWithValue("@hesapTuru", secilenHesap);
            object sonuc = hesapkomut.ExecuteScalar();

            if (sonuc == null)
            {
                MessageBox.Show("Gönderen hesap bulunamadı!");
                connection.Close();
                return;
            }
            string gonderenHesapID = sonuc.ToString();

            //-----------------------------------------------------

            // 3) HesapHareketleri kaydı
            SqlCommand komut = new SqlCommand("INSERT INTO HesapHareketleri (MusteriID, GonderenHesapID,AliciHesapID,Tarih,Aciklama, Tutar, IslemTuru) values (@musteriID, @gonderenHesapID, @aliciHesapID, @tarih, @aciklama, @tutar, @islemTuru)", connection);

            komut.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
            komut.Parameters.AddWithValue("@gonderenHesapID", gonderenHesapID);
            komut.Parameters.AddWithValue("@aliciHesapID", aliciIban);
            komut.Parameters.AddWithValue("@tarih", Tarih);
            komut.Parameters.AddWithValue("@aciklama", Aciklama);
            komut.Parameters.AddWithValue("@tutar", tutar);
            komut.Parameters.AddWithValue("@islemTuru", "Para Transferi");
            komut.ExecuteNonQuery();

            connection.Close();

            HesapGetir(secilenHesap);

            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }


        //------------------------------------------------------------------------------------------------------------------------
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
    }
}
