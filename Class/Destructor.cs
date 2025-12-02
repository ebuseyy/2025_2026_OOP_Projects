using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Destructor
    {
        public Destructor() 
        {
            // Constructor
            Console.WriteLine("Constructor çağrıldı.");
        }
        int i;
        public int MyProperty { get; set; }
        ~Destructor()
        {
            // Destructor, Yıkıcı metot
            Console.WriteLine("Destructor çağrıldı.");
        }
    }
}
