using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg1
{
    public static class StrExt 
    {
        // adding a new method to the string class
        public static bool Lang(this string s) 
        { 
            if (s.Length <= 5) return false;
            else return true;
        }

        public static bool Lang(this string s, int n)
        {
            if (s.Length <= n) return false;
            else return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("a double pumpkin spice skimmed frappuccino please");
            list.Add("abcde");
            list.Add("september");
            list.Add("rain");

            foreach (string s in list)
            {
                Console.WriteLine("'" + s + "'" + " longer than 5? " + s.Lang());
            }
            Console.WriteLine("------------------------------");

            foreach (string s in list)
            {
                int num = 10;
                Console.WriteLine("'" + s + "'" + $" longer than {num}? " + s.Lang(num));
            }
            Console.ReadLine();
        }
    }
}
