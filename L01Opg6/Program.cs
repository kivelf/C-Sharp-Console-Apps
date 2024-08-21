using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01Opg6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList();
            list.AddNumber(1);
            list.AddNumber(10);
            list.AddNumber(100);
            list.PrintNumbers();

            // Opg.7
            var randomList = new MyList();
            var rand = new Random();

            Console.WriteLine("\nRandom nums: ");
            for (int i = 0; i < 10; i++) { 
                randomList.AddNumber(rand.Next(1, 101));
            }

            randomList.PrintNumbers();
            Console.ReadLine();
        }
    }
}
