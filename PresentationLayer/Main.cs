using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_kitap_Click(object sender, EventArgs e)
        {   // ALTTAKİLER DE DAHİL OLMAK ÜZERE KAPATMA BUTONUNA BASTIĞIMIZDA TEKRARDAN MAİN (ANASAYFA) YA DÖNMEMİZİ SAĞLAYAN KODLARIMIZ.
            KitapForm frm = new KitapForm();
            this.Hide();
            frm.Show();
            //FORMUN TEXTİNİ DEĞİŞTİRMEK İÇİN YAZDIK.
            frm.Text = "Kitap İşlemleri";


        }

        private void btn_ogrenci_Click(object sender, EventArgs e)
        {
            OgrenciForm frm = new OgrenciForm();
            this.Hide();
            frm.Show();
            frm.Text = "Öğrenci İşlemleri";
        }

        private void btn_odunc_Click(object sender, EventArgs e)
        {
            OduncForm frm = new OduncForm();
            this.Hide();
            frm.Show();
            frm.Text = "Ödünç İşlemleri";
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            AramaForm frm = new AramaForm();
            this.Hide();
            frm.Show();
            frm.Text = "Arama İşlemleri";
        }

        private void btn_grafik_Click(object sender, EventArgs e)
        {
            GrafikForm frm = new GrafikForm();
            this.Hide();
            frm.Show();
            frm.Text = "Giriş İşlemleri";
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        //MOUSE GELİNCE RENKLENDİRME YAPMAK İÇİN YAZDIK.
        private void btn_kitap_MouseHover(object sender, EventArgs e)
        {
            btn_kitap.BackColor = Color.Turquoise;
        }

        private void btn_ogrenci_MouseHover(object sender, EventArgs e)
        {
            btn_ogrenci.BackColor = Color.Turquoise;
        }

        private void btn_odunc_MouseHover(object sender, EventArgs e)
        {
            btn_odunc.BackColor = Color.Turquoise;
        }

        private void btn_arama_MouseHover(object sender, EventArgs e)
        {
            btn_arama.BackColor = Color.Turquoise;
            ;
        }

        private void btn_grafik_MouseHover(object sender, EventArgs e)
        {
            btn_grafik.BackColor = Color.Turquoise;
        }

        private void btn_cikis_MouseHover(object sender, EventArgs e)
        {
            btn_cikis.BackColor = Color.Red;
        }

        private void btn_kitap_MouseMove(object sender, MouseEventArgs e)
        {
            btn_kitap.BackColor = Color.PowderBlue;
        }

        private void btn_ogrenci_MouseMove(object sender, MouseEventArgs e)
        {
            btn_ogrenci.BackColor = Color.PowderBlue;
        }

        private void btn_odunc_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btn_odunc_MouseMove(object sender, MouseEventArgs e)
        {
            btn_odunc.BackColor = Color.PowderBlue;
        }

        private void btn_arama_MouseMove(object sender, MouseEventArgs e)
        {
            btn_arama.BackColor = Color.PowderBlue;
        }

        private void btn_grafik_MouseMove(object sender, MouseEventArgs e)
        {
            btn_grafik.BackColor = Color.PowderBlue;
        }

        private void btn_cikis_MouseMove(object sender, MouseEventArgs e)
        {
            btn_cikis.BackColor = Color.PowderBlue;
        }
    }
}
