using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11if结构的三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入您的年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 23)
            //    Console.WriteLine("到达法定结婚年级");
            //Console.ReadKey();

            Console.WriteLine("请输入老苏的语文成绩：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入老苏的音乐成绩：");
            int music = Convert.ToInt32(Console.ReadLine());
            if ((chinese > 90 && music > 80) || (chinese == 100 && music > 70)) 
            {
                Console.WriteLine("你可以获得100元的奖励");
            }
            Console.ReadKey();
        }
    }
}
