using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //三个鸭子 真鸭子 木头鸭子 橡皮鸭子 叫的方法不同 真鸭子可以自己游泳，橡皮鸭子靠电动机游泳，木头鸭子不会游泳
            //RealDuck rd = new MuDuck();
            //rd.Bark();
            //Console.ReadKey();

            Swiming s = new RealDuck();
            s.Swim();
            Console.ReadKey();

        }
    }

    public interface Swiming
    {
        void Swim();
    }
    public class RealDuck:Swiming
    {
        public virtual void Bark()
        {
            Console.WriteLine("真的鸭子嘎嘎叫");
        }
        public void Swim()
        {
            Console.WriteLine("真的鸭子会游泳");
        }
    }
    public class MuDuck : RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("木头鸭子吱吱叫");
        }
    }

    public class XiangPiDuck : RealDuck,Swiming
    {
        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
        public void Swim()//子类的方法和父类写的一样的话会隐藏
        {
            Console.WriteLine("橡皮鸭子靠着发动机游泳");
        }
    }

}
