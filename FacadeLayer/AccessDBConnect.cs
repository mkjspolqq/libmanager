using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{       //Veritabanı bağlantımızı yaptık,adresimizi aldık.
    public class AccessDBConnect
    {
        public static OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\umutd\OneDrive\Masaüstü\C#\Hakan Ergovan 162113013 ve Yunus Serter 162119005\KutuphaneAPP\KutuphaneDB.mdb");
    }
}
