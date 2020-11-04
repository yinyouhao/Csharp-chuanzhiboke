using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_continue练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：用while continue实现计算1到100（含）之间的除了能被7整除之外所有整数的和
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 7 != 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //找出100以内所有的素数
            //素数/质数：只能被1和这个数字本身整除
            //
            bool panduan = true;
            int t = 2;
           // double min = 0;
            for (double i = 2; i <=100; i++)
            {
                for (t=2; t <i; t++)
                {

                    double yushu = i / t%1;
                    if (yushu==0)
                    {
                        panduan= false;
                    }
                }
             //   t = 2;
                if(panduan)
                {
                    Console.WriteLine(i);
                }
                panduan = true;//panduan这个变量需要重新赋值，因为如果变为false后不重新赋值，以后就会一直是false 
            }
            Console.ReadKey();
        }
    }
}
