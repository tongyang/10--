using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱与拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            //ArrayList list = new ArrayList();
            List<int> list = new List<int>();
            sw.Start();
            for (int i = 0; i < 100000000; i++)
            {
                list.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

            //00:00:12.1788167
            //00:00:01.0935889

            int n = 1;
            IComparable j = n; // 装箱
        }
    }
}
