using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    public class Synsmand: Mekaniker
    {
        private int antalSyn;
        private const double _prisPrSyn = 290;

        public Synsmand(int antalSyn, int aarstal, string name): base(aarstal, name)
        {
            this.antalSyn = antalSyn;
        }

        public int AntalSyn { get { return antalSyn; }  set { this.antalSyn = value; } }

        public override double BeregnUgeLoen()
        {
            return antalSyn * _prisPrSyn;
        }

        public override string ToString()
        {
            return $"Synsmand {Name}, siden {Aarstal}";
        }
    }
}
