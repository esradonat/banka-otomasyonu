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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true; 
            axWindowsMediaPlayer1.settings.volume = 0;  
            axWindowsMediaPlayer1.windowlessVideo = true;

            // Paneli yuvarlak yapma
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, panel1.Width - 1, panel1.Height - 1);
            panel1.Region = new Region(gp);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 yeni = new Form2(); //kayıt sayfası
            yeni.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {         
            SqlConnection connection = new SqlConnection("Data Source=ESRA\\SQLEXPRESS;Initial Catalog=BankaOtomasyonuFinal;Integrated Security=True;TrustServerCertificate=True");

            connection.Open();

            SqlCommand command = new SqlCommand("select MusteriID from Musteri where Ad = @Ad and Soyad = @Soyad and Sifre = @Sifre", connection);

            command.Parameters.AddWithValue("@Ad", textBox1.Text);
            command.Parameters.AddWithValue("@Soyad", textBox2.Text);
            command.Parameters.AddWithValue("@Sifre", textBox3.Text);


            SqlDataReader oku = command.ExecuteReader();

            if (oku.Read())
            {
                int musteriID = Convert.ToInt32(oku["MusteriID"]);
                Program.AktifMusteriID = musteriID;
                MessageBox.Show("Giriş başarılı ");

                Form3 yeni = new Form3();
                yeni.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Ad, soyad veya şifre hatalı!");
            }

            connection.Close();




        }
    }
}
