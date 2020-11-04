using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.Common;

namespace _05序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            ////序列化
            ////要将p这个对象 传输到对方的电脑
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 19;
            //p.Gender = '男';
            //using(FileStream fsWrite=new FileStream(@"C:\Users\YY\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            //接受对方发过来的二进制 反序列化为对象
            Person p;
            using (FileStream fsRead = new FileStream(@"C:\Users\YY\Desktop\111.txt", FileMode.OpenOrCreate))
            //课程中的代码这里是FileMode.OpenOrCreate，FileAccess.Write))当执行到最后显示流不可读，因此可以将FileAccess.Write删去
            {
                BinaryFormatter bf = new BinaryFormatter();
                p=(Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }
    [Serializable]
    public class Person
    {
        private string _name;
        private char _gender;
        private int _age;
        public string Name { get => _name; set => _name = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public int Age { get => _age; set => _age = value; }
    }
}
