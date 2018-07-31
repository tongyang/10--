using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class Employee
    {
        public virtual void Punch()
        {
            Console.WriteLine("员工9点打卡");
        }
    }
}
