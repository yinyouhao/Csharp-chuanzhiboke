using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想要的笔记本品牌");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBooK(brand);
            nb.SayHello();
            Console.ReadKey();
        }
        /// <summary>
        /// 简单工厂的核心 根据用户的输入创建对象赋值给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static NoteBook GetNoteBooK(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Lenovo":nb = new Lenovo();
                    break;
                case "IBM":nb = new IBM();
                    break;
                case "Acer":nb = new Acer();
                    break;
                case "Dell":nb = new DELL();
                    break;
            }
            return nb;
        }
    }
    public abstract class NoteBook
    {
        public abstract void SayHello();
    }
    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("联想笔记本");
        }
    }
    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("宏碁");
        }
    }
    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("IBM");
        }
    }
    public class DELL : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("戴尔笔记本");
        }
    }
}
