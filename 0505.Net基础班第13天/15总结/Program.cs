using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15总结
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么时候用虚方法来实现多态？
            //什么时候用抽象类实现多态？
            //什么时候用接口实现多态？

            //真的鸭子会游泳，木头鸭子不会游泳，橡皮鸭子会游泳
            ISwimmingable swim = new RealDuck();
            swim.Swim();
            Console.ReadKey();

        }
    }
    public class RealDuck:ISwimmingable
    {
        public void Swim()
        {
            Console.WriteLine("真的鸭子靠脚游泳");
        }
    }
    public class MuDuck 
    {

    }
    public class XPDuck : ISwimmingable
    {
        public void Swim()
        {
            Console.WriteLine("橡皮鸭子飘着游泳");
        }
    }
    public interface ISwimmingable
    {
        void Swim();
    }
}
