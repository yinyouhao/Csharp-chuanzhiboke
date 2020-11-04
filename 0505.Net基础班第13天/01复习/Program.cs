using System;
using System.Collections.Generic;
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
             泛型集合
             *List<T>
             *Dictionary<T,T>
             *装箱和拆箱
             *装箱：将值类型转换为引用类型
             *拆箱：将引用类型转换为值类型
             *我们应该尽量在代码中避免装箱或者拆箱
             *文件流
             *FileStream StreamReader和StreamWriter
             *多态：虚方法，抽象类，接口
             *虚方法:
             *抽象类:
             *
             */
            //List<int> list = new List<int>();//泛型集合

            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "张三");
            //dic[2] = "李四";
            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("{0}----{1}", kv.Key, kv.Value);
            //}
            //Console.ReadKey();

            //using(FileStream fsRead=new FileStream("new.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];

            //    //本次读取实际读取到的字节数
            //    int r=fsRead.Read(buffer, 0, buffer.Length);

            //    //将字节数组中的每个元素按照我们指定的编码格式解析成字符串
            //    string s = Encoding.UTF8.GetString(buffer, 0, r);
            //    Console.WriteLine(s);
            //}

            //using(FileStream fsWrite=new FileStream(@"C:\Users\YY\Desktop\new.txt", FileMode.Append, FileAccess.Write))
            //{
            //    string s = "fdafhafadfadfafd";
            //    byte[] buffer = Encoding.Default.GetBytes(s);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("OK");


            //虚方法和抽象类
            //老师可以起立，学生也可以起立 校长也可以起立

            //声明父类去指向子类对象
            Person p = new Student();
            p.StandUp();


            Console.ReadKey();
        }
    }

    public abstract class Person
    {
        public abstract void StandUp();
    }
    public class Student : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("学生起立说老师好");
        }
    }
    public class Teacher : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("老师起立");
        }
    }
    public class HeadMaster : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("校长起立");
        }
    }
}
