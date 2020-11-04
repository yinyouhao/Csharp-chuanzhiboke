using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出一个数的二倍
            Console.WriteLine("请输入数字：");
            //string strNmuber = Console.ReadLine();
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("这个数字的二倍为：{0}", number*2);
            Console.ReadKey();
        }
    }
}
