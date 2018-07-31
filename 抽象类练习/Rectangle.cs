using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class Rectangle : Geometry
    {
        private double _lengthy;
        private double _widthy;

        public double Lengthy { get => _lengthy; set => _lengthy = value; }
        public double Widthy { get => _widthy; set => _widthy = value; }

        public Rectangle(double lengthy, double widthy)
        {
            this.Lengthy = lengthy;
            this.Widthy = widthy;
        }

        public override void Perimeter()
        {
            Console.WriteLine("周长为{0}", 2 * this.Lengthy * this.Widthy);
        }

        public override void Space()
        {
            Console.WriteLine("面积为{0}", this.Widthy * this.Lengthy);
        }
    }
}
