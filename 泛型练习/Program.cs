using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice1();
            //Practice2();
            Practice3();
        }

        // 将一个数组中的奇数放入一个集合中，再将偶数放入另一个集合中
        // 最终将两个集合合并为一个集合，并且奇数显示在左边，偶数显示在右边
        public static void Practice1()
        {
            int[] nums = { 1, 2, 3, 33, 22, 32, 4342, 5435, 131, 656, 13 };
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }
            List<List<int>> numList = new List<List<int>>();
            numList.Add(evens);
            numList.Add(odds);
            int max = evens.Count >= odds.Count ? evens.Count : odds.Count;
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < numList.Count; j++)
                {
                    if (numList[j].Count - 1 < i)
                    {
                        Console.Write("    ");
                        
                    }
                    else
                    {
                        Console.Write(numList[j][i]);
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // 提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
        public static void Practice2()
        {
            Console.WriteLine("请您输入一个字符串：");
            string str = Console.ReadLine();

            List<char> list = new List<char>();

            foreach (char ch in str)
            {
                list.Add(ch);
            }
            char[] chs = list.ToArray();

            foreach (var item in chs)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        // 统计 Welcome to China中每个字符出现的次数，不考虑大小写 
        public static void Practice3()
        {
            string str = "Welcome to China";
            str = str.ToLower();
            string[] strs = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
