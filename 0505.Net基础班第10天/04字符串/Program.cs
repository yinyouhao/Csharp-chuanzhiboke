using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "张三";
            //string s2 = "张三";
            //Console.ReadKey();

            //可以将string类型 看做一个char类型的只读数组
            string s = "abcdefg";
            //既然可以将string看做char类型的只读数组，所以我们可以通过下标去访问字符串中的某一个元素
            //s[0] = '0';  只读 无法赋值
            //首先将字符串转换为一个char类型的数组
            char[] chs=s.ToCharArray();
            chs[0] = 'b';
            //再将字符数组转换为字符串
            s = new string(chs);
            Console.WriteLine(s[0]);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
