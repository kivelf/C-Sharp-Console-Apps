using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    public class Mekaniker: Medarbejder
    {
        private int aarstal;
        private double timeloen;

        public Mekaniker(CprNr cpr, string nummer, int aarstal, double timeloen, string name): base(cpr, name, nummer) 
        {
            this.aarstal = aarstal;
            this.timeloen = timeloen;
        }

        public Mekaniker(int aarstal, double timeloen, string name) : base(name)
        {
            this.aarstal = aarstal;
            this.timeloen = timeloen;
        }

        public Mekaniker(int aarstal, string name) : base(name)
        {
            this.aarstal = aarstal;
        }

        public Mekaniker(int aarstal, double timeloen, string name, Address address) : base(name, address)
        {
            this.aarstal = aarstal;
            this.timeloen = timeloen;
        }

        public int Aarstal 
        {
            get { return this.aarstal; }
            set { this.aarstal = value; }
        }

        public double Timeloen
        {
            get { return this.timeloen; }
            set { this.timeloen = value; }
        }

        public override double BeregnUgeLoen()
        {
            return TimerPrUge * timeloen;
        }

        public override string ToString()
        {
            return $"Mekaniker {Name}, siden {Aarstal}";
        }
    }
}
