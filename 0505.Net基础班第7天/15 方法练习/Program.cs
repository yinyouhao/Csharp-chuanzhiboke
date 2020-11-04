using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _15_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字，计算两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字之间的和
            //3、要求第一个数字必须比第二个数字小 不然就重新输入
            #region  自己写的
            //while (true)
            //{
            //    try
            //    {
            //            Console.WriteLine("请输入第一个数字：");
            //            double n1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("请输入第二个数字：");
            //            double n2 = Convert.ToDouble(Console.ReadLine());
            //            double s = Sum(n1, n2);
            //            Console.WriteLine(s);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入数字！");
            //    }
            //    Console.ReadKey();
            //}
            #endregion
            Console.WriteLine("请输入第一个数字：");
            string getNumber1 = Console.ReadLine();
            int number1 = GetNumber(getNumber1);
            Console.WriteLine("请输入第二个数字：");
            string getNumber2 = Console.ReadLine();
            int number2 = GetNumber(getNumber2);
            int sum=Sum(number1, number2) ;
            Console.WriteLine(sum);
            Console.ReadKey();

        }

        //  #region 自己定义的方法
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="n1">输入的第一个数字</param>
        ///// <param name="n2">输入的第二个数字</param>
        ///// <returns></returns>
        //public static double Sum(double n1, double n2)
        //{
        //    double sum = 0;
        //    if (n1 > n2)
        //    {
        //        Console.WriteLine("输入的第一个数字必须比第二个小，请重新输入！");
        //    }
        //    else
        //    {
        //        for (double i = n1 + 1; i < n2; i++)
        //        {
        //            sum += i;
        //        }

        //    }
        //    return sum;
        //}
        //#endregion

        /// <summary>
        /// 将输入的字符串转化为整型，
        /// 这个函数的优点就是设置了一个参数，调用两次，
        /// 这样可以保证避免在某一个参数输入错误时，程序的重新运行。
        /// </summary>
        /// <param name="s">输入的变量</param>
        /// <returns></returns>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入！");
                    s = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 求和函数
        /// </summary>
        /// <param name="n1">输入量1</param>
        /// <param name="n2">输入量2</param>
        /// <returns></returns>
        public static int Sum(int n1,int n2)
        {
            int sum = 0;
            if (n1 < n2)
            {
                for (int i = n1; i < n2; i++)
                {
                    sum += i;
                }   
            }
            else
            {
                Console.WriteLine("请重新输入！");
                string s1 = Console.ReadLine();
                n1 =GetNumber(s1);
                Console.WriteLine("请输入第二个数字：");
                string s2 = Console.ReadLine();
                n2 = GetNumber(s2);
                Sum(n1, n2);
            }
            return sum;
        }

    }
    
}


