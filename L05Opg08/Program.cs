using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05Opg08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

            Console.WriteLine("Returner alle two-digit integers sorteret i ascending order.");
            var orderedNums = numbers.Where(n => n.ToString().Length == 2).OrderBy(n => n).Select(n => n);
            foreach (int n in orderedNums) 
            { 
                Console.WriteLine(n);
            }

            Console.WriteLine("Returner alle two-digit integers sorteret i descending order.");
            orderedNums = numbers.Where(n => n.ToString().Length == 2).OrderByDescending(n => n).Select(n => n);
            foreach (int n in orderedNums)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Som i delopgave 1), men I stedet for integers, så skal der returneres strings");
            var orderedNumsAsStr = numbers.Where(n => n.ToString().Length == 2).OrderBy(n => n).Select(n => n.ToString());
            foreach (string n in orderedNumsAsStr)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Som i delopgave 2), men skal returnere string af typen “20 even”, “31 uneven”, etc…");
            orderedNumsAsStr = numbers.Where(n => n.ToString().Length == 2).OrderByDescending(n => n).Select(n => n.ToString() + ((n % 2 == 0) ? " even" : " odd"));
            foreach (string n in orderedNumsAsStr)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
