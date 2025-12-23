namespace Inheritance
{
    class insan
    {
        private int tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected int Maas { get; set; }
    }
    class Ogretmen:insan
    {        
        public void DersVer()
        {
            Maas = 12;
            Ad = "Ahmet";
            Console.WriteLine($"{Ad} Ders veriliyor...");
        }
    }
    class Ogrenci: insan   // Kalıtım operatörü : dır,Kul. biçimi--> Türeyen sınıf:Taban sınıf
    {
        public void DersAl()
        {
            Console.WriteLine("Ders alınıyor...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           Ogretmen ogt= new Ogretmen();
           ogt.Ad = "Betül";
           Ogrenci ogrenci = new Ogrenci();
           ogrenci.Ad = "Yusuf";
           
           insan ins = new insan();

            
        }
    }
}
