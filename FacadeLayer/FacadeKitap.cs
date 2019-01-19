using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace FacadeLayer
{   //Diğer katmanlardan ve sınıflardan erişebilmek için Public yaptık.

    public class FacadeKitap
    {   //Kitap eklediğimiz fonsiyonumuzdur.
        public static int KitapEkle(EntityKitap deger)
        {   //Kitap ekle sorgusu.
            string sorgu = "INSERT INTO Kitap (kitap_ad,kitap_sayfasayisi,yazar_ad,tur_ad,kitap_yayimevi,kitap_durumu)" +
                           "VALUES (@kitap_ad,@kitap_sayfasayisi,@yazar_ad,@tur_ad,@kitap_yayimevi,@kitap_durumu)";
            //Komutu oluşturduk komuta üsteki sorguyu ve access bağlantımızı gönderdik.
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);

            //Bağlantı açık mı diye kontrol ettik kapalıysa açtık.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Değerleri tek tek alıp valuelere aktardık.
            komut.Parameters.AddWithValue("@kitap_ad", deger.Kitap_ad);
            komut.Parameters.AddWithValue("@kitap_sayfasayisi", deger.Kitap_sayfasayisi);
            komut.Parameters.AddWithValue("@yazar_ad", deger.Yazar_ad);
            komut.Parameters.AddWithValue("@tur_ad", deger.Tur_ad);
            komut.Parameters.AddWithValue("@kitap_yayimevi", deger.Kitap_yayimevi);
            komut.Parameters.AddWithValue("@kitap_durumu", 0);

            //Etkilenen kayıt sayısını döndürüyor. İşlem gerçekleştiyse 1 gerçekleşmediyse 0 döndürür. Kodun çalışıp çalışmamasını sağlar ve kontrol eder.
            return komut.ExecuteNonQuery();
        }

        //SunumKatmanından yolladığımız değeri silen kodumuz. 
        public static bool KitapSil(int deger)
        {

            //Gelen değere göre kitabı silen sorgumuz.
            string sorgu = "DELETE * FROM Kitap WHERE kitap_id = @kitap_id";
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@kitap_id", deger);

            return komut.ExecuteNonQuery() > 0;


        }

        public static bool KitapGuncelle(EntityKitap deger)
        {
            //KitapID'ye göre kitabımızı güncelledik.
            string sorgu =
                "UPDATE Kitap SET kitap_ad = @kitap_ad,kitap_sayfasayisi = @kitap_sayfasayisi,yazar_ad = @yazar_ad,tur_ad =@tur_ad,kitap_yayimevi = @kitap_yayimevi WHERE kitap_id = @kitap_id";

            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@kitap_ad", deger.Kitap_ad);
            komut.Parameters.AddWithValue("@kitap_sayfasayisi", deger.Kitap_sayfasayisi);
            komut.Parameters.AddWithValue("@yazar_ad", deger.Yazar_ad);
            komut.Parameters.AddWithValue("@tur_ad", deger.Tur_ad);
            komut.Parameters.AddWithValue("@kitap_yayimevi", deger.Kitap_yayimevi);
            komut.Parameters.AddWithValue("@kitap_id", deger.Kitap_id);

            return komut.ExecuteNonQuery() > 0;
        }

        //Generic yapıda Arraylist kullandık.
        //Diziyi dinamik oluşturmuş olduk.
        public static List<EntityKitap> KitapListele()
        {   //Kitapları çeken sorgumuz.
            string sorgu = "SELECT * FROM Kitap  ";
            //Değerler isminde Entitykitaplar türünde değerler alan listi oluşturduk.
            List<EntityKitap> degerler = new List<EntityKitap>();
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Okuma işlemi yapılması için yazdık.
            OleDbDataReader dr = komut.ExecuteReader();
            //Datareaderın içinde veri kalmayacak şekilde tüm değerleri ent ile degerler listemize ekledik.
            while (dr.Read())
            {
                EntityKitap ent = new EntityKitap();
                ent.Kitap_id = Convert.ToInt16(dr[@"kitap_id"]);
                ent.Kitap_ad = dr[@"kitap_ad"].ToString();

                degerler.Add(ent);
            }
            dr.Close();
            AccessDBConnect.baglanti.Close();
            return degerler;
        }


    }
}
