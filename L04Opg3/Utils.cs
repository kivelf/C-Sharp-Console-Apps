using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg3
{
    internal class Utils
    {
        public static int Fact(int x) 
        { 
            if (x < 0) return -1; 
            else if (x == 0) return 1;
            else return x * Fact(x - 1);
        }

        public static int Power(int n, int p) 
        { 
            return (int)Math.Pow(n, p);
        }
    }
}
