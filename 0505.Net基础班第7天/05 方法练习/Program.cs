using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _05_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                #region 我自己编的
                ////读取输入的整数，定义成方法
                ////多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入）
                //Console.WriteLine("请输入需要判断的字符串：");
                //string str = Console.ReadLine();
                //Console.WriteLine(GoBack(str));
                //Console.ReadKey();
                #endregion        

                Console.WriteLine("请输入一个数字：");
                string input = Console.ReadLine();
                int number = GetNumber(input);
                Console.WriteLine(number);
                Console.ReadKey();

            }

        }
        /// <summary>
        /// 这个方法用来判断用户数输入是否为数字（我编写）
        /// </summary>
        /// <param name="str">用户输入的待测试字符串</param>
        /// <returns></returns>
        //public static string GoBack(string s)
        //{
        //    try
        //    {
        //        double number = Convert.ToDouble(s);
        //        return "是数字";
        //    }
        //    catch
        //    {
        //        return "请输入数字";
        //    }
        //} 

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
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
