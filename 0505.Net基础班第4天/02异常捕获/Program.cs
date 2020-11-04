using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //语法上没有错误，但是在程序运行过程中，由于某种原因使得程序出现了错误，不能正常的运行
            int number = 0;//声明了一个变量
            bool b = true;
            Console.WriteLine("请输入一个数字：");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());//变量赋值
            }
            catch
            {
                Console.WriteLine("输入的内容不能转换为数字。");
                b = false;
            }
            if (b)
                {
                //如果我们执行下面的代码需要满足某些条件
                //让代码满足某些条件去执行的话就用bool类型
                Console.WriteLine(number * 2);//变量使用
            }
            Console.ReadKey();
        }
    }
}
