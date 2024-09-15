using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Caroline", 44, 62.5));
            people.Add(new Person("Anne", 21, 57.8));
            people.Add(new Person("Emil", 48, 82.7));
            people.Add(new Person("Diana", 28, 66.3));
            people.Add(new Person("Bob", 36, 75.2));
            
            foreach (Person person in people) 
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("------------------------------");

            // sort by age
            people.Sort(new ByAgeSorter());
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("------------------------------");

            // using delegates/lambda expressions
            people.Sort((Person p1, Person p2)=> p1.Weight.CompareTo(p2.Weight));
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadLine();
        }
    }
}
