using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    public class Medarbejder
    {
        private string name;
        private string adresse;
        private const int _timerPrUge = 37;

        public Medarbejder(string name, string adresse)
        {
            this.name = name;
            this.adresse = adresse;
        }

        public Medarbejder(string name)
        {
            this.name = name;
            this.adresse = "default";
        }

        public string Name 
        { 
            get { return this.name; } 
            set { this.name = value; }
        }

        public string Address
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public virtual double BeregnUgeLoen() 
        {
            return 0.0;
        }

        //og den tilhørende access metode, bemærk readOnly, dvs KUN get!
        public int TimerPrUge { get { return _timerPrUge; } }

        public override string ToString()
        {
            return $"Medarbejder {Name}";
        }
    }
}
