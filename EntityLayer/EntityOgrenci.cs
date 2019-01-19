using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{   //Burası varlık katmanıdır.Tablomuzdaki kolonlarımızı tanımladık.Diğer katmanlarda kullanabilmek için kapsülledik. 
    public class EntityOgrenci
    {
        private int _ogrenci_id;  //Field tanımladık.
        private string _ogrenci_ad;
        private string _ogrenci_email;
        private string _ogrenci_soyad;
        private DateTime _ogrenci_dtarihi;
        private int _ogrenci_borc;

        public int Ogrenci_id { get => _ogrenci_id; set => _ogrenci_id = value; }      //Kapsülledik.     
        public string Ogrenci_ad { get => _ogrenci_ad; set => _ogrenci_ad = value; }
        public string Ogrenci_email { get => _ogrenci_email; set => _ogrenci_email = value; }
        public string Ogrenci_soyad { get => _ogrenci_soyad; set => _ogrenci_soyad = value; }
        public DateTime Ogrenci_dtarihi { get => _ogrenci_dtarihi; set => _ogrenci_dtarihi = value; }
        public int Ogrenci_borc { get => _ogrenci_borc; set => _ogrenci_borc = value; }
    }
}
