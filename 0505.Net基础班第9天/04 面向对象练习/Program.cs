using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {

            Student wanger = new Student("王二", 50, 52, 65);
            Student zhangsan = new Student("张三", '男', 23,99,85,87);
            //zhangsan.Name = "张三";
            //zhangsan.Gender = '男';
            //zhangsan.Age = 23;
            //zhangsan.Chinese = 99;
            //zhangsan.Math = 85;
            //zhangsan.English = 87;
            zhangsan.ChengJi();

            Student lisi = new Student("李四", '中', -23,199,85,87);
            //lisi.Name = "李四";
            //lisi.Gender = '中';
            //lisi.Age = -23;
            //lisi.Chinese =199;
            //lisi.Math = 85;
            //lisi.English = 87;
            lisi.ChengJi();
            Console.ReadKey();

        }
    }
}
