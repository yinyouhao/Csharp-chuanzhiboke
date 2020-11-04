using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _13繁简转换
{
    class Program
    {
        private const string Jian = "一大堆简体字";
        private const string Fan = "一大堆簡體字";
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < Jian.Length; i++)
            {
                ht.Add(Jian[i], Fan[i]);
            }
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (!ht.ContainsKey(str[i]))//判断的只能是字符串中的一个元素，不能是一个字符串
                {
                    Console.WriteLine("没法转");
                }
                else
                {
                    Console.Write(ht[str[i]]);
                }
            }
            Console.ReadKey();
        }
    }
}
