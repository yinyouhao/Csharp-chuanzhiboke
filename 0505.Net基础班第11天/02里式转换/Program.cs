using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02里式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //每一个类都直接或者间接继承object类，此为一切类型的基类
            //1、里式转换
            //1）子类可以赋值给父类：如果有一个地方需要一个父类作为参考，我们可以给一个子类代替
            //Teacher tea = new Teacher();
            //Person p = tea;

            //2）如果父类中装的是子类对象，那么可以将这个父类强转为子类对象
            Person p = new Teacher();//父类中装的是子类对象
            //is的用法
            //if (p is Teacher)
            //{
            //    Teacher ss = (Teacher)p;
            //    ss.TeacherSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}
            

            //as的用法
            Teacher t=p as Teacher;
            t.TeacherSayHello();
            Console.ReadKey();

        }
    }
}
