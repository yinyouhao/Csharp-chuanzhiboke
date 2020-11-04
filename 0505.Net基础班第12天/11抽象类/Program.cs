using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗会叫 猫也会叫
            //狗也叫，猫也叫，狗不是猫，猫不是狗，所以不好定父类，就用抽象类定
            Animal a = new Dog();//子类赋值给父类
            a.Bark();
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract void Bark();//抽象方法没有方法体，有大括号就有方法体
        //public void Test()
        //{
        //空实现
        //}
        public abstract string Name
        {
            get;
            set;
        }
    }
    public class Dog : Animal
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            Console.WriteLine("旺旺");
        }
    }
    public class Mao : Animal
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            Console.WriteLine("喵喵");
        }
    }

}
