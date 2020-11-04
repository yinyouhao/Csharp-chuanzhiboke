using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_结构练习
{
    class Program
    {
        //public struct MyColor
        //{
        //    public int _red;
        //    public int _green;
        //    public int _blue;
        //}
        public struct Person
        {
            public string _name;
            public Gender _gender;
            public int _age;
        }

        public enum Gender
        {
            男,
            女
        }
        static void Main(string[] args)
        {
            //1.定义一个结构叫MyColor,有三个成员，分别定义为int类型的red，green，blue
            //声明一个MyColor类型的变量，并对其成员赋值，使MyColor可以表示成一个红色
            //MyColor myColor;
            //myColor._red = 255;
            //myColor._blue = 0;
            //myColor._green = 0;

            //2.定义一个结构类型Person，有三个成员，分别为姓名，性别，年龄 性别使用枚举类型
            //声明两个Person类型的变量，分别表示 张三 男 18岁/小兰 女 16岁
            Person zhangsan;
            zhangsan._name = "张三";
            zhangsan._gender = Gender.男;
            zhangsan._age = 22;

            Person lisi;
            lisi._name = "李四";
            lisi._gender = Gender.女;
            lisi._age = 21;

            Console.WriteLine("我叫{0}，今年{1}岁了，性别是{2}。",zhangsan._name,zhangsan._age,zhangsan._gender);
            Console.WriteLine(lisi._name);
            Console.ReadKey();
        }
    }
}
