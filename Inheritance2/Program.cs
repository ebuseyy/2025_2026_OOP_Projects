namespace Inheritance2
{
    class Memeli
    {
        protected double Boy;
        protected double Agirlik;
        public void ozellikgoster()
        {
            Console.WriteLine("Boy: " + Boy);
            Console.WriteLine("Agirlik: " + Agirlik);
        }
    }
    class Kedi : Memeli
    {
        public string Turu;
        public void BoyGoster()
        {
            Boy = 25;
            Console.WriteLine("Boy: " + Boy);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            //kedi.Boy = 25;  // Boy field'ine erişim sağlanamaz çünkü protected tir. sadece ondan türeyen sınıflar kullanabilir..
            kedi.BoyGoster();
            Memeli memeli = new Memeli();
            memeli.ozellikgoster();
        }
    }
}
