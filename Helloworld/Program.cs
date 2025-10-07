namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
            int y = Convert.ToInt32(Console.ReadLine());
            int sonuc=topla(x,y);
            Console.WriteLine(sonuc);

            islem obje = new islem();

            int c = obje.carpma(x, y);

            islem2 obje2 = new islem2();
            int c2 = obje2.Bolme(x, y);
        }
        static int topla(int a, int b)
        {
            return a + b;
        }
        static int cikarma(int a, int b)
        {
            return a - b;
        }
    }
    class islem
    {
        public int Bolme(int a, int b)
        {
            return a / b;
        }
        public int carpma(int a, int b)
        {
            return a *b;
        }
    }
}
