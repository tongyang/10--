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
                // 按byte流进行读取
                //byte[] buffer = File.ReadAllBytes(Path.GetFullPath(@"C:\Users\45294\Desktop\1.txt"));
                //string s = Encoding.GetEncoding("UTF-8").GetString(buffer);
                //Console.WriteLine(s);

                // 按行读取
                //string[] strs = File.ReadAllLines(@"C:\Users\45294\Desktop\1.txt", Encoding.UTF8);
                //Hashtable ht = new Hashtable();
                //foreach (string item in strs)
                //{
                //    string[] contect = item.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                //    ht[contect[0]] = contect[1];
                //}

                //foreach (var item in ht.Keys)
                //{
                //    Console.WriteLine(ht[item]);
                //}

                // 按文本读取
                //string str = File.ReadAllText(@"C:\Users\45294\Desktop\1.txt", Encoding.UTF8);
                //Console.WriteLine(str);
            }
            else
            {
                string path = @"C:\Users\45294\Desktop\1.txt";
                string content = "asdadas啥都看的看见爱上大框架爱好的空间啊";
                File.WriteAllBytes(path, Encoding.UTF8.GetBytes(content));
                Console.WriteLine("文件创建成功");
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
