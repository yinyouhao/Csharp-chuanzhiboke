using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05泛型集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.将一个数组中的奇数放到一个集合中，在将偶数放到另一个集合中，
            //最终将两个集合合并，并且奇数在左边，偶数在右边
            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //ArrayList listOne = new ArrayList();
            //ArrayList listTwo = new ArrayList();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        listOne.Add(numbers[i]);
            //    }
            //    else
            //    {
            //        listTwo.Add(numbers[i]);
            //    }
            //}
            //listOne.AddRange(listTwo);
            //for (int i = 0; i < listOne.Count; i++)
            //{
            //    Console.Write(listOne[i]);
            //}

            //2.提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            //Console.WriteLine("请输入一个字符串");
            //string str = Console.ReadLine();
            //char[] chs = new char[str.Length];
            //int i = 0;
            //foreach (var item in str)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //chs.Append('1');
            ////char[] chs=list.ToArray();
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}

            //3.统计Welcome to china 中每个字符出现的次数，不考虑大小写
            string str = "Welcome to china";
            Dictionary<char, int> dic = new Dictionary<char, int>();//字母做键，次数做值，建立键值对
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    continue;//如果是空格，转回去继续执行循环
                }
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }
            foreach (var item in dic.Keys)
            {
                Console.WriteLine("{0}----{1}", item, dic[item]);
            }
            Console.ReadKey();
        }
    }
}
