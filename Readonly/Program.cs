using System.Security.Cryptography.X509Certificates;

namespace Readonly
{
    class Cebir1
    {

    }
    class Cebir2
    {
        static readonly Cebir1 obje = new Cebir1();

        // static readonly=const
    }
    public class Program
    {
        public const string isim = "fatmagül";
        static void Main(string[] args)
        {
            int x = 2147483647;
        }
    }
}
