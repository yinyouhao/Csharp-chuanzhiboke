using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //int u = 0;
            //int nu = 0;
            //int[] number = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    for (int j = i+1+u; j < number.Length; j++)
            //    {
            //        u++;
            //        if (number[i] > number[j])
            //        {
            //            nu = number[i];
            //            number[i] = number[j];
            //            number[j] = nu;
            //        }
            //    }
            //}
            //for (int t = 0; t < number.Length; t++)
            //{
            //    Console.WriteLine(number[t]);
            //}
            //Console.ReadKey();

            int[] nums={9,8,5,6,1,2,4,3,0};
            for (int i = 0; i < nums.Length; i++)
			{
                for (int j = i+1; j < nums.Length; j++)
			{
                    //if(nums[j]<nums[i])
                    //{
                    //    int str=nums[j];
                    //    nums[j]=nums[i];
                    //    nums[i]=str;
                    //}
			}
			}
             for (int t = 0; t < nums.Length; t++)
            {
                Console.WriteLine(nums[t]);
            }
             Console.ReadKey();
            


        }
    }
}
