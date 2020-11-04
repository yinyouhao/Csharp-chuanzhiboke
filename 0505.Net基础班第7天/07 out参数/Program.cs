using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法 求一个数组中的最大值，最小值，总和，平均值
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //  int[] result = GetNum(nums);
            int max;
            int sum;
            int avg;
            int min;
            GetNum(nums, out max, out min, out sum, out avg);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);

            Console.ReadKey();
        }
        #region
        /// <summary>
        /// 求数组的最大值，最小值，总和和平均值的方法
        /// </summary>
        /// <param name="nums">存储计算后的结果并返回</param>
        /// <returns></returns>
        //public static int[] GetNum(int[] nums)
        //{
        //    int[] res = new int[4];
        //    res[0] = nums[0];//最大值
        //    res[1] = nums[0];//最小值
        //    res[2] = 0;//总和
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if(nums[i]>res[0])
        //        {
        //            res[0] = nums[i];
        //        }
        //        if (nums[i] < res[0])
        //        {
        //            res[1] = nums[i];
        //        }
        //        res[2] += nums[i];
        //    }
        //    res[3] = res[2] / nums.Length;//平均值
        //    return res;
        //}
        #endregion

        //  #region 使用out做
        public static void GetNum(int[] nums, out int max, out int min, out int sum, out int avg)
            //void类型 该方法并没有返回值
        {
            //out参数要求唉方法的内部必须为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;//平均值
        }
       // #endregion

    }
}
