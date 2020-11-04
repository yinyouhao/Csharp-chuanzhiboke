using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "张三";
            p.Age = 23;
            p.Gender = '男';
            p.Hello();
            

            Person l = new Person();
            l.Name = "李四";
            l.Age = 23;
            l.Gender = '女';
            l.Hello();
            Console.ReadKey();
        }
    }
}
