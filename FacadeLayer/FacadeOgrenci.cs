using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace FacadeLayer
{ //Diğer katmanlardan ve sınıflardan erişebilmek için Public yaptık.
    public class FacadeOgrenci
    {   //Öğrenci eklediğimiz fonsiyonumuz.
        public static int OgrenciEkle(EntityOgrenci deger)
        { //Komutu oluşturduk komuta üsteki sorguyu ve access bağlantımızı gönderdik.
            string sorgu =
                "INSERT INTO Ogrenci (ogrenci_ad,ogrenci_soyad,ogrenci_email,ogrenci_dtarihi,ogrenci_borc)" +
                "VALUES (@ogrenci_ad,@ogrenci_soyad,@ogrenci_email,@ogrenci_dtarihi,@ogrenci_borc)";
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);
            //Bağlantı açık mı diye kontrol ettik kapalıysa açtık.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Değerleri tek tek alıp valuelere aktardık.
            komut.Parameters.AddWithValue("@ogrenci_ad", deger.Ogrenci_ad);
            komut.Parameters.AddWithValue("@ogrenci_soyad", deger.Ogrenci_soyad);
            komut.Parameters.AddWithValue("@ogrenci_email", deger.Ogrenci_email);
            komut.Parameters.AddWithValue("@ogrenci_dtarihi", deger.Ogrenci_dtarihi);
            komut.Parameters.AddWithValue("@ogrenci_borc", deger.Ogrenci_borc);

            //Etkilenen kayıt sayısını döndürüyor. İşlem gerçekleştiyse 1 gerçekleşmediyse 0 döndürür. Kodun çalışıp çalışmamasını sağlar ve kontrol eder.
            return komut.ExecuteNonQuery();

        }
        //SunumKatmanından yolladığımız değeri silen kodumuz. 
        public static bool OgrenciSil(int deger)
        {
            string sorgu = "DELETE * FROM Ogrenci WHERE ogrenci_id=@ogrenci_id";
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ogrenci_id", deger);

            return komut.ExecuteNonQuery() > 0;
        }
        //OgrenciIDsine nosuna göre kitabımızı güncelledik.
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            string sorgu =
                "UPDATE Ogrenci SET ogrenci_ad=@ogrenci_ad,ogrenci_soyad=@ogrenci_soyad,ogrenci_email=@ogrenci_email,ogrenci_dtarihi=@ogrenci_dtarihi,ogrenci_borc=@ogrenci_borc WHERE ogrenci_id=@ogrenci_id";
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ogrenci_ad", deger.Ogrenci_ad);
            komut.Parameters.AddWithValue("@ogrenci_soyad", deger.Ogrenci_soyad);
            komut.Parameters.AddWithValue("@ogrenci_email", deger.Ogrenci_email);
            komut.Parameters.AddWithValue("@ogrenci_dtarihi", deger.Ogrenci_dtarihi);
            komut.Parameters.AddWithValue("@ogrenci_borc", deger.Ogrenci_borc);
            komut.Parameters.AddWithValue("@ogrenci_id", deger.Ogrenci_id);


            return komut.ExecuteNonQuery() > 0;
        }
        //OgrenciID'ye göre sorguladığımız ogrenci borcunun ödemesi yapılan yer.
        public static int OgrenciBorcOde(EntityOgrenci deger)
        {
            string sorgu = "UPDATE Ogrenci SET ogrenci_borc=@ogrenci_borc WHERE ogrenci_id=@ogreci_id ";

            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ogrenci_borc", 0);
            komut.Parameters.AddWithValue("@ogrenci_id", deger.Ogrenci_id);
            return komut.ExecuteNonQuery();
        }
        //Ceza işleminin gerçekleştiği yer.
        //14 günden fazla süredir teslim edilmemiş kitaplara 1 lira ceza kesiyoruz.
        public static bool CezaYaz(string id, int ceza)
        {
            if (ceza > 14)
            {
                string sorgu = "UPDATE Ogrenci SET ogrenci_borc=@ogrenci_borc WHERE ogrenci_id=@ogrenci_id";
                OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("@ogrenci_borc", ceza);
                komut.Parameters.AddWithValue("@ogrenci_id", id);
                return komut.ExecuteNonQuery() > 0;

            }

            return false;
        }
    }
}
