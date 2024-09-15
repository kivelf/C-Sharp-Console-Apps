using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg2
{
    public delegate void Warning(int temp);
    public class PowerPlant 
    { 
        private Warning _Warning;
        Random random = new Random();
        public PowerPlant() { }

        public void AddWarning(Warning wa) 
        { 
            _Warning += wa;
        }

        public void SetWarning(Warning wa)
        {
            _Warning = wa;
        }

        public void HeatUp() 
        { 
            int t = random.Next(101);
            if (t > 50) 
            {
                _Warning.Invoke(t);
            }
        }
    }
    internal class Program
    {
        public static List<string> warnings = new List<string>();
        private static void warningToConsole(int t) 
        {
            Console.WriteLine("Warning!! Temperature is " + t + "!");
        }

        private static void warningToSomewhereElse(int t) 
        {
            warnings.Add("Warning added to the list!");
        }
        static void Main(string[] args)
        {
            PowerPlant plant = new PowerPlant();
            plant.SetWarning(warningToConsole);

            for (int i = 0; i < 10; i++) 
            { 
                plant.HeatUp();
            }
            Console.WriteLine("------------------------------");

            plant.AddWarning(warningToSomewhereElse);
            plant.AddWarning(warningToConsole);
            for (int i = 0; i < 10; i++)
            {
                plant.HeatUp();
            }

            foreach (string s in warnings) 
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
