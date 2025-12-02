namespace Statics
{
    class oyuncu{

        public oyuncu()// constructor, yapıcı ve kurucu method denilir.
        {
            Console.WriteLine("oyuncu sınıfından bir nesne oluşturuldu");
        }
        static oyuncu()
        {
            Console.WriteLine("statik");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            oyuncu o1 = new oyuncu();
            oyuncu o2 = new oyuncu();
        }
    }
}
