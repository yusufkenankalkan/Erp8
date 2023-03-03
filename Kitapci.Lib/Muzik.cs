using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib
{
    public class Muzik : Urun
    {
        public Muzik (double fiyat, int stok, string urunAdi) : base(fiyat, stok, urunAdi)
        {

        }

        public string SarkiciAdi { get; set; }
        public string SarkiciSoyadi { get; set; }
    }
}
