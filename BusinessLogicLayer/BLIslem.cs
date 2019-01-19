using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{            //Bu katman iş katmanımızdır. Facedekatmanına göndermeden önce gelen değerlerin kontrolünü yapan katmandır.
    public class BLIslem
    {           //Ödünç vermek için gereken komutlar
        public static int BlOduncVer(EntityIslem deger)
        {       //Gelen değerleri kontrol ediyoruz.
            if (deger.Kitap_id > 0 &&
                deger.Ogrenci_id > 0)
            {   //Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return FacadeIslem.KitabiOduncVer(deger);
            }
            else
            {
                return -1;
            }
        }
        //Kitap tarihini uzatmayı kontrol etmeks için yazdık.
        public static bool BlKitapTarihUzat(EntityIslem deger)
        {       //Gelen değerleri kontrol ediyoruz.
            if (deger.Kitap_id > 0 &&
                deger.Ogrenci_id > 0)
            {   //Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return FacadeIslem.KitapTarihUzat(deger);
            }
            else
                return false;
        }
        //Kitabı geri almayı kontrol etmek için yazdık.
        public static bool BlGeriAl(EntityIslem deger)
        {       //Gelen değerleri kontrol ediyoruz.
            if (deger.Kitap_id > 0 &&
                deger.Ogrenci_id > 0)
            {   //Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return FacadeIslem.KitabiGeriAl(deger);
            }
            else
                return false;
        }
    }
}
