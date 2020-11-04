using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //接受输入后判断其等级并显示出来
            //判断依据如下：等级=优（90-100），等级良（80-89）
            #region
            //while (true)
            //{
            //    Console.WriteLine("请输入分数");
            //    string scores = Console.ReadLine();
            //    Judgment(Transfor(scores));
            //    Console.ReadKey();
            //}
            #endregion

            //将字符串数组{"中国","美国","巴西","澳大利亚","加拿大"}中的内容反转
            #region
            //string[] country = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //string[] reverse = Country(country);
            //for (int i = 0; i < reverse.Length; i++)
            //{
            //    Console.WriteLine(reverse[i]);
            //}
            //Console.ReadKey();
            #endregion

            //写一个方法 计算圆的面积和周长
            Console.WriteLine("请输入半径");
            double radius = Convert.ToDouble(Console.ReadLine());
            double[] area=Area(radius);
            Console.WriteLine("面积是{0:0.00}，周长是{1:0.00}。", area[0], area[1]);
            Console.ReadKey();
        }
        #region
        /// <summary>
        /// 判断分数等级
        /// </summary>
        /// <param name="scores"></param>
        //public static void Judgment(int scores)
        //{
        //    if (scores <= 100 && scores >= 90)
        //    {
        //        Console.WriteLine("优");
        //    }
        //    else if (scores >= 80 && scores <= 89)
        //    {
        //        Console.WriteLine("良");
        //    }

        //}
        /// <summary>
        /// 将输入的字符转换为整型
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        //public static int Transfor(string score)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            int scores = Convert.ToInt32(score);
        //            return scores;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("请输入数字");
        //            score = Console.ReadLine();
        //        }
        //    }
        //}
        #endregion

        #region 数组元素反转
        //在用方法改变数组的值的时候，即使没有返回值，数组也会改变
        //public static string[] Country(string[] country)
        //{
        //    string medium = "";
        //    for (int i = 0; i < country.Length/2; i++)
        //    {
        //        medium = country[i];
        //        country[i] = country[country.Length - 1-i];
        //        country[country.Length - 1 - i] = medium;
        //    }
        //    return country;
        //}
        #endregion

        public static double[] Area(double radius)
        {
            double pi = 3.14;
            double[] area = { 3.14 * radius * radius, 2 * pi * radius };
            return area;
        }


    }
}
