using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02Opg1
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int i = -1;
            while (i != 0)
            {
                Console.WriteLine("Enter how many Fibonacci numbers you want to print: ");
                var input = Console.ReadLine();
                int input_tal = int.Parse(input);
                if (input_tal == 0) break;
                else {
                    int[] fibonacci = ArrayFibonacci(input_tal);
                    Console.WriteLine($"The first {input_tal} fibonacci numbers are: ");
                    foreach (int num in fibonacci) { 
                        Console.Write(num + ", ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
        // calculates Fibonacci numbers in a loop
        // tested and works
        static int CalcFibonacci(int n) {
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;
            if (n == 1) return f1;
            else if (n == 2) return f2;
            else {
                for (int i = 3; i <= n; i++)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
                }
            }
            return f2;
        }

        // recursive Fibonacci
        static int RecursiveFibonacci(int n)
        {
            if (n == 1) return 0;
            else if (n == 2) return 1;
            else return (RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2));
        }

        // returns an array with all the calculated Fibonacci numbers
        static int[] ArrayFibonacci(int n)
        {
            int[] nums = new int[n];
            for (int i = 0; i < n; i++) {
                nums[i] = RecursiveFibonacci((int)i + 1);
            }
            
            return nums;
        }
    }
}
