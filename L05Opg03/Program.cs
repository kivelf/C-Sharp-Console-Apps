using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05Opg03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people1 = new List<Person>();

            try
            {
                people1 = Person.ReadCSVFile(@"D:\Datamatiker\4 semester\C-Sharp and Dot Net\Projects\Console Apps\L05Opg03\data1-1.csv");
                Console.WriteLine("Data successfully loaded");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
            }

            Console.WriteLine("Alle personer med en score under 2:");
            var people2 = people1.FindAll(p => p.Score < 2);
            foreach (Person p in people2) 
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("Alle personer med en lige score:");
            people2 = people1.FindAll(p => p.Score % 2 == 0);
            foreach (Person p in people2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("Alle personer med en lige score og weight større end 60:");
            people2 = people1.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
            foreach (Person p in people2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("Alle personer med en vægt deleligt med 3:");
            people2 = people1.FindAll(p => p.Weight % 3 == 0);
            foreach (Person p in people2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");

            // opg.5.4
            Console.WriteLine("Index på den første person med en score på præcis 3");
            int i = people1.FindIndex(0, people1.Count - 1, p => p.Score == 3);
            Console.WriteLine($"index: {i}, {people1[i]}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Index på den første person under 10 år, som har en score på 3");
            i = people1.FindIndex(0, people1.Count - 1, p => p.Score == 3 && p.Age < 10);
            Console.WriteLine($"index: {i}, {people1[i]}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Hvor mange personer er der over 10 år som har en score på 3?");
            int antal = (people1.FindAll(p => p.Score == 3 && p.Age > 10)).Count();
            Console.WriteLine($"Der er {antal} personer, der opfylder kravet.");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Index på den første person under 8 år, som har en score på 3");
            i = people1.FindIndex(0, people1.Count - 1, p => p.Score == 3 && p.Age < 8);
            if (i >= 0)
            {
                Console.WriteLine($"index: {i}, {people1[i]}");
            }
            else 
            {
                Console.WriteLine($"index: {i} => personen findes ikke!");
            }
            
            Console.WriteLine("------------------------------");

            // opg.5.5
            Console.WriteLine("People sorted by age (ascending)");
            people1.Sort(new SortByAge());
            foreach (Person p in people1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("People sorted by score (descending)");
            people1.Sort(new SortByScoreDesc());
            foreach (Person p in people1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");

            Console.ReadLine();
        }
    }
}
