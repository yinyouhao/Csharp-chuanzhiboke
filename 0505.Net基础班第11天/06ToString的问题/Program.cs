using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ToString的问题
{
    class Program
    {
        static void Main(string[] args)
        {
            //我们将一个对象输出到控制台 默认情况下 打印的就是这个对象所在的类的命名空间
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(nums.ToString());
            Console.ReadKey();
        }
    }
}
