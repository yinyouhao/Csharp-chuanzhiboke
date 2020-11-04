using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_使用out参数做登录
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别提示用户输入用户名和密码
            //写一个方法判断用户输入是否正确
            //返回给用户一个登录结果，并且还要单独的返回给用户一个登录信息
            //如果用户名错误，除了返回登录结果外，还有返回一个“用户名错误”,“密码错误”。
            Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            Judgment(name, password);
            Console.ReadKey();

        }
        /// <summary>
        /// 判断用户名和密码是否输出入正确
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        public static void Judgment(string name,string password)//void类型，没有返回值，直接输出的字符串
        {
            if (name!= "admin")
            {
                Console.WriteLine("用户名输入错误！");
            }
            else if (password != "88888")
            {
                Console.WriteLine("密码输入错误！");
            }
            else
            {
                Console.WriteLine("登录成功！");
            }
        }
    }
}
