using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class Manager: Employee
    {
        public override void Punch()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }
}
