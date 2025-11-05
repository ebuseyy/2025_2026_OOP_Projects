using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitsel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 0xB5;
            Console.WriteLine(b);

            //byte c = (byte)(b << 1);
            //Console.WriteLine(c);

            //byte d = (byte)(b << 2);
            //Console.WriteLine(d);

            int z = (int)(b << 1);
            Console.WriteLine(z);
        }
    }
}
