using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05Opg10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            Random rng = new Random();

            for (int i = 0; i < 100; i++) 
            { 
                nums.Add(rng.Next(100));
            }

            Console.WriteLine("Find antallet af ulige tal I listen:");
            Console.WriteLine(((from num in nums where num % 2 == 1 select num).Count()) + " ulige tal");

            Console.WriteLine("\nFind antallet af unikke tal I listen:");
            Console.WriteLine(nums.Distinct().Count() + " unikke tal");

            Console.WriteLine("\nFind de tre første ulige tal");
            var firstThreeOdds = nums.Where(n => n % 2 != 0).Take(3);
            foreach (int num in firstThreeOdds) 
            { 
                Console.WriteLine(num);
            }

            Console.WriteLine("\nFind alle unikke ulige tal");
            var uniqueOdds = nums.Where(n => n % 2 == 1).Distinct();
            foreach (int num in uniqueOdds)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
