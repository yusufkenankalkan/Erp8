using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Car.Lib
{
    public class Kisi
    {

        private string _ad, _soyad, _tckn, _telefon, _email;
        private DateTime dateTime;


        public string Ad
        {
            set
            {
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf) || char.IsSymbol(harf) || char.IsPunctuation(harf))
                        throw new Exception("Ad alanınıza özel karakter veya sayı girişi yapılamaz");
                }
                _ad = value;
            }
            get
            {
                return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower();
            }

        }
        public string Soyad
        {
            set
            {
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf) || char.IsSymbol(harf) || char.IsPunctuation(harf))
                        throw new Exception("Soyad alanınıza özel karakter veya sayı girişi yapılamaz");
                }
                _soyad = value;
            }
            get
            {
                return _soyad.ToUpper();
            }

        }

        public DateTime DogumTarihi { get; set; }
        public string Tckn
        {
            get => _tckn;
            set
            {
                if (value.Length != 11)
                    throw new Exception(" TCKN 11 haneli olmalıdır");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("TCKN sadece rakamlardan oluşmalıdır");
                }
                _tckn = value;
            }
        }
        public string Telefon
        {
            get => _telefon;
            set
            {
                if (value.Length != 10)
                    throw new Exception(" Telefon numarası 10 haneli olmalıdır");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("Telefon numarası sadece rakamlardan oluşmalıdır");
                }
                _telefon = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                string emailRegEx = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                if (!Regex.IsMatch(value, emailRegEx, RegexOptions.IgnoreCase))
                    throw new Exception("Lütfen uygun bir email adresi giriniz");
                _email = value;
            }
        }
        public int Yas
        {
            get => DateTime.Now.Year - this.DogumTarihi.Year;
        }
        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} - {this.Yas}";
        }
    }
}
