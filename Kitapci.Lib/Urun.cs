using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib
{
    public class Urun
    {
        private double _fiyat;
        private int _stok;
        private string _urunAdi;
        public Urun(double fiyat, int stok, string urunAdi)
        {
            _fiyat = fiyat;
            _stok = stok;
            _urunAdi = urunAdi;
        }
        public double Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (_fiyat <= 0)
                    throw new Exception("Ürün fiyatı 0 veya daha az olamaz");
                _fiyat = value;

            }
        }
        public int Stok
        {
            get { return _stok; }
            set
            {
                if (_stok < 0)
                    throw new Exception("Stok 0'dan az olamaz");
                _stok = value;
            }
        }
        public string UrunAdi
        {
            get { return _urunAdi; }
            set
            {
                if (_urunAdi == null || _urunAdi.Length < 2)
                    throw new Exception("Ürün adı en az 1 karakter içermelidir");
                _urunAdi = value;
            }
        }
    }
}
