using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class Circle : Geometry
    {
        private double _radius;

        public double Radius { get => _radius; set => _radius = value; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override void Perimeter()
        {
            Console.WriteLine("周长为{0}", 2 * Math.PI * this.Radius);
        }

        public override void Space()
        {
            Console.WriteLine("面积为{0}", Math.PI * this.Radius * this.Radius);
        }
    }
}
