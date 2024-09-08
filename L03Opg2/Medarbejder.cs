using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    public class Medarbejder: IharAdresse
    {
        private CprNr cpr;
        private string name;
        private Address adresse;
        private string medarbejdernummer;
        private const int _timerPrUge = 37;

        public Medarbejder(CprNr cpr, string name, Address adresse, string medarbejdernummer)
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
            this.adresse = null;
            this.medarbejdernummer = medarbejdernummer;
        }

        public Medarbejder(string name)
        {
            this.cpr = null;
            this.name = name;
            this.adresse = null;
            this.medarbejdernummer = "not available";
        }

        public Medarbejder(string name, Address address)
        {
            this.cpr = null;
            this.name = name;
            this.adresse = address;
            this.medarbejdernummer = "not available";
        }

        public CprNr CprNr
        {
            get { return this.cpr; }
            set { this.cpr = value; }
        }

        public string Name 
        { 
            get { return this.name; } 
            set { this.name = value; }
        }

        public Address Adresse
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
            return $"Medarbejder {Name}, cpr: {CprNr.ToString()}, nummer: {Medarbejdernummer}";
        }
    }
}
