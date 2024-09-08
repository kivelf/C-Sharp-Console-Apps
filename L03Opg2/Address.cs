using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L03Opg2
{
    public class Address
    {
        private string street;
        private string number;

        public Address(string street, string number) 
        {
            this.street = street;
            this.number = number;
        }

        public string Street { get { return this.street; } set { street = value; } }
        public string Number { get { return this.number; } set { number = value; } }

        public override string ToString()
        {
            return $"{Street} nr. {Number}";
        }
    }
}
