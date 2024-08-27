using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02Opg4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year is the person born in? ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What month is the person born in? ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What day is the person born on? ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime input_year = new DateTime(year, month, day);
            CalculateAge(input_year, out int age);
            Console.WriteLine($"The person is {age} years old");
            Console.ReadLine();
        }

        static void CalculateAge(DateTime BirthDateInput, out int age) {
            DateTime currentDate = DateTime.Today;
            age = currentDate.Year - BirthDateInput.Year;

            // if the current date is before the birthday this year, subtract 1
            if (currentDate < BirthDateInput.AddYears(age))
            {
                age--;
            }
        }
    }
}
