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
            List<IharAdresse> medarbejdere = new List<IharAdresse>();
            CprNr cpr1 = new CprNr("010190", "1122");
            Address addr1 = new Address("Street", "12");
            Address addr2 = new Address("Street", "23");
            Address addr3 = new Address("Street", "34");
            medarbejdere.Add(new Medarbejder(cpr1, "Lene", "100"));
            medarbejdere.Add(new Mekaniker(2001, 450, "Alexander"));
            medarbejdere.Add(new Mekaniker(2017, 350, "Benny", addr1));
            medarbejdere.Add(new Firma("Firma 0", addr2));
            medarbejdere.Add(new Vaerkfoerer(2013, 5000, 2009, 400, "Casper"));
            medarbejdere.Add(new Synsmand(43, 2015, "Dennis"));
            medarbejdere.Add(new Synsmand(28, 2019, "Erik"));
            medarbejdere.Add(new Firma("Firma 1", addr3));

            foreach (IharAdresse m in medarbejdere) 
            {
                Console.WriteLine(m);
            }

            Console.ReadLine();
        }
    }
}
