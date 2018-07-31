using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("男人");
            JappenesePerson j1 = new JappenesePerson("渡边君");
            ChinesePerson c1 = new ChinesePerson("小名");
            Person p2 = new Person("女人");

            Person[] persons = new Person[]{ p1, j1, c1, p2 };
            foreach (Person p in persons)
            {
                p.SayHello();
            }
            Console.ReadKey();
        }
    }
}
