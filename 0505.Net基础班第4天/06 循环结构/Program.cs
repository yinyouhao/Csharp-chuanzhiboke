using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_循环结构
{
    class Program
    {
        static void Main(string[] args)
        {
            ////向控制台打印1000遍 下次考试我一定细心
            ////循环体：console.writeline("下次考试我一定细心“）
            ////循环条件：打印次数不够1000遍

            //int frequency = 1000;
            //while(frequency>0)
            //{
            //    frequency -= 1;
            //    Console.WriteLine("下次考试我一定细心\t{0}",frequency);
            //}
            //Console.ReadKey();

            //求1到100之间所有整数的和(1)
            //求1到100之间所有偶数的和（2）

            //循环体：将1到100之间的数循环相加
            //循环条件：数字还没有加完
            //int n = 1;
            //int sum = 0;//设置一个变量对和进行存储
            //while (n<=100)
            //{
            //    sum = sum + n;
            //    n++;//将n变大，实现从1到100
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //循环体：将1到100之间所有的偶数进行相加
            //循环条件:需要进行相加的偶数小于100
            int n = 2;//开始的值
            int sum = 0;//定义一个变量存储和
            while(n<=100)
            {
                sum = sum + n;
                n += 2;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
