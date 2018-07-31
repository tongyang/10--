using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class RubberDuck: Duck
    {

        public override void Tweet()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }
}
