using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Opg3
{
    class Person
    {
        public string name;  // Create a field

        // Create a class constructor for the Car class
        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Name is " + name;
        }
    }
}
