using System;
using System.Data;
using System.Data.OleDb;
using EntityLayer;

namespace FacadeLayer
{   //
    public class FacadeIslem
    {   //Diğer katmanlardan ve sınıflardan erişebilmek için Public yaptık.

        //Kitabı öğrenciye verdiğimiz yerdir.
        public static int KitabiOduncVer(EntityIslem deger)
        {
            string sorgu =
                "INSERT INTO Islem (kitap_id,ogrenci_id,alis_tarih,veris_tarih,teslim_durumu)"+"VALUES (@kitap_id,@ogrenci_id,@alis_tarih,@veris_tarih,@teslim_durumu)";
            //Komutu oluşturduk komuta üsteki sorguyu ve access bağlantımızı gönderdik.
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);
            //Bağlantı açık mı diye kontrol ettik kapalıysa açtık.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            // Değerleri tek tek alıp valuelere aktardık.
             komut.Parameters.AddWithValue("@kitap_id", deger.Kitap_id);
            komut.Parameters.AddWithValue("@ogrenci_id", deger.Ogrenci_id);
            komut.Parameters.AddWithValue("@alis_tarih", deger.Alis_tarih);
            komut.Parameters.AddWithValue("@veris_tarih", deger.Veris_tarih);
            komut.Parameters.AddWithValue("@teslim_durumu",1);
            kitapver(deger.Kitap_id);


            //Etkilenen kayıt sayısını döndürüyor. İşlem gerçekleştiyse 1 gerçekleşmediyse 0 döndürür. Kodun çalışıp çalışmamasını sağlar ve kontrol eder.
            return komut.ExecuteNonQuery();
        }
      //Kitabı kullanıcıdan geri aldığımız katmanımızdır. Teslim durumunu 0/1 yaptığımız yerdir.
        public static bool KitabiGeriAl(EntityIslem deger)
        {
            
                string sorgu = "UPDATE Islem SET teslim_durumu=@teslim_durumu, alis_tarih=@alis_tarih WHERE kitap_id=@kitap_id AND ogrenci_id=@ogrenci_id AND teslim_durumu=" + 1 + " ";

                OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("@teslim_durumu", 0);
                komut.Parameters.AddWithValue("@alis_tarih", deger.Alis_tarih);
                komut.Parameters.AddWithValue("@kitap_id", deger.Kitap_id);
                komut.Parameters.AddWithValue("@ogrenci_id", deger.Ogrenci_id);
                kitabigerial(deger.Kitap_id);

                return komut.ExecuteNonQuery() > 0;
            
        }
        //Kitap teslim tarihini uzattık. 
        public static bool KitapTarihUzat(EntityIslem deger)
        {
            string sorgu = "UPDATE Islem SET alis_tarih=@alis_tarih WHERE ogrenci_id=@ogrenci_id AND kitap_id=@kitap_id";
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@alis_tarih", deger.Alis_tarih);
            komut.Parameters.AddWithValue("@ogrenci_id", deger.Ogrenci_id);
            komut.Parameters.AddWithValue("@kitap_id", deger.Kitap_id);

            return komut.ExecuteNonQuery() > 0;
        }

        //Kitabı öğrenciye vermemizi sağlar.
        public static bool kitapver(int deger)
        {
            string sorgu = "UPDATE Kitap Set kitap_durumu=@kitap_durumu WHERE kitap_id=@kitap_id ";
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@kitap_durumu", 1);
            komut.Parameters.AddWithValue("@kitap_id", deger);

            return komut.ExecuteNonQuery() > 0;
        }
        //Kitabı öğrenciden geri almamızı sağlar.
        public static bool kitabigerial(int deger)
        {
            string sorgu = "UPDATE Kitap Set kitap_durumu=@kitap_durumu WHERE kitap_id=@kitap_id";
            OleDbCommand komut = new OleDbCommand(sorgu, AccessDBConnect.baglanti);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@kitap_durumu", 0);
            komut.Parameters.AddWithValue("@kitap_id", deger);

            return komut.ExecuteNonQuery() > 0;
        }

    }
}
