using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_数组的5个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            //练习1：从一个整数数组中取出最大的整数，最小的整数，总和，平均值
            //int[] number = new int[10];
            //int sum = 0;
            //Console.WriteLine(number.Length);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine("请输入第{0}个数字。", i);
            //    number[i] = Convert.ToInt32(Console.ReadLine());
            //    sum+= number[i];    
            //}
            //double average = sum / number.Length;
            //int max = number[0];
            //int min = number[0];
            //for (int j = 0; j < number.Length; j++)
            //{
            //    if (number[j] > max)
            //    {
            //        max = number[j];
            //    }
            //    if (number[j] < min)
            //    {
            //        min = number[j];
            //    }
            //}

            //Console.WriteLine("这组数据中最大的数字是{0}，最小的数字是{1}，总和为{2}，平均值为{3}", max, min, sum, average);

            //Console.ReadKey();
            #endregion

            #region 练习3
            //练习3：数组里面都是人的名字，分割为例如：老杨|老苏|老谢....
            //string str = "";
            //string[] name = { "老杨","老苏","老周","老赵","老李", };
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (i < name.Length - 1)
            //    {
            //        str += name[i] + "|";//字符串连接语句
            //    }
            //    else
            //    {
            //        str += name[i];
            //    }
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();
            #endregion

            #region 练习4
            //练习4：将一个整数数组的每一个元素进行如下处理：
            //如果元素是正数则将这个位置的元素加1；
            //如果元素是负数则将这个位置的元素减1，元素是0，则不变
            //int[] number = { 1, 2, -3, 4, 5, -6, 7, 8,0 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] < 0)
            //    {
            //        number[i] -= 1; 
            //    }
            //    else if(number[i]>0)
            //    {
            //        number[i] += 1;

            //    }
            //    Console.WriteLine(number[i]);

            //}
            //Console.ReadKey();
            #endregion

            //练习5：将一个字符串数组的元素的顺序进行反转。{"我","是","好人"}
            string[] name = { "我", "是", "好人" };
            string variables = "";
            for (int i = 0; i <name.Length/2; i++)
            {
                variables = name[i];
                name[i] = name[name.Length - 1 - i];
                name[name.Length - 1 - i] = variables;
            }
            for (int j = 0; j < name.Length; j++)
            {
                Console.WriteLine(name[j]);
            }
            Console.ReadKey();
        }
    }
}
