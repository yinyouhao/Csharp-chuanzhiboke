using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            ////计算两个数字的大小，求出最大的
            ////三元表达式：
            //Console.WriteLine("请输入第一个数字：");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字：");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //double max=number1 > number2 ? number1 : number2;
            //Console.WriteLine("表达式的结果为{0}。",max);
            //Console.ReadKey();

            //提示用户输入一个姓名，只要输入的不是老赵，就全是流氓
            Console.WriteLine("请输入用户姓名：");
            string name = Console.ReadLine();
            string name1 = name== "老赵" ? "流氓" : "帅哥";
            Console.WriteLine(name1);
            Console.ReadKey();
        }
    }
}
