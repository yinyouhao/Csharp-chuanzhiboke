using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ref练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用方法来交换两个int类型的变量

            int n1 = 10;
            int n2 = 20;
            //不用中间变量
            //n1 = n1 - n2;
            //n2 = n1 + n2;
            //n1 = n2 - n1;

            Test(ref n1, ref n2);
            //ref函数能将变量放到方法中进行改变，并且将改变完成后的值送回方法。
            //在方法中无需对变量进行赋值，可是变量在进入方法之前需要进行赋值。
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();
        }
        public static void Test(ref int n1,ref int n2)
        {
            //使用了ref就不需要使用return函数
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
        }
    }
}
