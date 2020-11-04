using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_if_else练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入小赵的成绩：");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score>=90)
            //{
            //    Console.WriteLine("获得100元奖励");
            //}
            //else
            //{
            //    Console.WriteLine("跪方便面吧");
            //}
            //Console.ReadKey();

            Console.WriteLine("请输入你的考试成绩");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
                Console.WriteLine("A");
            else if (score >= 80)//没有必要在写<90了
                Console.WriteLine("B");
            else if (score>=70)
                Console.WriteLine("C");
            else if (score>=60)
                Console.WriteLine("D");
            else if (score<60)
                Console.WriteLine("E");
            Console.ReadKey();
                
        }
    }
}
