using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkders_ikisayikarsilastirma_
{
    internal class kontrol
    {
        public void sayikontrol(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($"büyük sayımız {a} sayısıdır");
            }
            else if (b > a)
            {

                Console.WriteLine($"büyük sayımız {b} sayısıdır");
            }
            else { Console.WriteLine($" bu sayılar eşittir"); }

        }
    }
}
