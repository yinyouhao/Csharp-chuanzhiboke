using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_方法的三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            ////要求用户只能输入yes或者no改成方法

            ////这个方法做了什么事？
            ////只能让用户输入yes或者no，只要不是就要重新输入
            //Console.WriteLine("请输入字符：");
            //string str = Console.ReadLine();
            //Console.WriteLine(YesOrNo(str));
            //Console.ReadKey();
            #endregion

            //求输入数组的和
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumNumber = Sum(nums);
            Console.WriteLine(sumNumber);
            Console.ReadKey();


        }
        /// <summary>
        /// 计算一个整数类型数组的总和
        /// </summary>
        /// <param name="nums">要求总和的数组</param>
        /// <returns>返回这个数组的总和</returns>
        public static int Sum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        #region 练习1
        //public static string YesOrNo(string s)
        //{
        //    while (true)
        //    {
        //        if (s == "yes" || s == "no")
        //        {
        //            string judgment = "输入正确";
        //            return judgment;
        //        }
        //        else
        //        {
        //            Console.WriteLine("请重新输入");
        //            s = Console.ReadLine();
        //        }
        //    }

        //}
        #endregion
    }
}
