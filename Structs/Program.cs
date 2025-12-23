namespace Structs
{
    struct Ogrenci
    {
        public string Adi;
        public string Soyadi;
        public int OgrNo;
        public Ogrenci()
        {
            Adi = "fatmagül";
            Soyadi = "çelik";
            OgrNo = 15;
        }
        public Ogrenci(string x,string y,int a)
        {
            Adi = x;
            Soyadi = y;
            OgrNo = a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Ogrenci ogr = new Ogrenci(); // bellekte yer almıştır. ve tiplerin default değerleri atanmıştır.
            Console.WriteLine(ogr.OgrNo);

            Ogrenci ogr2;// bellekte yer kaplamamıştır.
            ogr2.Adi = "yusuf";
            ogr2.Soyadi = "çoktar";
            ogr2.OgrNo = 23;


            Console.WriteLine(ogr2.OgrNo);

            Ogrenci ogr3 = new Ogrenci("betül","sağun",22); // bellekte yer almıştır. ve tiplerin default değerleri atanmıştır.
            Console.WriteLine(ogr3.OgrNo);
        }
    }
}
