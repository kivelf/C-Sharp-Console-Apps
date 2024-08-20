using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Animal : IAnimal
    {
        private string specie;

        // Constructor that takes a string argument
        public Animal(string specie)
        {
            this.specie = specie;
        }

        // Method that checks if the specie is "dog"
        public bool isDog()
        {
            return (specie.ToLower() == "hund") || (specie.ToLower() == "dog");
        }

        public override string ToString() { 
            return "Animal is " + specie;
        }
    }
}
