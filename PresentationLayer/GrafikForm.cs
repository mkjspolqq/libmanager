using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Data.OleDb;
using FacadeLayer;
using PresentationLayer;
using BusinessLogicLayer;


namespace PresentationLayer
{
    public partial class GrafikForm : Form
    {
        public GrafikForm()
        {
            InitializeComponent();
        }

        private void GrafikForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main frm = new Main();
            frm.Show();
        }

        private void GrafikForm_Load(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            AccessDBConnect.baglanti.Open();
            komut.Connection = AccessDBConnect.baglanti;

            // grafik gösterilecek grafikler tanımlanıyor          
            int toplamKitap = 0;
            int toplamUye = 0;
            int kbulunanK = 0;
            int kOlmayanK = 0;

            // sorgular yapılıyor
            string Kitapsayisi = "select count(*) as say from Kitap";
            string UyeSayisi = "select count(*) as say from Ogrenci";
            string KBKitapSayisi = "select count(*) as say from Islem WHERE teslim_durumu=" + 0 + "";
            string KOKitapSayisi = "select count(*) as say from Islem WHERE teslim_durumu=" + 1 + "";

            komut.CommandText = Kitapsayisi;
            IDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                toplamKitap = Convert.ToInt32(dr["say"]);
            }
            KitapsayisiGrafik = zedGraphControl1.GraphPane;
            double[] x = new double[1];
            double[] y = new double[100];
            for (int i = 0; i < x.Length; i++)
            {

                x[i] = i;
                y[i] = Convert.ToDouble(toplamKitap);
            }
            PointPairList grf = new PointPairList(x, y);
            LineItem egim = KitapsayisiGrafik.AddCurve("Kitap Sayısı", grf, Color.Red, SymbolType.Star);
            egim.Line.Width = 10.0F;

            dr.Dispose();
            dr.Close();
            // uye sayısı hesaplanıyor
            komut.CommandText = UyeSayisi;
            IDataReader dr2 = komut.ExecuteReader();

            while (dr2.Read())
            {
                toplamUye = Convert.ToInt32(dr2["say"]);
            }
            UyesayisiGrafik = zedGraphControl1.GraphPane;

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                y[i] = Convert.ToDouble(toplamUye);
            }
            PointPairList grf1 = new PointPairList(x, y);
            LineItem egim1 = UyesayisiGrafik.AddCurve("Üye Sayısı", grf1, Color.Green, SymbolType.Square);
            egim1.Line.Width = 10.0F;

            dr2.Dispose();
            dr2.Close();
            //kitap sayısı hesaplanıyor
            komut.CommandText = KBKitapSayisi;
            IDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                kbulunanK = Convert.ToInt32(dr3["say"]);
            }

            KBKitapSayisiGrafik = zedGraphControl1.GraphPane;

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                y[i] = Convert.ToDouble(kbulunanK);
            }
            PointPairList grf2 = new PointPairList(x, y);
            LineItem egim2 = KBKitapSayisiGrafik.AddCurve("Kütütüphanedeki Kitap Sayısı", grf2, Color.Sienna, SymbolType.Circle);
            egim2.Line.Width = 10.0F;
            dr3.Dispose();
            dr3.Close();

            komut.CommandText = KOKitapSayisi;
            IDataReader dr4 = komut.ExecuteReader();

            while (dr4.Read())
            {
                kOlmayanK = Convert.ToInt32(dr4["say"]);
            }
            KOKitapSayisiGrafik = zedGraphControl1.GraphPane;

            for (int i = 0; i < x.Length; i++)
            {

                x[i] = i;
                y[i] = Convert.ToDouble(kOlmayanK);
            }
            PointPairList grf3 = new PointPairList(x, y);
            LineItem egim3 = KOKitapSayisiGrafik.AddCurve("Kütüphanede Olmayan Kitap Sayısı", grf3, Color.Aqua, SymbolType.Diamond);
            egim3.Line.Width = 10.0F;

            KitapsayisiGrafik.Title.Text = "Kütüphane İstatistikleri";
            KitapsayisiGrafik.XAxis.Title.Text = "";
            KitapsayisiGrafik.YAxis.Title.Text = "Toplam Miktar";
            KOKitapSayisiGrafik = zedGraphControl1.GraphPane;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }
        GraphPane KitapsayisiGrafik, UyesayisiGrafik, KBKitapSayisiGrafik, KOKitapSayisiGrafik;
        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            
        }

    }
}

