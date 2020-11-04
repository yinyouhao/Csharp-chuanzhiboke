using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_方法概念
{
    class Program
    {
        static void Main(string[] args)
        {
            //比较两个数字的大小，返回最大的
            Console.WriteLine("请输入需要比较的数字：");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int m=Compare(n1, n2);
            Console.WriteLine(m);
            Console.ReadKey();

        }
        /// <summary>
        /// 比较两个数，将大的输出
        /// </summary>
        /// <param name="n1">第一个参数</param>
        /// <param name="n2">四二个参数</param>
        /// <returns></returns>
        public static int Compare(int n1,int n2)
        {
            int max = n1 > n2 ? n1 : n2;
            return max;
        }
    }
}
