using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{//Bu katman iş katmanımızdır.Facedekatmanına göndermeden önce gelen değerlerin kontrolünü yapan katmandır.
   public class BLOgrenci
    { //Ogrenci eklemeyi kontrol ettiğimiz kısım.
        public static int BlOgrenciEkle(EntityOgrenci deger)
        {   //Gelen değerleri kontrol ediyoruz.
            if (deger.Ogrenci_ad != null &&
                deger.Ogrenci_soyad != null &&
                deger.Ogrenci_email != null )
            {   //Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return FacadeOgrenci.OgrenciEkle(deger);
            }
            else
            {
                return -1;
            }
        }
        //Ogrenci silmeyi kontrol kontrol ettiğimiz kısım
        public static bool BlOgrenciGuncelle(EntityOgrenci deger)
        {   //Gelen değerleri kontrol ediyoruz.
            if (deger.Ogrenci_ad != null &&
                deger.Ogrenci_soyad != null &&
                deger.Ogrenci_email != null)
            {   //Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return FacadeOgrenci.OgrenciGuncelle(deger);
            }
            else
                return false;
        }
        //Ogrenci silmeyi kontrol ettiğimiz kısım
        public static bool BlOgrenciSil(int deger)
        {
            //Gelen değerleri kontrol ediyoruz.
            if (deger > 0)
            {//Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return FacadeOgrenci.OgrenciSil(deger);
            }
            else
            {
                return false;
            }
        }

        
        //Borç ödeyi kontrol ettiğimiz kısım.
        public static int BlBorcOde(EntityOgrenci deger)
        {   //Gelen değerleri kontrol ediyoruz.
            if (deger.Ogrenci_id > 0 &&
                deger.Ogrenci_borc > 0)
            {//Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return FacadeOgrenci.OgrenciBorcOde(deger);
            }
            else
                return -1;
        }
    }
}
