using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;
using System.Data.OleDb;
using System.Runtime.InteropServices.WindowsRuntime;
using FacadeLayer;

namespace PresentationLayer
{
    public partial class KitapForm : Form
    {
        public KitapForm()
        {
            InitializeComponent();
        }
        //KİTAP EKLE İŞLEMİNİ YAPIYORUZ.
        private void btn_kitapekle_Click(object sender, EventArgs e)
        {//KİTAPLARIMIZI VERİTABANINA KAYDETTİĞİMİZ YER
            EntityKitap ent = new EntityKitap();
            ent.Kitap_ad = txt_kitap_ad.Text;
            ent.Kitap_sayfasayisi = Convert.ToInt16(txt_kitap_sayfasayisi.Text);
            ent.Yazar_ad = txt_yazar_ad.Text;
            ent.Tur_ad = txt_tur_ad.Text;
            ent.Kitap_yayimevi = txt_kitap_yayimevi.Text;

            BLKitap.BlKitapEkle(ent);
            MessageBox.Show("Ekleme İşlemi Yapıldı!");
            KitapListele();
            //TEXTBOXLARIMIZI TEMİZLEDİĞİMİZ YER
            txt_kitap_ad.Clear();
            txt_kitap_sayfasayisi.Clear();
            txt_kitap_yayimevi.Clear();
            txt_tur_ad.Clear();
            txt_yazar_ad.Clear();
            lbl_kitap_ID.Text = "";
            txt_silinecek_kitap.Text = "";
            txt_kitap_ad.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //KİTAP BİLGİLERİNİ GÜNCELLEME İŞLEMİNİ YAPIYORUZ
        private void btn_guncelle_Click(object sender, EventArgs e)
        {//EKLEMEYLE ÇOK YAKIN KODLAR VERİLERİMİZİ GÜNCELLEMEYİ SAĞLIYOR.
            EntityKitap ent = new EntityKitap();
            ent.Kitap_ad = txt_kitap_ad.Text;
            ent.Kitap_sayfasayisi = Convert.ToInt16(txt_kitap_sayfasayisi.Text);
            ent.Yazar_ad = txt_yazar_ad.Text;
            ent.Tur_ad = txt_tur_ad.Text;
            ent.Kitap_yayimevi = txt_kitap_yayimevi.Text;
            ent.Kitap_id = Convert.ToInt16(lbl_kitap_ID.Text);

            BLKitap.BlKitapGuncelle(ent);
            MessageBox.Show("Güncelleme İşlemi Yapıldı!");
            KitapListele();
            txt_kitap_ad.Clear();
            txt_kitap_sayfasayisi.Clear();
            txt_kitap_yayimevi.Clear();
            txt_tur_ad.Clear();
            txt_yazar_ad.Clear();
            lbl_kitap_ID.Text = "";
            txt_silinecek_kitap.Text = "";
            txt_kitap_ad.Focus();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {
            //LİSTELEME FONSİYONUMUZ
            KitapListele();

        }

        //LİSTELEME İŞLEMİMİZİ YAPIYORUZ.
        public void KitapListele()
        {
            //KİTAPLARI ÇEKEN SORGUMUZ
            string sorgu = "SELECT * FROM Kitap";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, AccessDBConnect.baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "Kitap");
            AccessDBConnect.baglanti.Close();
            //DATASETDE NORMALDE OLMAYAN BİR TABLO OLUŞTURUP GELEN DEĞERLERİ GÖNDERİP GRİDVİEWDE GÖSTERİYORUZ.
            dGV_kitap.DataSource = ds.Tables["Kitap"];

        }
        //PENCERE KAPANDIGINDA TEKRARDAN MAİN AÇILMASINI SAĞLAMAK İÇİN YAZDIK.
        private void KitapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main frm = new Main();
            frm.Show();
        }
        //TABLOMUZDAKİ VERİLERDEN BİRİNE TIKLADIĞIMIZDA YUKARIDAKİ TEXTBOXLARA GÖNDERİYORUZ.
        private void dGV_kitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dGV_kitap.SelectedCells[0].RowIndex;
            string kitap_id = dGV_kitap.Rows[secilialan].Cells[0].Value.ToString();
            string kitap_ad = dGV_kitap.Rows[secilialan].Cells[1].Value.ToString();
            string kitap_sayfasayisi = dGV_kitap.Rows[secilialan].Cells[2].Value.ToString();
            string yazar_ad = dGV_kitap.Rows[secilialan].Cells[3].Value.ToString();
            string tur_ad = dGV_kitap.Rows[secilialan].Cells[4].Value.ToString();
            string kitap_yayimevi = dGV_kitap.Rows[secilialan].Cells[5].Value.ToString();
            string kitap_durum = dGV_kitap.Rows[secilialan].Cells[6].Value.ToString();

            txt_kitap_ad.Text = kitap_ad;
            txt_kitap_sayfasayisi.Text = kitap_sayfasayisi;
            txt_yazar_ad.Text = yazar_ad;
            txt_tur_ad.Text = tur_ad;
            txt_kitap_yayimevi.Text = kitap_yayimevi;
            lbl_kitap_ID.Text = kitap_id;
            txt_silinecek_kitap.Text = kitap_id;
            lbl_gizli.Text = kitap_durum;

        }
        //KİTABIMIZI VERİ TABANINDAN SİLMEMİZİ SAĞLAYAN KODLAR
        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            if (lbl_gizli.Text == "0")
            {
                try
                {
                    BLKitap.BlKitapSil(Convert.ToInt16(txt_silinecek_kitap.Text));
                    MessageBox.Show("Kitap silinmiştir !!!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Kitap şuan bakıma yollandığı için silinemiyor");

                }
            }
            else if (lbl_gizli.Text == "1")
            {
                MessageBox.Show("Kitap geri alınmadığı için silinemez!");

            }

            //TEMİZLİK KODLARIMIZ
            KitapListele();
            txt_silinecek_kitap.Clear();
            txt_kitap_ad.Clear();
            txt_kitap_sayfasayisi.Clear();
            txt_kitap_yayimevi.Clear();
            txt_tur_ad.Clear();
            txt_yazar_ad.Clear();
            lbl_kitap_ID.Text = "";

            txt_kitap_ad.Focus();
        }

        //int değişkeni olduğu için textbox'a sadece rakam girilmesi için yapılmıştır.
        private void txt_kitap_sayfasayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
