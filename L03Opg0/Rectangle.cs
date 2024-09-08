using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg0
{
    public class Rectangle: Shape
    {
        private double width;
        private double height;

        public Rectangle(double x, double y, double width, double height): base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public double Width 
        { 
            get { return this.width; } 
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public override string ToString() 
        { 
            return $"Rectangle; width {Width}, height {Height}, [x: {X}, y: {Y}]";
        }

        public override double Area()
        {
            return (this.width * this.height);
        }
    }
}
