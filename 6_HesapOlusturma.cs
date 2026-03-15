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
    public partial class HesapOlusturma : Form
    {
        public HesapOlusturma()
        {
            InitializeComponent();
        }

        private void HesapOlusturma_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer1.windowlessVideo = true;
        }

        decimal? faizOrani = null;
        DateTime? vadeBaslangic = null;
        DateTime? vadeBitis = null;
        DateTime? sonFaizHesaplama = null;

        string ibanUret()
        {
            Random rastgele = new Random();
            string iban = "TR";

            for (int i = 0; i < 24; i++)
            {
                iban += rastgele.Next(0, 10).ToString();
            }

            return iban;
        }

        SqlConnection connection = new SqlConnection("Data Source=ESRA\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuFinal;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {

            string hesapID = ibanUret();
            string hesapTuru = "";
            decimal bakiye;
            int musteriID = Program.AktifMusteriID;

            if (!decimal.TryParse(textBox1.Text, out bakiye))
            {
                MessageBox.Show("Lütfen geçerli bir bakiye giriniz!");
                return;
            }
            if (musteriID == 0)
            {
                MessageBox.Show("Oturum hatası .Lütfen tekrar giriş yapın.");
                return;
            }

            if (checkBox1.Checked)
            {
                hesapTuru = "Vadeli";
                faizOrani = 0.35m;
                vadeBaslangic = DateTime.Now;
                vadeBitis = DateTime.Now.AddMonths(1);
                sonFaizHesaplama = DateTime.Now;

            }

            else if (checkBox2.Checked)
            {
                hesapTuru = "Vadesiz";
                faizOrani = null;
                vadeBaslangic = null;
                vadeBitis = null;
                sonFaizHesaplama = null;
            }

            else
            {
                MessageBox.Show("Lütfen hesap türü seçiniz!");
                return;
            }

            //------------------------aynı hesaptan varsa sınırlandırma
            connection.Open();

            SqlCommand kontrol = new SqlCommand(
            "SELECT COUNT(*) FROM Hesap WHERE MusteriID=@mid AND HesapTuru=@tur", connection);

            kontrol.Parameters.AddWithValue("@mid", musteriID);
            kontrol.Parameters.AddWithValue("@tur", hesapTuru);

            int varMi = (int)kontrol.ExecuteScalar();

            connection.Close();

            if (varMi > 0)
            {
                MessageBox.Show("Bu hesap türünden zaten bir hesabınız var!");
                return;
            }

            //----------------------------------------------------


            connection.Open();
            SqlCommand command = new SqlCommand("insert into Hesap " +
            "(HesapID, MusteriID, HesapTuru, Bakiye, FaizOrani, VadeBaslangic, VadeBitis, SonFaizHesaplama) " +
            "values (@HesapID, @MusteriID, @HesapTuru, @Bakiye,  @FaizOrani, @VadeBaslangic, @VadeBitis, @SonFaizHesaplama)", connection);
            command.Parameters.AddWithValue("@HesapID", hesapID);
            command.Parameters.AddWithValue("@MusteriID", musteriID);
            command.Parameters.AddWithValue("@HesapTuru", hesapTuru);
            command.Parameters.AddWithValue("@Bakiye", bakiye);
            //faiz
            command.Parameters.AddWithValue("@FaizOrani", (object)faizOrani ?? DBNull.Value);
            command.Parameters.AddWithValue("@VadeBaslangic", (object)vadeBaslangic ?? DBNull.Value);
            command.Parameters.AddWithValue("@VadeBitis", (object)vadeBitis ?? DBNull.Value);
            command.Parameters.AddWithValue("@SonFaizHesaplama", (object)sonFaizHesaplama ?? DBNull.Value);

            command.ExecuteNonQuery();

            MessageBox.Show("Hesap başarıyla oluşturuldu!");

            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();

            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            _5_TumIslemler yeni = new _5_TumIslemler();
            yeni.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
