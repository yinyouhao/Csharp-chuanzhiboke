using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zhangsan = new Person("张三",18,'男');
            //new:1 在内存中开辟一块空间 2 在开辟的空间里创建对象 3.调用对象的构造函数
            //3：调用构造函数时，可以传入一些参数，将传到构造函数中的三个值分别的赋值到对象的三个属性
            zhangsan.SayHello();
            Person.SayHelloTwo();//调用静态的，直接类名.函数名
            Console.ReadKey();
        }
    }
}
