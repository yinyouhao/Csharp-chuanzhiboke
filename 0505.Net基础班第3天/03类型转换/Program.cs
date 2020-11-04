using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            // //显示类型转换 自动类型转换

            //string s = "123";
            // //将字符串转换为int或者double

            //double d = Convert.ToDouble(s);
            //Console.WriteLine(d);
            //Console.ReadKey();

            //让用户输入姓名，语文，数学，英语三科的成绩
            //给用户显示：**，你的总成绩为**分，平均成绩为**分
            Console.WriteLine("请输入您的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的语文成绩：");
            string chinese = Console.ReadLine();
            double chines = Convert.ToDouble(chinese);
            Console.WriteLine("请输入您的数学成绩：");
            string math = Console.ReadLine();
            double mat = Convert.ToDouble(math);
            Console.WriteLine("请输入您的英语成绩：");
            string English = Console.ReadLine();
            double Englis = Convert.ToDouble(English);
            Console.WriteLine("{0}，您好，您的成绩总分为{1},平均分为{2:0.00}",name,(chines+mat+Englis), (chines + mat + Englis)/3);
            Console.ReadKey();
        }
    }
}
