using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BankaOtomasyonu
{
    public partial class _4_HesapHareketlerii : Form
    {
        public _4_HesapHareketlerii()
        {
            InitializeComponent();
        }

        string secilenIslemTuru;
        decimal secilenTutar;
        string secilenAciklama;
        DateTime secilenTarih;
        private void _4_HesapHareketlerii_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.volume  = 0;  // SES KAPALI
            axWindowsMediaPlayer1.windowlessVideo = true;

            HesapHareketleriGoster(dtBaslangic.Value, dtBitis.Value);
        }
        SqlConnection connection = new SqlConnection("Data Source=ESRA\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuFinal;Integrated Security=True;TrustServerCertificate=True");

        //------------------------------------------------hesap hareketleri getirme----------------------------------------------------
        void HesapHareketleriGoster(DateTime baslangic, DateTime bitis)
        {
            pnlHareketler.Controls.Clear();
            connection.Open();

            SqlCommand komut = new SqlCommand(@"select h.Tarih, h.IslemTuru, h.Tutar, h.Aciklama, h.MusteriID AS GonderenMusteriID, ha.MusteriID as AliciMusteriID, m2.Ad + ' ' + m2.Soyad as AliciAdi , m3.Ad + ' ' + m3.Soyad as GonderenAdi
            from HesapHareketleri h
            left join Hesap ha on ha.HesapID = h.AliciHesapID
            left join Musteri m2 on ha.MusteriID = m2.MusteriID

            left join Hesap hg on hg.HesapID = h.GonderenHesapID
            left join Musteri m3 on hg.MusteriID = m3.MusteriID

            where ( h.MusteriID = @musteriID
            or ha.MusteriID = @musteriID)
            and h.Tarih between @baslangic and @bitis
            order by h.Tarih DESC", connection);

            komut.Parameters.AddWithValue("@musteriID", Program.AktifMusteriID);
            komut.Parameters.AddWithValue("@baslangic", baslangic);
            komut.Parameters.AddWithValue("@bitis", bitis);

            SqlDataReader oku = komut.ExecuteReader();

            int y = 10;

            while (oku.Read())
            {
                DateTime tarih = Convert.ToDateTime(oku["Tarih"]);
                string islemTuru = oku["IslemTuru"].ToString();
                string aciklama = oku["Aciklama"]?.ToString();
                decimal tutar = Convert.ToDecimal(oku["Tutar"]);
                int gonderenMusteri = Convert.ToInt32(oku["GonderenMusteriID"]);

                //------------alici
                int? aliciMusteri;

                if (oku["AliciMusteriID"] == DBNull.Value)
                {
                    aliciMusteri = null;
                }
                else
                {
                    aliciMusteri = Convert.ToInt32(oku["AliciMusteriID"]);
                }
                string aliciAdi = oku["AliciAdi"]?.ToString();

                //------------gonderen
                int? gonderen;

                if (oku["GonderenMusteriID"] == DBNull.Value)
                {
                    gonderen = null;
                }
                else
                {
                    gonderen = Convert.ToInt32(oku["GonderenMusteriID"]);
                }
                string gonderenAdi = oku["GonderenAdi"]?.ToString();


                //Satır paneli
                Panel satir = new Panel();
                satir.Width = pnlHareketler.Width - 30;
                satir.Height = 75;
                satir.Left = 10;
                satir.Top = y;
                satir.BackColor = Color.White;
                satir.BorderStyle = BorderStyle.FixedSingle;

                //Tarih
                Label lblTarih = new Label();
                lblTarih.Text = tarih.ToString("dd.MM.yyyy HH:mm");
                lblTarih.Left = 10;
                lblTarih.Top = 8;
                lblTarih.ForeColor = Color.Gray;

                //Açıklama
                Label lblAciklama = new Label();
                lblAciklama.Left = 10;
                lblAciklama.Top = 35;
                lblAciklama.Width = 420;
                lblAciklama.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                //Tutar
                Label lblTutar = new Label();
                lblTutar.Top = 25;
                lblTutar.Left = satir.Width - 150;
                lblTutar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblTutar.AutoSize = true;

                // renkler falan
                if (islemTuru == "Para Transferi")
                {
                    if (gonderenMusteri == Program.AktifMusteriID)
                    {
                        // BEN GÖNDERDİM
                        lblAciklama.Text = $"{aliciAdi} hesabına para transferi gerçekleşti";
                        lblTutar.Text = "-" + tutar + " TL";
                        lblTutar.ForeColor = Color.Red;
                    }
                    else
                    {
                        // BANA GELDİ
                        lblAciklama.Text = $"Gelen Transfer ← {gonderenAdi}";
                        lblTutar.Text = "+ " + tutar + " TL";
                        lblTutar.ForeColor = Color.Green;
                    }
                }

                if (islemTuru == "Para Çekme")
                {
                    lblAciklama.Text = islemTuru + " - " + aciklama;
                    lblTutar.Text = "- " + Math.Abs(tutar) + " TL";
                    lblTutar.ForeColor = Color.Red;
                }

                if (islemTuru == "Para Yatırma")
                {
                    lblAciklama.Text = islemTuru + " - " + aciklama;
                    lblTutar.Text = "+ " + tutar + " TL";
                    lblTutar.ForeColor = Color.Green;
                }

                if (islemTuru == "Faiz")
                {
                    lblAciklama.Text = islemTuru + " - " + aciklama;
                    lblTutar.Text = "+ " + Math.Abs(tutar) + " TL";
                    lblTutar.ForeColor = Color.Green;
                }


                // 🔹 Her satır için temp değişkenler
                var secilenIslemTuruTemp = islemTuru;
                var secilenTutarTemp = tutar;
                var secilenAciklamaTemp = aciklama;
                var secilenTarihTemp = tarih;

                // 🔹 Dekont ikonu
                PictureBox btnDekont = new PictureBox
                {
                    Image = Image.FromFile(@"C:\Users\monster\Downloads\google-forms.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 30,
                    Height = 30,
                    Left = lblTutar.Left + lblTutar.Width + 13,
                    Top = lblTutar.Top,
                    Cursor = Cursors.Hand
                };

                btnDekont.Click += (s, e) =>
                {
                    // 🔹 Temp değişkenleri kullan
                    secilenIslemTuru = secilenIslemTuruTemp;
                    secilenTutar = secilenTutarTemp;
                    secilenAciklama = secilenAciklamaTemp;
                    secilenTarih = secilenTarihTemp;

                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                };

                satir.Controls.Add(lblTarih);
                satir.Controls.Add(lblAciklama);
                satir.Controls.Add(lblTutar);
                satir.Controls.Add(btnDekont);
                pnlHareketler.Controls.Add(satir);

                y += 85;
            }

            connection.Close();
        }
        
      

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dtBaslangic.Value.Date;
            DateTime bitis = dtBitis.Value.Date.AddDays(1).AddSeconds(-1);

            HesapHareketleriGoster(baslangic, bitis);
        }



              //-------------------dekont yazdırma
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Font baslik = new Font("Segoe UI", 14, FontStyle.Bold);
            Font normal = new Font("Segoe UI", 10);
            int y = 50;

            e.Graphics.DrawString("BANKA DEKONTU", baslik, Brushes.Black, 250, y);
            y += 40;

            e.Graphics.DrawString("Müşteri ID: " + Program.AktifMusteriID, normal, Brushes.Black, 50, y);
            y += 25;

            e.Graphics.DrawString("Tarih: " + secilenTarih.ToString("dd.MM.yyyy HH:mm"), normal, Brushes.Black, 50, y);
            y += 30;

            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            y += 20;

            e.Graphics.DrawString("İşlem Türü: " + secilenIslemTuru, normal, Brushes.Black, 50, y);
            y += 25;

            e.Graphics.DrawString("Tutar: " + secilenTutar + " TL", normal, Brushes.Black, 50, y);
            y += 25;

            e.Graphics.DrawString("Açıklama: " + secilenAciklama, normal, Brushes.Black, 50, y);
            y += 40;

            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            y += 30;

            e.Graphics.DrawString("Bu belge elektronik olarak oluşturulmuştur.",
                normal, Brushes.Gray, 50, y);
        }
    }
}
