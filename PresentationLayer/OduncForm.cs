using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using FacadeLayer;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class OduncForm : Form 
    {
        public OduncForm()
        {
            InitializeComponent();
        }

        private void gb_odunckitapver_Enter(object sender, EventArgs e)
        {

        }
        //Açılan pencere kapandıgında tekrardan main açılmas için yazdık.
        private void OduncForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main frm = new Main();
            frm.Show();
        }
        //form acıldıgında tablomuza listeleme yapması için yazdık
        private void OduncForm_Load(object sender, EventArgs e)
        {
            OduncListele();
            cbxDoldur();

        }
        //listeme işlemini yaptık
        public void OduncListele()
        {

            string sorgu = "SELECT * FROM Islem";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, AccessDBConnect.baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "Islem");
            AccessDBConnect.baglanti.Close();
            dgw_odunc.DataSource = ds.Tables["Islem"];

            //tablomuzdaki satırları renklendirdiğimiz yer.
            DateTime NormalTeslimTarihi = DateTime.Now;
            int teslimDurum ;

            for (int i = 0; i < dgw_odunc.RowCount; i++)
            {//kitap teslimine göre renklendiriyoruz.
                NormalTeslimTarihi = Convert.ToDateTime(dgw_odunc.Rows[i].Cells[3].Value);
                teslimDurum =Convert.ToInt16(dgw_odunc.Rows[i].Cells[5].Value);
                int gun = ((((Convert.ToInt32(NormalTeslimTarihi.Date.Day.ToString()))-Convert.ToInt32(DateTime.Now.Day.ToString())) ));
                Application.DoEvents();
                DataGridViewCellStyle rowColor = new DataGridViewCellStyle();

                
                dgw_odunc.Rows[i].DefaultCellStyle = rowColor;


                //Teslim edilmişse yeşile boyuyoruz
                if (teslimDurum == 0)
                {
                    rowColor.BackColor = Color.Green;
                }
                 //Teslim edilmemişse kırmızı ve teslim gününe 2 gün kaldıgında sarı ve teslim durumuna daha cok var oldugu zaman için ise satırlarımızı aqua rengine bürüyoruz.
                else
                {
                    if (gun < 0 )
                    {
                        rowColor.BackColor = Color.Red;// kitap gecikmiş
                    }
                    else if ( gun > 0 && gun<3 )
                    {
                        rowColor.BackColor = Color.Yellow; //2 veya daha az günü kalmış
                    }
                    else 
                    {
                        rowColor.BackColor = Color.Aqua; //daha teslim etmesine var
                    }
                }



            }


        }

        
        //comboboxımıı doldurdugumuz yer. veritabanından kitapları cektik.
        public void cbxDoldur()
        {
            List<EntityKitap> Kitap = BLKitap.BlKitapListele();
            cbxKitaplar.ValueMember = "kitap_id";
            cbxKitaplar.DisplayMember = "kitap_ad";
            cbxKitaplar.DataSource = Kitap;

        }
        //odunc ver için gerekli bilgileri veritabanına aktardığımız yer.
        private void btn_oduncver_Click(object sender, EventArgs e)
        {
            try
            {
                EntityIslem ent= new EntityIslem();
                ent.Ogrenci_id = Convert.ToInt16(txt_oduncver_ogr_id.Text);
                ent.Kitap_id = Convert.ToInt16(cbxKitaplar.SelectedValue);
                ent.Alis_tarih = Convert.ToDateTime(dtp_oduncver_alistarihi.Text);
                ent.Veris_tarih = Convert.ToDateTime(dtp_oduncver_veristarih.Text);
                
                BLIslem.BlOduncVer(ent);
                OduncListele();
            }
            catch (Exception )
            {
                MessageBox.Show("Verdiğiniz Id de öğrenci bulunmamaktadır");
            }
            


        }
        //kitabı ödünç aldığımız işlem
        private void btn_oduncal_Click(object sender, EventArgs e)
        {
            EntityIslem ent = new EntityIslem();
            ent.Ogrenci_id = Convert.ToInt16(txt_odunc_gerial_ogr_id.Text);
            ent.Kitap_id = Convert.ToInt16(txt_odunc_gerial_kitapadi.Text);
            ent.Alis_tarih = Convert.ToDateTime(dtp_oduncal_alistarihi.Text);

            BLIslem.BlGeriAl(ent);
            OduncListele();
            int ceza=Cezahesapla();
            FacadeOgrenci.CezaYaz(txt_odunc_gerial_ogr_id.Text, ceza);


        }
        //ceza hesaplanan fonsiyonumuz geciken her güne 1 tl kesiyor
        //1 ile çarpmaya gerek olmadıgı için sadece cıkartma yaptık
        public int Cezahesapla()
        {

            int ceza = (Convert.ToInt32(dtp_oduncal_alistarihi.Value.Day.ToString())-Convert.ToInt32(dtp_oduncver_veristarih.Value.Day.ToString()));
            
            return ceza;
        }
        //tablodaki bilgilere tıklandıgında verilerin textboxlara gelmesini sağlayan kod satırımız
        public void dgw_odunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dgw_odunc.SelectedCells[0].RowIndex;
            string ogrId = dgw_odunc.Rows[secilialan].Cells[1].Value.ToString();
            string kitapId = dgw_odunc.Rows[secilialan].Cells[2].Value.ToString();
            string geriAlinmaTarih = dgw_odunc.Rows[secilialan].Cells[3].Value.ToString();
            string verilmeTarih= dgw_odunc.Rows[secilialan].Cells[4].Value.ToString();

            dtp_oduncver_veristarih.Text = verilmeTarih;
            txt_odunc_gerial_ogr_id.Text = ogrId;
            txt_oduncuzat_ogr_id.Text = ogrId;
            txt_odunc_gerial_kitapadi.Text = kitapId;
            txt_oduncuzat_kitapadi.Text = kitapId;
            txt_oduncver_ogr_id.Text = ogrId;
            dtp_oduncal_alistarihi.Text = geriAlinmaTarih;
            btn_oduncal.Visible = true; // ilk önce kitap alınmasını sağlamak için ödünc al ve uzatı gizledik.
            btn_oduncuzat.Visible = true;

        }
        //kitabı vereceğimiz süreyi uzatıyoruz
        private void btn_oduncuzat_Click(object sender, EventArgs e)
        {
            EntityIslem ent = new EntityIslem();
            ent.Ogrenci_id = Convert.ToInt16(txt_oduncuzat_ogr_id.Text);
            ent.Kitap_id = Convert.ToInt16(txt_oduncuzat_kitapadi.Text);
            ent.Alis_tarih = Convert.ToDateTime(txt_oduncuzat_tarih.Text);
            BLIslem.BlKitapTarihUzat(ent);
            OduncListele();

        }
        
        private void dgw_odunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
