namespace Enums
{
    enum BICIM : byte {Yatay, Dikey}
    internal class Program
    {
        static void diziyaz(Array dizi, BICIM b)
        {
            foreach (object item in dizi)
            {
                if (b == BICIM.Yatay)
                    Console.Write(item + " ");
                else
                    Console.WriteLine(item);
            }
        }
            static void Main(string[] args)
        {
            int[] a = new int[15];
            diziyaz(a, BICIM.Yatay);
            diziyaz(a, BICIM.Dikey);
        }
    }
}
