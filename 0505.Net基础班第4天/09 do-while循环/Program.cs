using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //小兰唱歌，唱一遍问一遍，知道老师满意为止
            //    //循环体：小兰唱歌 问老师 老师回答
            //    //循环条件：老师不满意
            //    string answer = "";
            //    do
            //    {
            //        Console.WriteLine("老师，请问您满意了吗");
            //        answer = Console.ReadLine();

            //    } while (answer!= "yes");
            //    Console.WriteLine("OK,回家");
            //    Console.ReadKey();

            //string name = "";
            //string password = "";
            //    do
            //    {
            //        Console.WriteLine("请输入用户名：");
            //        name = Console.ReadLine();
            //        Console.WriteLine("请输入用户密码：");
            //        password = Console.ReadLine();
            //        //Console.WriteLine("输入失败");
            //    } while (name != "admin" || password != "88888");
            //    Console.WriteLine("登录成功");
            //    Console.ReadKey();

            //不断要求用户输入一个数字，然后打印这个数字的而别，当用户输入为q时结束 ????
            //循环体：用户输入数字 打印它的二倍
            //循环条件：用户未输入q
            //string input = "";
            //do
            //{
            //    Console.WriteLine("请输入数字");
            //    input = Console.ReadLine();
            //    double number = Convert.ToInt32(input);
            //    Console.WriteLine("数字{0}的二倍为{1}。", number, number * 2);
            //} while (input != "q");
            //Console.ReadKey();

            //不断要求用户输入数字（假设用户输入的都是正整数），当用户输入end的时候，显示刚才输入的数字中的最大数字
            Console.WriteLine("请输入数字");
            string input="";
            int max = 0;
            while(input!="end")
            {
                try
                {
                    input = Console.ReadLine();
                    if (input == "end")
                        break;
                    int number = Convert.ToInt32(input);
                    if (number > max)
                    {
                        max = number;
                    }
                }
                catch
                {
                    Console.WriteLine("您输入的不是数字，无法转换，请重新输入");
                }
              
            }
            Console.WriteLine("其中最大的数字为{0}", max);
            Console.ReadKey();
        }
    }
}
