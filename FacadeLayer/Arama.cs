using System.Data;
using System.Data.OleDb;

namespace FacadeLayer
{//SQL İŞLEMLERİMİZ FACEDE KATMANINDA YAPTIK.
    public class Arama
    {
        //Arama işlemimizi yapıyoruz.
        //Dönen değeri datatableye atıp returnlüyoruz.

        public static DataTable KitapArama(string deger)
        {

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Islem WHERE  kitap_id like '%" + deger + "%' ", AccessDBConnect.baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt); //Sql komutumuzdan gelen değeri datatable'ye atıyor
            return dt;
        }
        public static DataTable OgrenciArama(string deger)
        {

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Islem WHERE ogrenci_id like '%" + deger + "%' ", AccessDBConnect.baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
    }
}
