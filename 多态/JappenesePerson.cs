using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class JappenesePerson: Person
    {
        public JappenesePerson(string name): base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我叫{0}，我是日本人", this.Name);
        }
    }
}
