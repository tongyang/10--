using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriter与StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用StreamRead读取文本文件
            //using (StreamReader sr = new StreamReader(@"C:\Users\45294\Desktop\答复.txt", Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}

            // 使用StreamWrite写入文本文件
            using (StreamWriter sw = new StreamWriter(@"C:\Users\45294\Desktop\2.txt", true))
            {
                sw.Write("今天天气好晴朗");
            }
            Console.WriteLine("写入成功");
            Console.ReadKey();
        }
    }
}
