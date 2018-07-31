using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class Programer: Employee
    {
        public override void Punch()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
