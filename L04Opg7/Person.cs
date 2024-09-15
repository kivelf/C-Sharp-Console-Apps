using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg7
{
    public delegate string FormatPersonName(string firstname, string lastname);

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // new method to generalise the formatting
        public void PrintPersonName(FormatPersonName formatter)
        {
            Console.WriteLine(formatter(FirstName, LastName));
        }

        // create the list of people as before
        public static List<Person> CreateListOfPeople()
        {
            return new List<Person>()
            {
                new Person() { FirstName = "Stephen", LastName = "King" },
                new Person() { FirstName = "George", LastName = "Martin" },
                new Person() { FirstName = "Ernest", LastName = "Hemingway" },
                new Person() { FirstName = "William", LastName = "Shakespeare" }
            };
        }
    }

    public class PersonUserClass
    {
        // method for formatting LastName, FirstName
        public static string FormatLastNameFirst(string firstname, string lastname)
        {
            return $"{lastname}, {firstname}";
        }

        // method for formatting LastName, FirstName in all caps
        public static string FormatAllCaps(string firstname, string lastname)
        {
            return $"{lastname.ToUpper()}, {firstname.ToUpper()}";
        }

        // method for formatting LastName, FirstName in lowercase
        public static string FormatLowerCase(string firstname, string lastname)
        {
            return $"{lastname.ToLower()}, {firstname.ToLower()}";
        }

        // method for formatting First Initial, LastName
        public static string FormatShortName(string firstname, string lastname)
        {
            return $"{firstname.Substring(0, 1)}. {lastname}";
        }

        // method to print all people using a specific format
        public static void PrintPeople(List<Person> people, FormatPersonName formatter)
        {
            foreach (var person in people)
            {
                person.PrintPersonName(formatter);
            }
        }

        public static void Main(string[] args)
        {
            var people = Person.CreateListOfPeople();

            while (true)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("How do you want to print the names?");
                Console.WriteLine("1: Last name followed by first name");
                Console.WriteLine("2: Last name followed by first name, all caps");
                Console.WriteLine("3: Last name followed by first name, lower case");
                Console.WriteLine("4: First initial followed by last name");
                Console.WriteLine("q: Quit");
                Console.Write("> ");
                var input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "1":
                        PrintPeople(people, FormatLastNameFirst);
                        break;
                    case "2":
                        PrintPeople(people, FormatAllCaps);
                        break;
                    case "3":
                        PrintPeople(people, FormatLowerCase);
                        break;
                    case "4":
                        PrintPeople(people, FormatShortName);
                        break;
                    case "Q":
                        return;
                    default:
                        Console.WriteLine("Unknown option, please try again.");
                        break;
                }
            }
        }
    }
}
