using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Opg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jimmy");
            Person p2 = new Person("Pippi");

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p1.name = "Pippi The Second";
            Console.WriteLine(p1);

            var fido = new Animal("hund");
            Console.WriteLine("fido er en hund? " + fido.isDog());

            bool end = false;
            // Opg. 5
            /* while (!end)
            {
                Console.WriteLine("Make an animal: ");
                var species = Console.ReadLine();
                var animal = new Animal(species);
                Console.WriteLine("Animal: " +  animal);
                Console.WriteLine("Is the animal a dog? " + animal.isDog());
                Console.WriteLine("End (Y/N): ");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "Y") { 
                    end = true;
                }
            }
            Console.WriteLine("End of programme...");
            */

            // Opg. 6
            
            Console.ReadLine();
        }
    }
}
