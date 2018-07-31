using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Person
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Person(string name)
        {
            this.Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
}
