using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _07_break关键字的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            while (i <= 10)
            {
                while (j <= 10)
                {
                    Console.WriteLine("我是里面的循环");
                    j++;
                    break;
                }
                Console.WriteLine("我是外面的循环");
                i++;
            }
            Console.ReadKey();

            //提示用户输入用户名和密码，用户名不是admin，密码不是88888就一直输入

            //bool n = true;
            //while (n)
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    string password = Console.ReadLine();
            //    if (name != "admin")
            //    {
            //        Console.WriteLine("用户名输入错误，请重新输入！");
            //    }
            //    else if(password!="88888")
            //    {
            //        Console.WriteLine("密码输入错误，请重新输入！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("登录成功");
            //        n = false;
            //    }
            //}
            //Console.ReadKey();

            //二
            //循环体：提示用户输入用户名 程序接受 密码 接受 判断是否登录成功
            //循环条件：用户名或者是密码错误
            //string name = "";
            //string password = "";
            //while(name!="admin"&&password!="88888")
            //{
            //    Console.WriteLine("请输入用户名：");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入用户密码：");
            //    password = Console.ReadLine();
            //}
            //Console.WriteLine("登录成功");
            //Console.ReadKey();


        }
    }
}
