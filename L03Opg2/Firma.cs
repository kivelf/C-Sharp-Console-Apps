using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    public class Firma: IharAdresse
    {
        private string name { get; set; }
        private string adresse { get; set; }

        public Firma(string name, string adresse)
        {
            this.name = name;
            this.adresse = adresse;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Adresse { get { return adresse; } set { adresse = value; } }

        public override string ToString()
        {
            return $"Firma {Name}, address: {Adresse}";
        }
    }
}
