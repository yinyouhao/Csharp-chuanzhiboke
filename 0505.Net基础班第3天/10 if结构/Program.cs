using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现：如果跪键盘的时间超过60分钟，那么媳妇奖励今晚的晚饭不用做了
            Console.WriteLine("请输入跪键盘的时间：");
            int minutes = Convert.ToInt32(Console.ReadLine());
            if (minutes > 60==true)
            //如果想表达的是==true时执行，就可以省略
            //如果想表达的是==false时执行，就不能省略
            
                Console.WriteLine("今晚的晚饭别做了");
            
            else
                Console.WriteLine("做晚饭吧你");
            Console.ReadKey();

        }
    }
}
