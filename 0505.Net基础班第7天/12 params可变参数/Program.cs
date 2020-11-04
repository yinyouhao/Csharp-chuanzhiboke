using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _12_params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test("张三",99999, 90, 32, 43, 52, 42);
            //Console.ReadKey();

            //求任意长度数组的最大值 整数类型的
            Max(90, 232, 32, 43, 2432, 4343);
            Console.ReadKey();
        }
        public static void Max(params int[] nums)
        {
            int max= nums[0];
            for (int i = 0; i <nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            Console.WriteLine(max);
        }
        /// <summary>
        /// 输出姓名，学号，总成绩。
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="id">学号</param>
        /// <param name="score">总成绩，用数组存储的，使用了params，因此必须放在最后</param>
        //public static void Test(string name, int id, params int[] score)
        //{

        //    int sum = 0;
        //    for (int i = 0; i < score.Length; i++)
        //    {
        //        sum += score[i];
        //    }
        //    Console.WriteLine("{0}这次考试的总成绩为{1},学号是{2}", name, sum, id);
        //}
    }
}
