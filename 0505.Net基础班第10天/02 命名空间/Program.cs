using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _01_复习;
namespace _02_命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zhangsan = new Person();
            zhangsan.Name = "张三";
            Console.WriteLine(zhangsan.Name);
            Console.ReadKey();
           
        }
    }
}
