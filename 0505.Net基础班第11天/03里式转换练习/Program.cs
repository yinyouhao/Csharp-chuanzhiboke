using _02里式转换;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03里式转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] pers = new Person[3];//创建一个person类型的数组，可以将子类赋值给父类
            Random number = new Random();
            for (int i = 0; i < pers.Length; i++)//通过循环+生成随机数的方法，将数组中的每个父类元素赋值
            {
                int rNumber = number.Next(0, 3);
                switch (rNumber)
                {
                    case 0:pers[i] = new Student();
                        break;
                    case 1:pers[i] = new Person();
                        break;
                    case 2:pers[i] = new Teacher();
                        break;
                }
            }
            for (int i = 0; i < pers.Length; i++)
            {
                //Console.WriteLine(pers[i]);
                if(pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayHello();
                }
                else if (pers[i] is Student)
                {
                    ((Student)pers[i]).StudentSayHello();
                }
                else
                {
                    pers[i].PersonSayHello();
                }
            }
            Console.ReadKey();
        }
    }
}
