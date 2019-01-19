using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Burası varlık katmanıdır.Tablomuzdaki kolonlarımızı tanımladık.Diğer katmanlarda kullanabilmek için kapsülledik. 

namespace EntityLayer
{
    public class EntityKitap
    {
        private int _kitap_id; //Field tanımladık.
        private string _kitap_ad;
        private int _kitap_sayfasayisi;
        private string _yazar_ad;
        private string _tur_ad;
        private string _kitap_yayimevi;
        private int _kitap_durumu;

        public int Kitap_id { get => _kitap_id; set => _kitap_id = value; } //Kapsülledik.
        public string Kitap_ad { get => _kitap_ad; set => _kitap_ad = value; }
        public int Kitap_sayfasayisi { get => _kitap_sayfasayisi; set => _kitap_sayfasayisi = value; }
        public string Yazar_ad { get => _yazar_ad; set => _yazar_ad = value; }
        public string Tur_ad { get => _tur_ad; set => _tur_ad = value; }
        public string Kitap_yayimevi { get => _kitap_yayimevi; set => _kitap_yayimevi = value; }
        public int Kitap_durumu { get => _kitap_durumu; set => _kitap_durumu = value; }
    }
}
