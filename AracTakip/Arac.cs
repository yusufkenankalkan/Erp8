using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakip
{
    public class Arac
    {
        private string _marka, _model, _modelYili, _sase, _motorHacmi;

        public string Marka { get; set; }
        public string Model { get; set; }
        public string ModelYili { get; set; }
        public string Sase { get; set; }
        public string MotorHacmi { get; set; }
        public string YakitTürü { get; set; }
        public string VitesTipi { get; set; }

        public byte[] Fotograf { get; set; }

        public override string ToString()
        {
            return $"{this.Marka} {this.Model} - {this.ModelYili}";
        }
    }
}
