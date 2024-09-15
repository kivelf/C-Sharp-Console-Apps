using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg3
{
    internal static class Exts
    {
        public static int Fact(this int x) 
        { 
            return Utils.Fact(x);
        }

        public static int Power(this int n, int p)
        {
            return Utils.Power(n, p);
        }
    }
}
