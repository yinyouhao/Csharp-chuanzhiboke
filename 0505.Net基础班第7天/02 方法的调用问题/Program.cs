using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_方法的调用问题
{
    class Program
    {
        public static int _b = 10; //静态字段模拟全局变量法
        static void Main(string[] args)
        {
            int a = 3;
            int res=Test(a);//需要设置一个量接收返回的a
            Console.WriteLine(_b);
            Console.WriteLine(res);//然后输出接受到的值，直接输出a的话，a还是3
            Console.ReadKey();
        }
        public static int Test(int a)//被调用者需要使用调用者的值1）传递参数法
        {
            a = a + 5;
            return a;
        }
        public static void TestTwo()//被调用者需要使用调用者的值2）静态字段模拟全局变量法
        {
            _b = _b + 5;
        }
    }
}
