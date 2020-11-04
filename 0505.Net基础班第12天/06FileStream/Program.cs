using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _06FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream 和 File的区别
            //FileStream     操作字节
            //StreamReader和StreamWriter  操作字符

            //使用FileStream来读取数据
            ////1、创建FileStream对象
            //FileStream fsRead = new FileStream(@"C:\Users\YY\Desktop\新建文本文档.txt", FileMode.OpenOrCreate, FileAccess.Read);//（文件地址，对文件的操作，对文件中数据的操作）
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////5M
            ////返回本次实际读取到的有效字节数
            //int r = fsRead.Read(buffer, 0, buffer.Length);//通过buffer来限制能读多少
            ////将字节数组中每一个元素按照指定的编码格式解码成字符串
            //string s = Encoding.Default.GetString(buffer, 0, r);
            ////关闭流
            //fsRead.Close();
            ////释放流所占用的空间
            //fsRead.Dispose();
            //Console.WriteLine(s);

            //使用FileStream来写入数据
            using(FileStream fsWrite=new FileStream(@"C:\Users\YY\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                string str = "覆盖";
                byte[] buffer = Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("写入OK");
            Console.ReadKey();
        }
    }
}
