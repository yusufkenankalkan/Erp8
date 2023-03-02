using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimLib
{
    public class Kare
    {
        public double X { get; set; }

        public double AlanHesapla() => X * X;
        public double CevreHesapla() => 4 * X;

    }
}
