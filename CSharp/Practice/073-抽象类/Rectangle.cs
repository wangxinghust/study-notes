using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_抽象类
{
    class Rectangle : Shape
    {
        private double _long;
        public double Long
        {
            get { return _long; }
            set { _long = value; }
        }
        private double _width;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public Rectangle(double lon, double width)
        {
            this.Long = lon;
            this.Width = width;
        }

        public override double GetArea()
        {
            return this.Long * this.Width;
        }

        public override double GetPerimeter()
        {
            return (this.Long + this.Width) * 2;
        }
    }
}
