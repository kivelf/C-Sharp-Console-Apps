using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg0
{
    public class Shape
    {
        private double x, y;

        public Shape(double x, double y) 
        { 
            this.x = x;
            this.y = y;
        }

        // parameterless constructor that initializes x and y to 1
        public Shape() : this(1, 1)
        {
            // this constructor calls the above constructor with 1.0 for x and y
        }

        public double X 
        { 
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
