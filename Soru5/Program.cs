namespace Soru5
{
    internal class Program
    {

       
        public static void Main()
        {
            byte x = 250, y = 10;
            Console.WriteLine(Convert.ToString(x, toBase: 2));
            Console.WriteLine(Convert.ToString(y, toBase: 2));
            var result = x & y;
            Console.WriteLine(result);
            result = result - (x | y);
            Console.WriteLine(--result);
            result = result - x ^ y;
            Console.WriteLine(result++);
            result = result + x << 2;
            Console.WriteLine("result");
            result = result + x >> 2;
            Console.WriteLine(result);

        }

    }
}
