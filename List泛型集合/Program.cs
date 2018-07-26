using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            // 泛型集合
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            list.AddRange(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            int[] array = list.ToArray();
            List<int> listTwo = array.ToList<int>();
            //list.Clear();
            Console.WriteLine("================================================");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================================");
            for (int i = 0; i < listTwo.Count; i++)
            {
                Console.WriteLine(listTwo[i]);
            }
            Console.ReadKey();
        }
    }
}
