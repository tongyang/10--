using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字典集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("姓名", "童扬");
            dict.Add("性别", "男");
            dict.Add("年龄", "30");
            foreach (KeyValuePair<string, string> kv in dict)
            {
                Console.WriteLine("{0}-----{1}", kv.Key, kv.Value);
            }

            //foreach (string item in dict.Keys)
            //{
            //    Console.WriteLine(dict[item]);
            //}
            Console.ReadKey();
        }
    }
}
