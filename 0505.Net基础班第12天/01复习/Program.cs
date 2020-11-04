using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1.子类可以赋值给父类（如果有一个方法需要父类作为参数，我们可以传递一个子类给他）
             2.如果父类中装的是子类对象，则可以将父类强制转换为子类
             */

            //Person P = new Student();
            ////is as
            //Student ss = P as Student;
            //ss.StudentSayHello();

            //if(P is Student)
            //{
            //    ((Student)P).StudentSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("bukeyizhuan");
            //}
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\YY\Desktop\新建文本文档.txt");
            //string s = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(s);

            ////没有这个文件会给创建一个，有的话会给覆盖
            //string str = "affdaff";
            //byte[] fa=Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\YY\Desktop\new.txt",fa);

            //string[] str=File.ReadAllLines(@"C:\Users\YY\Desktop\新建文本文档.txt");
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            string str = File.ReadAllText(@"新建文本文档.txt");
            Console.WriteLine(str);



            Console.ReadKey();
        }
    }
}
