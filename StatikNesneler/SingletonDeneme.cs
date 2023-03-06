using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikNesneler
{
    public class SingletonDeneme
    {
        public Guid Id { get; set; }

        private SingletonDeneme()
        {
            Thread.Sleep(10 * 1000);
            this.Id = Guid.NewGuid();
            
        }
        private static SingletonDeneme _singletonDeneme;
        public static SingletonDeneme GetInstance()
        {
            //if (_singletonDeneme == null)
            //    _singletonDeneme = new SingletonDeneme();
            //return _singletonDeneme;

            //Alttaki yazım üstteki ile aynı işlemi yapar

            return _singletonDeneme ??= new SingletonDeneme(); // ?? operatörü null kontrolünü if komutu yazmadan yapar. Aşağıdaki örnekle aynı mantıkla çalışır.
        }
        public static SingletonDeneme Instance
        {
            get
            {
                if (_singletonDeneme == null)
                    _singletonDeneme = new SingletonDeneme();
                return _singletonDeneme;
            }
        }

    }
}
