namespace static2
{
    class oyuncu
    {
        public static int toplam;
        public oyuncu()
        {
            toplam++;
        }
        static oyuncu()
        {
            toplam = 0;
        }

        ~oyuncu()
        {
            Console.WriteLine("Destructor çalıştı VE bir oyuncu gitti");
            toplam--;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            oyuncu o1 = new oyuncu();   
            Console.WriteLine("Toplam oyuncu sayısı: " + oyuncu.toplam);
            oyuncu o2 = new oyuncu();
            Console.WriteLine("Toplam oyuncu sayısı: " + oyuncu.toplam);
        }
    }
}
