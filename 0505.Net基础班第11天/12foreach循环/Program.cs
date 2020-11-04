using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12foreach循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1,2,2,555,789,455,7};
             for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("*************************");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
