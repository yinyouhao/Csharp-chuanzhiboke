using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //记者：我是记者 我的爱好是偷拍 我的年龄是34 我是一个男狗仔
            //司机：我叫舒马赫 我的年龄是43 我是男人 我的驾龄是23年
            //程序员：我叫孙权 我的年龄是23 我是男生 我的工作年限是3年

            Reporter rep = new Reporter("记者",34,'男',"偷拍");
            rep.ReporterSayHello();

            Driver drive = new Driver("舒马赫", '男', 43, 23);
            drive.DriverSayHello();

            Programmer pro = new Programmer("孙权", '男', 23, 3);
            pro.ProgrammerSayHello();
            Console.ReadKey();

        }
    }
}
