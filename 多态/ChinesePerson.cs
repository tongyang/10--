using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class ChinesePerson: Person
    {
        public ChinesePerson(string name): base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是{0}，我是中国人", this.Name);
        }
    }
}
