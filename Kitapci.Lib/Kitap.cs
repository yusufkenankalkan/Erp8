using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib
{
    public class Kitap : Urun
    {
        public Kitap(double fiyat, int stok, string urunAdi) : base(fiyat, stok, urunAdi)
        {

        }

        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public string YayinEvi { get; set; }
    }
}
