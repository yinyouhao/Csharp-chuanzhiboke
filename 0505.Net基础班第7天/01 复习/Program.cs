using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_复习
{
    //public enum Gender
    //{
    //    男,
    //    女
    //}
    //public struct Person
    //{
    //    public string _name;
    //    public Gender _gender;
    class Program
    {
        static void Main(string[] args)
        {
        //Person zhangsan;
        //zhangsan._name = "zhangsan";
        //zhangsan._gender = Gender.女;
        ////常量 枚举 结构 数组
        ////const int number=10; //常量
        //Gender gender = Gender.女;
        //string s = "男";
        //Gender g=(Gender)Enum.Parse(typeof(Gender), s);//将字符串类型转换为枚举类型
        //Console.WriteLine(g);
        //Console.ReadKey();

        //数组 可以一次性存储多个相同类型的变量
        // int[] number = new int[10];

        //冒泡排序 我与老师的方法有些不同
        int[] nums = { 1, 2, 8, 56, 41, 23, 78 };
            Array.Sort(nums);
            Array.Reverse(nums);
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    for (int j = i+1; j < nums.Length; j++)
        //    {
        //        if (nums[i] > nums[j])
        //        {
        //            int number = nums[i];
        //            nums[i] = nums[j];
        //            nums[j] = number;
        //        }
         
        //    }
        //}
        for (int t = 0; t < nums.Length; t++)
        {
            Console.WriteLine(nums[t]);
        }
        Console.ReadKey();


        }
    }
}
