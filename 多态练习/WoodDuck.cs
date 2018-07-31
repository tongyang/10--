using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class WoodDuck: Duck
    {
        

        public override void Tweet()
        {
            Console.WriteLine("木头鸭子吱吱叫");
        }
    }
}
