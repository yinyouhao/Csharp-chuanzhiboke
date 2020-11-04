using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////创建一个集合，里面添加一些数字，求平均值与和
            //ArrayList arr = new ArrayList();
            //for (int i = 0; i < 10; i++)
            //{
            //    arr.Add(i);
            //}
            //int sum = 0;
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    sum = sum + (int)arr[i];
            //}
            //Console.WriteLine("平均数为{0}", sum / arr.Count);

            //写一个长度为10的集合，要求在里面随机的存放10个数字（0-9）但是要求里面的数字不能重复
            Random r = new Random();
            ArrayList list = new ArrayList();
            
            for (int i = 0; i < 10; i++)
            {
                int rNumber = r.Next(0, 10);
                if (!list.Contains(rNumber))
                {
                    list[i] = rNumber;
                }
                else
                {
                    i--;
                }

            }



            Console.ReadKey();
        }
    }
}
