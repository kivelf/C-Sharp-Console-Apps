using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02Opg5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyNormalMethod(-1);
            Console.ReadLine();
        }

        // throws an exception
        static private void MyMethodWithError(int num) {
            if (num <= 0) throw new ArgumentException("Antal <= 0");
            else Console.WriteLine("All is well!");
        }

        // catches the exception
        static public void MyNormalMethod(int num) {
            try
            {
                MyMethodWithError(num);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            finally 
            {
                Console.WriteLine("We have been in MyNormalMethod()");
            }
        }
    }
}
