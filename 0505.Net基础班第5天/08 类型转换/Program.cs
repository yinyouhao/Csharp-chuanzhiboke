using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            //参数 返回值
            bool b = int.TryParse("123", out number);
            //TryParse （1)能转换成功，转换的值给number，返回True （2）转换失败，number值为0.返回false，不会报异常
            Console.WriteLine(b);
            Console.WriteLine(number);
            //TryParse是一种方法 或者 函数？
            //
            Console.ReadKey();
        }
    }
}
