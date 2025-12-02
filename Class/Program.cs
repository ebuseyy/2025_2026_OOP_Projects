namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dortgen d = new Dortgen();

            d.SetEn(10);
            d.SetBoy(20);
            int alansonuc=d.Alan();
            Console.WriteLine("Alan: " + alansonuc);

            d.SetEn(15);
            d.SetBoy(25);
            alansonuc = d.Alan();
            Console.WriteLine("Alan: " + alansonuc);

            Console.WriteLine("En:" + d.GetEn());
            Console.WriteLine("Boy:" + d.GetBoy());
            //------------------------------------------
            Dortgen2 d2 = new Dortgen2();
            d2.En = 30;
            d2.Boy = 40;
            alansonuc = d2.Alan();
            Console.WriteLine("en: " + d2.En);
            Console.WriteLine("Alan: " + alansonuc);*/
            /*Zaman z1 = new Zaman();
            z1.Yazdir();

            Zaman z2 = new Zaman(35,12,12);
            z2.Yazdir();

            Zaman z3 = new Zaman(z2);
            z3.Yazdir();*/

            Destructor d = new Destructor();
            Console.WriteLine("Program sonlandı.");
        }
    }
}
