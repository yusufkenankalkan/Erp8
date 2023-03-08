using AracTakipNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakipNew.Data
{
    public class EnvanterContext
    {
        public List<Marka> Markalar { get; set; } = new();
        public List<Model> Modeller { get; set; } = new();
        public List<Arac> Araclar { get; set; } = new();

    }
}
