using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_for循环的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1到100之间的所有整数和，偶数和，奇数和
            //int sum = 0;
            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }

            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //找出100到999之间的水仙花数
            //水仙花数指的是 这个百位数字的百位的立方+十位的立方+个位的立方==当前的这个百位数字
            //int digit = 0;
            //int decile = 0;
            //int percentile = 0;
            //for (int i = 100; i < 999; i++)
            //{
            //    percentile = i / 100;
            //    decile = (i % 100) / 10;
            //    digit =i% 10;
            //    if (i == percentile* percentile* percentile + decile* decile* decile + digit* digit* digit)
            //    {
            //        Console.WriteLine(i);
            //    }  
            //}
            //Console.ReadKey();


            //求1到100之间的质数
            //bool panduan = true;
            //int t = 2;
            //for (double i = 2; i <=100; i++)
            //{
            //    for (t=2; t <i; t++)
            //    {

            //        double yushu = i / t%1;
            //        if (yushu==0)
            //        {
            //            panduan= false;
            //        }
            //    }
            //    if(panduan)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    panduan = true;
                
            //}
            //Console.ReadKey();



        }
    }
}
