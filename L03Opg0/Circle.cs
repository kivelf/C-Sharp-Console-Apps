using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg0
{
    public class Circle: Shape
    {
        private double radius;

        public Circle(double x, double y, double radius) : base(x, y) 
        { 
            this.radius = radius;
        }

        public double Radius 
        { 
            get { return radius; }
            set { radius = value; }
        }

        public override string ToString()
        {
            return $"Circle with radius {Radius}, [x: {X}, y: {Y}]";
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
