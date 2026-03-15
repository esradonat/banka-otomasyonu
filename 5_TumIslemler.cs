using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class _5_TumIslemler : Form
    {
        public _5_TumIslemler()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void _5_TumIslemler_Load(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.URL = "C:\\Users\\monster\\Downloads\\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.volume = 0;
            axWindowsMediaPlayer1.windowlessVideo = true;

        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            HesapOlusturma yeni = new HesapOlusturma();
            yeni.Show();
            this.Hide();
        }

        private void btnParaYatirma_Click(object sender, EventArgs e)
        {
            _8_ParaYatirma yeni = new _8_ParaYatirma();
            yeni.Show();
            this.Hide();
        }

        private void btnParaCekme_Click(object sender, EventArgs e)
        {
            _7_ParaCekme yeni = new _7_ParaCekme();
            yeni.Show();
            this.Hide();
        }

        private void btnParaTransferi_Click(object sender, EventArgs e)
        {
            _9_ParaTransferi yeni = new _9_ParaTransferi();
            yeni.Show();
            this.Hide();
        }

        private void btnSifreDegistirme_Click(object sender, EventArgs e)
        {
           SifreDegistirme yeni = new SifreDegistirme();
            yeni.Show();
            this.Hide();
        }

    }
}
