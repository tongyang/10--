using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practice1();
            Practice2();
            Console.ReadKey();
        }

        public static void Practice1()
        {
            Duck d = new Duck();
            WoodDuck w = new WoodDuck();
            RubberDuck r = new RubberDuck();
            Duck[] ducks = new Duck[] { d, w, r };
            foreach (Duck duck in ducks)
            {
                d.Tweet();
            }
        }

        public static void Practice2()
        {
            Employee[] employees = new Employee[] { new Employee(), new Manager(), new Programer()};
            foreach (Employee e in employees)
            {
                e.Punch();
            }
        }
    }
}
