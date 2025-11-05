using System.ComponentModel.Design;

namespace ilkders_ikisayikarsilastirma_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            kontrol nesne=new kontrol();
            nesne.sayikontrol(a, b);

        }
    }
}
