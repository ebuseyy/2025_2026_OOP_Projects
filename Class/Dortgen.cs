using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Dortgen
    {
        // field, property, method
        private int En;
        private int Boy;

        public int GetEn()
        {
            return En;
        }
        public void SetEn(int en)
        {
            if (en > 0)
            {
                En = en;
            }
        }
        public int GetBoy()
        {
            return Boy;
        }
        public void SetBoy(int boy)
        {
            if (boy > 0)
            {
                Boy = boy;
            }
        }
        public int Alan()
        {
            int Alan = En * Boy;
            return Alan;
        }

    }
}
