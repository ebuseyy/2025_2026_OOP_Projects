using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Dortgen2
    {
        public Dortgen2()
        {
            _en=0;
        }
        private int _en;
        private int _boy;
        public int En 
        {
            get
            {
                return _en;
            }
            set
            {
                if(value>0)
                    _en=value;
            }
        }
        public int Boy
        {
            get
            {
                return _boy;
            }
            set
            {
                if (value > 0)
                    _boy = value;
            }
        }


        public int Alan()
        {
            int Alan = En * Boy;
            return Alan;
        }
    }
}
