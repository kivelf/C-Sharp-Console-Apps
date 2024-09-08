using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    public class Vaerkfoerer: Mekaniker
    {
        private int udnaevnelse;
        private double tillaeg;

        public Vaerkfoerer(int udnaevnelse, double tillaeg, int aarstal, double timeloen, string name): base(aarstal, timeloen, name)
        {
            this.udnaevnelse = udnaevnelse;
            this.tillaeg = tillaeg;
        }

        public int Udnaevnelse 
        { 
            get { return udnaevnelse; } 
            set { udnaevnelse = value; }
        }

        public double Tillaeg { get { return tillaeg; } set { tillaeg = value; } }

        public override double BeregnUgeLoen()
        {
            return TimerPrUge * Timeloen + tillaeg;
        }

        public override string ToString()
        {
            return $"Værkfører {Name}, siden {Udnaevnelse}";
        }
    }
}
