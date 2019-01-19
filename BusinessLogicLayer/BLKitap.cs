using EntityLayer;
using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bu katman iş katmanımızdır.Facedekatmanına göndermeden önce gelen değerlerin kontrolünü yapan katmandır.
namespace BusinessLogicLayer
{
    public class BLKitap
    {//Kitap ekleyi kontrol ediyoruz.
        public static int BlKitapEkle(EntityKitap deger)
        { //Gelen değerleri kontrol ediyoruz.
            if (deger.Kitap_ad != null &&
                deger.Tur_ad != null &&
                deger.Kitap_sayfasayisi > 0 &&
                deger.Yazar_ad != null &&
                deger.Kitap_yayimevi != null)
            {// Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return FacadeKitap.KitapEkle(deger);
            }
            else
            {
                return -1;
            }
        }
        //Kitap güncelleyi kontrol ediyoruz.
        public static bool BlKitapGuncelle(EntityKitap deger)
        {
            if (deger.Kitap_ad != null &&
                deger.Tur_ad != null &&
                deger.Kitap_sayfasayisi > 0 &&
                deger.Yazar_ad != null &&
                deger.Kitap_yayimevi != null)
            {
                return FacadeKitap.KitapGuncelle(deger);
            }
            else
                return false;
        }
        //Kitap silmeyi kontrol ediyoruz.
        public static bool BlKitapSil(int deger)
        {

            if (deger > 0)
            {
                return FacadeKitap.KitapSil(deger);
            }
            else
            {
                return false;
            }
        }
        //kitap listelemeyi kontrol ediyoruz.
        public static List<EntityKitap> BlKitapListele()
        {
            return FacadeKitap.KitapListele();
        }
    }
}
