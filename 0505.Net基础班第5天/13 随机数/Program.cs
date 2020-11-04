using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            ////产生随机数
            ////1、创建一个能够产生随机数的对象
            //Random r = new Random();
            ////创建对象的函数放在循环外面，不然每次循环都要开空间来放对象，会占用很大的内存空间
            //while (true)
            //{

            //    //2、让产生随机数的这个对象调用方法来产生随机数
            //    int rNumber = r.Next(1, 10);//左闭右开区间 最右边的取不到，最左边的能取到
            //    Console.WriteLine(rNumber);
            //    Console.ReadKey();
            //}

            //输入名字随机显示这个人上辈子是什么样的人
            //思路：
            //1、创建能够产生随机数的对象
            //2、产生随机数（1,7）
            Random r = new Random();
            while (true)
            {
                Console.WriteLine("请输入姓名：");
                string name = Console.ReadLine();
                int number = r.Next(1, 4);
                switch (number)
                {
                    case 1: Console.WriteLine("{0}is", name);
                        break;
                    case 2:Console.WriteLine("{0}isis", name);
                        break;
                    case 3:Console.WriteLine("{0}isisis", name);
                        break;
            }
                Console.ReadLine();

            }


        }
    }
}
