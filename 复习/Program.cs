using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace 复习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 里式转换
            Person p = new Student();
            if (p is Student)
            {
                ((Student)p).StudentSayHello();
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            if (File.Exists(@"C:\Users\45294\Desktop\1.txt"))
            {
                byte[] buffer = File.ReadAllBytes(Path.GetFullPath(@"C:\Users\45294\Desktop\1.txt"));
                string s = Encoding.GetEncoding("UTF-8").GetString(buffer);
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("指定路径不存在！");
            }
            

            string temp = "今天天气真他妈的热";
            byte[] b = Encoding.UTF8.GetBytes(temp);
            File.WriteAllBytes(Path.GetFullPath(@"C:\Users\45294\Desktop\3.txt"), b);

            Console.ReadKey();
        }
    }

    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }

    }

    public class Student: Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
}
