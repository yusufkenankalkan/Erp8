using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimLib
{
    public class Kare : Sekil
    {
        public Kare()
        {

        }
        public Kare(int x):base(x)
        {

        }
        public override double CevreHesapla() //
        {
            return 4 * X;
        }
    }
}
