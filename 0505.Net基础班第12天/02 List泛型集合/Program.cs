using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合
            List<int> number = new List<int>();
            number.Add(1);
            number.Add(2);
            number.Add(3);
            number.AddRange(new int[] {1,2,4,32 });
            number.AddRange(number);

            //List泛型集合可以转为数组
            int[] nums=number.ToArray();
            List<string> str = new List<string>();
            string[] stri = str.ToArray();



            for (int i = 0; i <number.Count; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();
        }
    }
}
