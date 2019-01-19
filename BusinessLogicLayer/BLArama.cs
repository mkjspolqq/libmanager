using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bu katman iş katmanımızdır. Facedekatmanına göndermeden önce gelen değerlerin kontrolünü yapan katmandır.
namespace BusinessLogicLayer
{
    public class BLArama
    {
                //Arama işleminde gereken kontroller.
        public static DataTable BlUyeArama(string deger)
        {       //Gelen değerleri kontrol ediyoruz.
            if (deger != null)
                //Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return Arama.OgrenciArama(deger);
            else
            {
                return null;
            }
        }
        public static DataTable BlKitapArama(string deger)
        {
            if (deger != null)
                //Gerekli Facede katmanımızdaki yere buradan yolluyoruz.
                return Arama.KitapArama(deger);
            else
            {
                return null;
            }
        }
    }
}
