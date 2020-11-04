using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算两个参数之间的最大值
            int number=Program.GetMax(4, 60);
            Console.WriteLine(number);
            Console.ReadKey();

        }
        /// <summary>
        /// 计算两个参数之间的最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns></returns>
        public static int GetMax(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
