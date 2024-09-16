using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05Opg02
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of integers
            List<int> numbers = new List<int> { 3, 6, 9, 12, 17, 22, 5, 18, 24, 30, 101, 99, 45 };

            // query 1: find all even numbers using Query Methods
            var evenNumbersQueryMethod = numbers.Where(n => n % 2 == 0);

            // query 1: find all even numbers using Query Expressions
            var evenNumbersQueryExpression = from n in numbers
                                             where n % 2 == 0
                                             select n;

            // print even numbers (Query Method)
            Console.WriteLine("Even numbers (Query Method):");
            foreach (var num in evenNumbersQueryMethod)
            {
                Console.WriteLine(num);
            }

            // print even numbers (Query Expression)
            Console.WriteLine("\nEven numbers (Query Expression):");
            foreach (var num in evenNumbersQueryExpression)
            {
                Console.WriteLine(num);
            }

            // query 2: find all numbers with exactly two digits using Query Methods
            var twoDigitNumbersQueryMethod = numbers.Where(n => n.ToString().Length == 2);

            // query 2: find all numbers with exactly two digits using Query Expressions
            var twoDigitNumbersQueryExpression = from n in numbers
                                                 where n.ToString().Length == 2
                                                 select n;

            // print two-digit numbers (Query Method)
            Console.WriteLine("\nTwo-digit numbers (Query Method):");
            foreach (var num in twoDigitNumbersQueryMethod)
            {
                Console.WriteLine(num);
            }

            // print two-digit numbers (Query Expression)
            Console.WriteLine("\nTwo-digit numbers (Query Expression):");
            foreach (var num in twoDigitNumbersQueryExpression)
            {
                Console.WriteLine(num);
            }

            // sort and print the results (Query Method)
            var sortedTwoDigitNumbersQueryMethod = twoDigitNumbersQueryMethod.OrderBy(n => n);
            Console.WriteLine("\nSorted two-digit numbers (Query Method):");
            foreach (var num in sortedTwoDigitNumbersQueryMethod)
            {
                Console.WriteLine(num);
            }

            // sort and print the results (Query Expression)
            var sortedTwoDigitNumbersQueryExpression = from n in twoDigitNumbersQueryExpression
                                                       orderby n
                                                       select n;

            Console.WriteLine("\nSorted two-digit numbers (Query Expression):");
            foreach (var num in sortedTwoDigitNumbersQueryExpression)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
