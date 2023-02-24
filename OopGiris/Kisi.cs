using System.Text.RegularExpressions;

namespace OopGiris
{
    public class Kisi
    {
        // ad, soyad, dogumTarihi, tckn, telefon, email,yas
        //ad ve soyad özel karakter ve sayı içermemeli. Okunurken ilk harf büyük diğer harfler küçük göstermeli
        //tckn 11 haneli olmalı ve sadece rakamlardan oluşmalı
        //telefon 10 haneli olmalı ve sadece rakamlardan oluşmalı
        //Email adresi @ işaretinden sonra en az 2 karakter olmali ve email kurallarına uygun olmalı asd@asd
        //Yaş özelliği sadece okunur olmalı
        private string _ad, _soyad, _tckn, _telefon, _email;

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
                _ad = value;
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

    }
}