using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream类
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileStream：操作字节
            // StreamReader和StreamWriter：操作字符
            // 1、创建filestream对象
            FileStream fsReader = new FileStream(@"C:\Users\45294\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // 2、创建buffer
            byte[] buffer = new byte[1024 * 1024 * 5];
            // 3、读取文件流
            int r = fsReader.Read(buffer, 0, buffer.Length);
            // 4、将字节转为字符串
            string s = Encoding.UTF8.GetString(buffer, 0, r);
            // 5、关闭并释放资源
            fsReader.Close();
            fsReader.Dispose();

            Console.WriteLine(s);
            Console.ReadKey();

            //using (FileStream fsWriter = new FileStream(@"C:\Users\45294\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    string str = "你看我有木有把你覆盖掉";
            //    byte[] buffer = Encoding.UTF8.GetBytes(str);
            //    fsWriter.Write(buffer, 0, buffer.Length);
            //}

            //Console.WriteLine("写入成功");
            //Console.ReadKey();
        }
    }
}
