using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算任意多个数之间的最大值（提示：用params）
            //int max = GetSum(1, 5, 8, 65, 42, 4, 6);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //通过冒泡排序对数组进行升序排列{1,3,5,7,90,2,4,6,8,10}
            //int[] number = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //Order(number);
            //for (int i = 0; i <number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            //Console.ReadKey();

            //将一个字符串数组输出成以|分割的形式，比如梅西|卡卡|郑大世
            string[] name = { "梅西", "卡卡", "郑大世" };
            Order(name);
            Console.ReadKey();
        }
        #region 获得数字中的最大值
        //public static int GetSum(params int[] nums)
        //{
        //    int max = nums[0];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] > max)
        //        {
        //            max = nums[i];
        //        }
        //    }
        //    return max;
        //}
        #endregion

        //冒泡排序
        public static void Order(int[] number)
        {
            int n = 0;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 1+i; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        n = number[i];
                        number[i] = number[j];
                        number[j] = n;
                    }
                }
            }
        }

        public static void Order(string[] name)
        {
            for (int i = 0; i < name.Length-1; i++)
            {
                Console.Write(name[i] +"|");
            }
            Console.Write(name[name.Length-1]);

        }
        
    }
}
