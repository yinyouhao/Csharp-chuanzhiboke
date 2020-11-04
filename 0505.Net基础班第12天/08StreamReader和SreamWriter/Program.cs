using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08StreamReader和SreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用StreamReader来读取一个文本文件
            //using (StreamReader sr = new StreamReader(@"C:\Users\YY\Desktop\new.txt"))
            //{
            //    while(!sr.EndOfStream)//当没读到文件尾时
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }

            //}

            using (StreamWriter sw=new StreamWriter(@"C:\Users\YY\Desktop\new.txt",true))
            {
                
                sw.Write("呜呼啦呼");
            }
            Console.WriteLine("写入成功");
            Console.ReadKey();
        }
    }
}
