using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string str = null;
            //创建一个计时器，用来记录程序运行的时间
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计时
            for(int i = 0; i < 10000; i++)
            {
                str += i;
                sb.Append(i);
            }
            sw.Stop();//结束计时
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
