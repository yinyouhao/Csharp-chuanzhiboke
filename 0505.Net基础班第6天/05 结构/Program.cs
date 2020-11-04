using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_结构
{
    class Program
    {
        public struct Person
        {
            public string _name;//加public，加_以和变量区分开来
            public int _age;
            public  Gender _gender;
        }
        public enum Gender
        {
            男,
            女
        }
        static void Main(string[] args)
        {
            Person zhangsan;
            zhangsan._name = "张三";
            zhangsan._age = 22;
            zhangsan._gender =Gender.男;

            Person lisi;
            lisi._name = "李四";
            lisi._age = 21;
            lisi._gender = Gender.女;

            Console.WriteLine(zhangsan._name);
            Console.WriteLine(zhangsan._gender);
            Console.WriteLine(lisi._name);
            Console.WriteLine(lisi._gender);
            Console.ReadKey();
         
        }
    }
}
