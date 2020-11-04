using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str =@"F:\学习资料\PDF\C程序设计语言\C程序设计语言.pdf";

            Console.WriteLine(Path.GetFileName(str));

            Console.WriteLine(Path.GetFileNameWithoutExtension(str));

            Console.WriteLine(Path.GetExtension(str));

            Console.WriteLine(Path.GetDirectoryName(str));

            Console.WriteLine(Path.GetFullPath(str));

            Console.WriteLine(Path.Combine(@"fjafhaufh"));

        }
    }
}