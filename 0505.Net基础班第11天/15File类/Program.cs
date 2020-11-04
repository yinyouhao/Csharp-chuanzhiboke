using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15File类
{
    class Program
    {
        static void Main(string[] args)
        {

            ////创建一个文件
            //File.Create(@"C:\Users\YY\Desktop\new.txt");
            //Console.WriteLine("创建成功");

            //删除一个文件
            //File.Delete(@"C:\Users\YY\Desktop\new.txt");
            //Console.WriteLine("删除成功");


            //复制一个文件
            File.Copy(@"C:\Users\YY\Desktop\new.txt", @"C:\Users\YY\Desktop\文件.txt");
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
    }
}
