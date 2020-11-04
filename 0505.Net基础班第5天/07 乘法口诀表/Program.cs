using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_乘法口诀表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =1 ; i <=9; i++)
            {
                for (int t = 1; t <=i; t++)
                {
                    int product = i * t;
                    Console.Write("{0}*{1}={2}\t",i,t,product);//console.writ()可以保证结果在一行输出
                }
                Console.WriteLine();//写一个空的输出行，可以让他换行输出
            }
            
            Console.ReadKey();
        }
    }
}
