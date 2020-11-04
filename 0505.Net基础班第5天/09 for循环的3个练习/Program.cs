using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_for循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习：循环录入5个人的年龄并计算平均年龄
            //如果录入的数据出现负数或者大于100的数，立即停止输入并报错
            //double sum = 0;
            //bool judgment = true;
            //try
            //{
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        Console.WriteLine("请录入第{0}个人的年龄", i);
            //        double age = Convert.ToDouble(Console.ReadLine());
            //        if (age > 100 || age < 0)
            //        {
            //            Console.WriteLine("请输入有效年龄");
            //            judgment = false;
            //            break;
            //        }
            //        sum += age;

            //    }
            //    if (judgment)
            //    {
            //        Console.WriteLine("这5个人的平均年龄为{0}", sum / 5);
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入有效字符。");
            //}

            //Console.ReadKey();


            //练习：在while中用break实现要求用户一直输入用户名和密码
            //只要不是admin，88888就一直提示要求重新输入。如果正确则提示成功
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("请输入用户密码：");
            //    string password = Console.ReadLine();
            //    if (name == "admin" && password == "88888")
            //    {
            //        break;
            //    }
            //    Console.WriteLine("输入错误，请重新输入");
            //}
            //Console.ReadKey();

            //1到100之间的整数相加，得到累加值大于20的当前数
            //比如1+2+3+4+5+6=21>20，输出为6
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                sum+=i;
                if (sum > 20)
                {
                    Console.WriteLine("累加值为{0}，此时i的大小为{1}。", sum, i);
                    break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
