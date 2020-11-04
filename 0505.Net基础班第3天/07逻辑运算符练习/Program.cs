using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07逻辑运算符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入老苏的语文和数学成绩，输出以下判断是否正确，正确输出True，错误输出false
            ////1）老苏的语文和数学成绩都大于90分
            //Console.WriteLine("请输出老苏的语文成绩：");
            //Console.WriteLine("请输出老苏的数学成绩：");
            //double chinese = Convert.ToInt32(Console.ReadLine());
            //double math = Convert.ToInt32(Console.ReadLine());
            //bool judgment = chinese > 90 && math > 90;
            //Console.WriteLine("结果为{0}", judgment);
            //Console.ReadKey();
            //2）语文和数学有一门大于90分
            Console.WriteLine("请输出老苏的语文成绩：");
            Console.WriteLine("请输出老苏的数学成绩：");
            double chinese = Convert.ToInt32(Console.ReadLine());
            double math = Convert.ToInt32(Console.ReadLine());
            bool judgment = chinese > 90 || math > 90;
            Console.WriteLine("结果为{0}", judgment);
            Console.ReadKey();

        }
    }
}
