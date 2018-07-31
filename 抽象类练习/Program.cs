using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practice1();
            Practice2();
            Console.ReadKey();
        }

        public static void Practice2()
        {
            Computer cpu = new Computer(new Mp3());
            ((Mp3)cpu.Storage).Play();
            
        }

        public static void Practice1()
        {
            Geometry geometry = new Circle(3.3);

            geometry.Space();
            geometry.Perimeter();
            
        }
    }
}
