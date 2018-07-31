using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class MobileDisk : Storage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘正在读取");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘正在写入");
        }
    }
}
