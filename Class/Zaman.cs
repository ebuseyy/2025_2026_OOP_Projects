using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Zaman
    {
        public int Saat;// int tipinin gerektiği alan kadar yer ayrılır.
        public int Dakika;
        public int Saniye;

        public Zaman()//default constructor, parametresiz constructor
        {
            Saat = 0;
            Dakika = 0;
            Saniye = 0;
        }
        public Zaman(int saat, int dakika, int saniye)//parametreli constructor
        {
            if (saat<=24 && saat>=0)
            {
                Saat = saat;
            }
            Dakika = dakika;
            Saniye = saniye;
        }
        public Zaman(int saat,int dakika) : this(saat,dakika, 0)//constructor chaining
        {
        }
        public Zaman(int saat) : this(saat,5, 0)//constructor chaining
        {
        }
        public Zaman(Zaman z)//copy constructor
        {
            Saat = z.Saat;
            Dakika = z.Dakika;
            Saniye = z.Saniye;
        }
        public void Yazdir()
        {
            Console.WriteLine("{0}:{1}:{2}", Saat, Dakika, Saniye);
        }
    }
}
