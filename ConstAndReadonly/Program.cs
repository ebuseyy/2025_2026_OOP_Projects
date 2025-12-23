namespace Const
{
    class Cebir
    {
        public const double x = 5;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cebir c = new Cebir();
            Console.WriteLine(Cebir.x);
            //const int y = 5;
            //            y = 6;
        }
    }
}
