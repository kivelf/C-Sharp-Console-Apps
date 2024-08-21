using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01Opg6
{
    public class MyList
    {
        // private list of integers
        private List<int> numbers;

        // constructor to initialise the list
        public MyList()
        {
            numbers = new List<int>();
        }

        // method to add a number to the list
        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        // method to print all the numbers in the list using a for-each loop
        public void PrintNumbers()
        {
            // loop through each number in the list and print it
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
