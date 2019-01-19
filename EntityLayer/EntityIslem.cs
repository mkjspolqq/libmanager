using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{   //Burası varlık katmanıdır.Tablomuzdaki kolonlarımızı tanımladık.Diğer katmanlarda kullanabilmek için kapsülledik. 
    public class EntityIslem
    {
        private int _Islem_id;  //Field tanımladık.
        private int _ogrenci_id;
        private int _kitap_id;
        private DateTime _alis_tarih;
        private DateTime _veris_tarih;
        private int _teslim_durumu;

        public int Islem_id { get => _Islem_id; set => _Islem_id = value; }     //Kapsülledik.
        public int Ogrenci_id { get => _ogrenci_id; set => _ogrenci_id = value; }
        public int Kitap_id { get => _kitap_id; set => _kitap_id = value; }
        public DateTime Alis_tarih { get => _alis_tarih; set => _alis_tarih = value; }
        public DateTime Veris_tarih { get => _veris_tarih; set => _veris_tarih = value; }
        public int Teslim_durumu { get => _teslim_durumu; set => _teslim_durumu = value; }
    }
}
