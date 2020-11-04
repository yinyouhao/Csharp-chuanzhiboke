using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _01_方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////用方法实现：有一个字符串数组：
            ////{“马龙”，“迈克尔乔丹”，“雷吉米勒”，“蒂姆邓肯”，“科比布莱恩特”}，请输出最长的字符串
            #region
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string lang=Length(names);
            //Console.WriteLine(lang);
            //Console.ReadKey();
            #endregion

            //用方法实现：计算出一个整形数组的平均值，保留两位小数。
            #region
            //int[] number = { 1, 4, 5, 9, 8, 7, 3, 2 };
            //double avg = Avg(number);
            ////保留两位小数（1）将其转化为两位小数的字符串
            //string s = avg.ToString("0.00");
            //avg = Convert.ToDouble(s);
            //Console.WriteLine(avg);
            ////保留两位小数（2）
            ////Console.WriteLine("{0:0.00}", avg);
            ////Console.WriteLine(avg);
            //Console.ReadKey();
            #endregion  

            //写一个方法，判断用户输入的是不是质数
            //在写一个方法，要求用户只能输入数字
            Console.WriteLine("请输入需要判断的数字：");
            string enter =Console.ReadLine();
            Transfor(enter);
            Console.ReadKey();
        }
        public static void Judgment(int number)
        {
            if (number == 0 || number == 1)
            {
                Console.WriteLine("这个数字不是质数");
                return;
            }
            int min = 1;
            for (int i = 2; i < number; i++)
            {
                if (number % i <= min)
                {
                    min = number % i;
                }
            }
            if (min == 0)
            {
                Console.WriteLine("这个数字不是质数");
            }
            else
            {
                Console.WriteLine("这个数字是质数");
            }
        }
        public static void Transfor(string s)
        {
           // while (true)
           // {
                try
                {
                    int number = Convert.ToInt32(s);
                    Judgment(number);
                }
                catch
                {
                    Console.WriteLine("输入的不是数字，请重新输入：");
                    s = Console.ReadLine();
                    Transfor(s);
                }
            //}
            
        }

        /// <summary>
        /// 老师给的转换数据类型的方法
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    strNumber = Console.ReadLine();
                }
            }
        }
        
        /// <summary>
        /// 老师给出的判断质数的函数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        //给非质数准备的，只要有能整除的情况就直接跳出
                        return false;
                    }
                }
                //给质数准备的，只要前面没跳出去，这里就能执行
                return true;
            }
        }


        #region 字符串长度
        //public static string Length(string[] names)
        //{
        //    int max = names[0].Length;
        //    string lang = names[0];
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i].Length > max)
        //        {
        //            max = names[i].Length;
        //            lang = names[i];
        //        }

        //    }
        //     return lang;
        //}
        #endregion

        #region 计算数组的平均数
        //public static double Avg(int[] number)
        //{
        //    double sum = 0;
        //    for (int i = 0; i <number.Length; i++)
        //    {
        //        sum += number[i];
        //    }
        //    double average = sum / number.Length;
        //    return average;
        //}
        #endregion

    }
}
