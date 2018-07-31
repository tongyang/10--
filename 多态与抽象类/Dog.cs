using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态与抽象类
{
    class Dog: Animal
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            Console.WriteLine("汪汪叫");
        }

        
    }
}
