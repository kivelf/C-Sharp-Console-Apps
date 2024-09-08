using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[5];
            shapes[0] = new Rectangle(2, 3, 10, 5);
            shapes[1] = new Rectangle(4, 5, 20, 2);
            shapes[2] = new Circle(15, 10, 25);

            foreach (Shape shape in shapes)
            {
                if (shape != null)
                {
                    Console.WriteLine(shape.Area());
                }
            }

            Console.ReadLine();
        }
    }
}
