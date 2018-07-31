using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态与抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();// new Cat()
            dog.Bark();
            Console.ReadKey();
        }
    }
}
