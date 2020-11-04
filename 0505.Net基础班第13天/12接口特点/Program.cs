using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口特点
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Person();//new Person();
            fly.Fly();
            Console.ReadKey();
        }
    }
    public class Person:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人在飞");
        }
    }
    public class Bird : IFlyable
    {
        public void Fly()
        {

        }
    }
    public interface IFlyable
    {
        //不允许有访问修饰符 默认为public
        //方法，自动属性
        void Fly();
    }
    public interface M1:M2,M3
    {
        void Test1();
    }
    public interface M2
    {
        void Test2();
    }
    public interface M3
    {
        void Test3();
    }
    public class Car 
    {

    }
}
