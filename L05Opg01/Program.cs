using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05Opg01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a list of integers
            List<int> numbers = new List<int> { 3, 6, 9, 12, 17, 22, 5, 18, 24, 30 };

            // find all even numbers and print them using ForEach
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers:");
            evenNumbers.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("------------------------------");

            // find the last number greater than 15
            var lastGreaterThan15 = numbers.LastOrDefault(n => n > 15);
            Console.WriteLine($"\nLast number greater than 15: {lastGreaterThan15}");

            // find the index of the last number greater than 15
            var lastIndexGreaterThan15 = numbers.FindLastIndex(n => n > 15);
            Console.WriteLine($"\nIndex of the last number greater than 15: {lastIndexGreaterThan15}");
            Console.ReadLine();
        }
    }
}
