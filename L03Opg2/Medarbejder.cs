using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    public class Medarbejder
    {
        private string cpr;
        private string name;
        private string adresse;
        private string medarbejdernummer;
        private const int _timerPrUge = 37;

        public Medarbejder(CprNr cpr, string name, string adresse, string medarbejdernummer)
        {
            this.cpr = cpr;
            this.name = name;
            this.adresse = adresse;
            this.medarbejdernummer = medarbejdernummer;
        }

        public Medarbejder(CprNr cpr, string name, string medarbejdernummer)
        {
            this.cpr = cpr;
            this.name = name;
            this.adresse = "default";
            this.medarbejdernummer = medarbejdernummer;
        }

        public Medarbejder(string name)
        {
            this.cpr = "unknown";
            this.name = name;
            this.adresse = "default";
            this.medarbejdernummer = "not available";
        }

        public string CprNr
        {
            get { return this.cpr; }
            set { this.cpr = value; }
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

        public string Medarbejdernummer
        {
            get { return this.medarbejdernummer; }
            set { this.medarbejdernummer = value; }
        }

        public virtual double BeregnUgeLoen() 
        {
            return 0.0;
        }

        // den tilhørende access metode, bemærk readOnly, dvs KUN get!
        public int TimerPrUge { get { return _timerPrUge; } }

        public override string ToString()
        {
            return $"Medarbejder {Name}, cpr: {CprNr}, nummer: {Medarbejdernummer}";
        }
    }
}
