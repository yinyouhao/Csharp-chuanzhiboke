using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _08ArrayList集合长度的问题
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            //count 表示这个集合中实际包含的元素个数
            //capcity 表示这个集合中可以包含的元素个数
            Console.ReadKey();
        }
    }
}
