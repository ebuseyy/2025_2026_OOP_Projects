using System.Data.SqlTypes;
namespace Enums2
{
    enum NOT {Pekiyi=5, İyi, Orta, gecersiz, zayıf}
    internal class Program
    {
        static void Main(string[] args)
        {
  
               Console.WriteLine((int)NOT.zayıf);
        }
    }
}
