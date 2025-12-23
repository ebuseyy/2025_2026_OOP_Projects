namespace Inheritance3
{
    class Memeli
    {
        protected double Boy;
        protected double Agirlik;
        public Memeli()
        {
            Console.WriteLine("Memeli hayvan oluşturuldu");
        }
        public Memeli(string x)
        {
            Console.WriteLine($"{x} Memeli hayvan oluşturuldu");
        }
        public void ozellikgoster()
        {
            Console.WriteLine("Boy: " + Boy);
            Console.WriteLine("Agirlik: " + Agirlik);
        }
    }
    class Kedi : Memeli
    {
        public string Turu;
        public Kedi()
        {
            Console.WriteLine("Kedi oluşturuldu");
        }
        public Kedi(string x):base(x)
        {
            Console.WriteLine($"{x} kedi oluşturuldu");
        }
        public void BoyGoster()
        {
            Console.WriteLine("Boy: " + Boy);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Kedi kedi = new Kedi("Van");
        }
    }
}
