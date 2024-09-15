using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg6
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Person(string name, int age, double weight) 
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString() 
        { 
            return $"Person: {Name}, {Age} years old, weighs {Weight}kgs";
        }
    }
}
