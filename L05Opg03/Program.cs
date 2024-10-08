﻿using System;
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

            // opg.5.6
            Console.WriteLine("Setting accepted to true:");
            people1.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
            foreach (Person p in people1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");

            // opg.5.7
            IEnumerable<Person> personsSorted = people1.OrderBy(p => p.Age);
            Console.WriteLine("Sorted by age using Linq:");
            foreach (Person p in personsSorted)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nOriginal list is still unsorted:");
            foreach (Person p in people1)
            {
                Console.WriteLine(p);
            }

            personsSorted = people1.OrderByDescending(p => p.Score);
            Console.WriteLine("Sorted by score (desc) using Linq:");
            foreach (Person p in personsSorted)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Using query expression - in ascending order:");
            var sort = from p in people1 orderby p.Score select p;
            foreach (Person p in sort) 
            { 
                Console.WriteLine(p);
            }

            // opg.5.9
            Console.WriteLine("\nResetting the ppl...");
            people1.Reset();
            foreach (Person p in people1)
            {
                Console.WriteLine(p);
            }

            // opg.5.11
            var groups =
                from p in people1
                let firstLetter = p.Name[0]
                orderby firstLetter
                group p by firstLetter;

            foreach (var letterGroup in groups)
            {
                Console.WriteLine($"Key: {letterGroup.Key}");
                foreach (var p in letterGroup)
                {
                    Console.WriteLine($"\t{p.Name}");
                }
            }

            // opg.5.12
            List<Person> people3 = new List<Person>();

            try
            {
                people3 = Person.ReadCSVFile(@"D:\Datamatiker\4 semester\C-Sharp and Dot Net\Projects\Console Apps\L05Opg03\data2-1.csv");
                Console.WriteLine("Data successfully loaded");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
            }

            var innerJoin = people1.Join(// outer sequence 
                      people3,  // inner sequence 
                      p1 => p1.Name,    // outerKeySelector
                      p3 => p3.Name,  // innerKeySelector
                      (p1, p3) => new  // result selector
                      {
                          p1Name = p1.Name,
                          p3Name = p3.Name
                      });

            foreach (var p in innerJoin) 
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}
