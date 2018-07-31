using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class Mp3 : Storage
    {
        public override void Read()
        {
            Console.WriteLine("MP3正在读取");
        }

        public override void Write()
        {
            Console.WriteLine("MP3正在写入");
        }

        public void Play()
        {
            Console.WriteLine("MP3正在播放");
        }
    }
}
