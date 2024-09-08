using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Medarbejder> medarbejdere = new List<Medarbejder>();
            medarbejdere.Add(new Medarbejder("Lene"));
            medarbejdere.Add(new Mekaniker(2001, 450, "Alexander"));
            medarbejdere.Add(new Mekaniker(2017, 350, "Benny", "Adress 1"));
            medarbejdere.Add(new Vaerkfoerer(2013, 5000, 2009, 400, "Casper"));
            medarbejdere.Add(new Synsmand(43, 2015, "Dennis"));
            medarbejdere.Add(new Synsmand(28, 2019, "Erik"));

            foreach (Medarbejder m in medarbejdere) 
            { 
                Console.WriteLine(m + ", ugeløn: " + m.BeregnUgeLoen());
            }

            Console.ReadLine();
        }
    }
}
