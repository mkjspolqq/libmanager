using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;
using System.Data.OleDb;
using FacadeLayer;

namespace PresentationLayer
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {

            OgrenciListele();
        }

        private void OgrenciForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main frm = new Main();
            frm.Show();
        }

        private void btn_ogrenciekle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ogrenci_ad = txt_ogrenci_ad.Text;
            ent.Ogrenci_soyad = txt_ogrenci_soyad.Text;
            ent.Ogrenci_email = txt_ogrenci_mail.Text;
            ent.Ogrenci_dtarihi = Convert.ToDateTime(txt_ogrenci_dogumt.Text);
            ent.Ogrenci_borc = Convert.ToInt16(lbl_ogrenci_borc.Text);

            BLOgrenci.BlOgrenciEkle(ent);
            MessageBox.Show("Ekleme İşlemi Yapıldı!");
            OgrenciListele();


            lbl_ogrenci_borc.Text = "0";
            txt_ogrenci_mail.Clear();
            txt_ogrenci_ad.Clear();
            txt_ogrenci_soyad.Clear();
            lbl_ogrenci_ID.Text = "";
            txt_ogrenci_ad.Focus();
        }

        private void btn_ogrenciguncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ogrenci_ad = txt_ogrenci_ad.Text;
            ent.Ogrenci_soyad = txt_ogrenci_soyad.Text;
            ent.Ogrenci_email = txt_ogrenci_mail.Text;
            ent.Ogrenci_dtarihi = Convert.ToDateTime(txt_ogrenci_dogumt.Text);
            ent.Ogrenci_borc = Convert.ToInt16(lbl_ogrenci_borc.Text);
            ent.Ogrenci_id = Convert.ToInt16(lbl_ogrenci_ID.Text);

            BLOgrenci.BlOgrenciGuncelle(ent);
            MessageBox.Show("Güncelleme İşlemi Yapıldı!");
            OgrenciListele();
        }

        public void OgrenciListele()
        {

            string sorgu = "SELECT * FROM Ogrenci";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, AccessDBConnect.baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "Ogrenci");
            AccessDBConnect.baglanti.Close();
            dGV_ogrenci.DataSource = ds.Tables["Ogrenci"];

        }

        private void dGV_ogrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dGV_ogrenci.SelectedCells[0].RowIndex;
            string Ogrenci_id = dGV_ogrenci.Rows[secilialan].Cells[0].Value.ToString();
            string Ogrenci_ad = dGV_ogrenci.Rows[secilialan].Cells[1].Value.ToString();
            string Ogrenci_soyad = dGV_ogrenci.Rows[secilialan].Cells[2].Value.ToString();
            string Ogrenci_email = dGV_ogrenci.Rows[secilialan].Cells[3].Value.ToString();
            string Ogrenci_dtarihi = dGV_ogrenci.Rows[secilialan].Cells[4].Value.ToString();
            string Ogrenci_borc = dGV_ogrenci.Rows[secilialan].Cells[5].Value.ToString();
            

            lbl_ogrenci_ID.Text = Ogrenci_id;
            txt_ogrenci_ad.Text = Ogrenci_ad;
            txt_ogrenci_soyad.Text = Ogrenci_soyad;
            txt_ogrenci_mail.Text = Ogrenci_email;
            txt_ogrenci_dogumt.Text = Ogrenci_dtarihi;
            lbl_ogrenci_borc.Text = Ogrenci_borc;
            txt_silinecek_ID.Text = Ogrenci_id;
            lbl_gizli.Text = Ogrenci_borc;
            lbl_ogrenci_borc_id.Text = Ogrenci_id;
            lbl_borc.Text = Ogrenci_borc;

        }

        private void btn_ogrencisil_Click(object sender, EventArgs e)
        {

            try
            {
                BLOgrenci.BlOgrenciSil(Convert.ToInt16(txt_silinecek_ID.Text));

            }
            catch (Exception )
            {
                MessageBox.Show("Öğrenci daha önceden kitap aldığı için veri tabanından silinemiyor");
            }
            

            OgrenciListele();


            txt_silinecek_ID.Clear();
            lbl_ogrenci_borc.Text = "0";
            txt_ogrenci_mail.Clear();
            txt_ogrenci_ad.Clear();
            txt_ogrenci_soyad.Clear();
            lbl_ogrenci_ID.Text = "";
            lbl_ogrenci_borc_id.Text = "";
            txt_ogrenci_ad.Focus();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //
        private void btn_borc_ode_Click(object sender, EventArgs e)
        {
            if (lbl_borc.Text != "0")
            {
                EntityOgrenci ent =new EntityOgrenci();
                ent.Ogrenci_id = Convert.ToInt16(lbl_ogrenci_ID.Text);
                ent.Ogrenci_borc = Convert.ToInt16(lbl_borc.Text);
                try
                {
                    BLOgrenci.BlBorcOde(ent);
                    MessageBox.Show("Borcunuz ödenmiştir. Teşekkür Ederiz!");
                    OgrenciListele();

                }
                catch (Exception)
                {
                    MessageBox.Show("Paranız yeterli değil :");

                }
            }
            else if (lbl_borc.Text == "0")
            {
                MessageBox.Show("Borcunuz bulunmamatadır!");

            }






        }

        private Label GetLbl_borc()
        {
            return lbl_borc;
        }

        //sadece sayısal deger girmemizi sağlamak amacıyla hatayı önlemek icin yazdık.
        private void txt_silinecek_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
