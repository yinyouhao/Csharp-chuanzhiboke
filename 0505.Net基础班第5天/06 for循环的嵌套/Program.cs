using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_for循环的嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您要展开的数字：");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= number; i++)
                {
                    // for (int j = 0; j <=number; j++)
                    //{
                    Console.WriteLine("{0}+{1}={2}", i, number - i, number);
                    //}
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("请输入有效数字");
            }

            Console.ReadKey();
        }
    }
}
