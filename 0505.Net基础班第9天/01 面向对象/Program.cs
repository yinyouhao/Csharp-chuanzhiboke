using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Person类的对象
            Person zhangSan = new Person();//自定义类  和string str 具有相同的地位
            zhangSan.Name = "张三";
            zhangSan.Age = 23;
            zhangSan.Gender = '男';
            zhangSan.CHLSS();
            Console.ReadKey();
        }
    }
}
