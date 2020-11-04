using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////真的鸭子嘎嘎叫 木头鸭子吱吱叫 橡皮鸭子唧唧叫
            //RealDuck re = new RealDuck();
            //MuDuck mu = new MuDuck();
            //XPDuck xp = new XPDuck();
            //RealDuck[] ducks = { re, mu, xp };
            //for (int d = 0; d < ducks.Length; d++)
            //{
            //    ducks[d].Say();
            //}
            //

            //经理十一点打卡 员工9点打卡 程序员不打卡
            //JL jl = new JL();
            //YG yg = new YG();
            //CX cx = new CX();
            //JL[] jls = { jl, yg, cx };
            //for (int i = 0; i < jls.Length; i++)
            //{
            //    jls[i].DaKa();
            //}
            //Console.ReadKey();
        }
    }
    //public class RealDuck
    //{
    //    public virtual void Say()
    //    {
    //        Console.WriteLine("真的鸭子嘎嘎叫");
    //    }
    //}
    //public class MuDuck:RealDuck
    //{
    //    public override void Say()
    //    {
    //        Console.WriteLine("木头鸭子吱吱叫");
    //    }
    //}
    //public class XPDuck:RealDuck
    //{
    //    public override void Say()
    //    {
    //        Console.WriteLine("橡皮鸭子唧唧叫");
    //    }
    //}

    //public class JL
    //{
    //    public virtual void DaKa()
    //    {
    //        Console.WriteLine("经理十一点打卡");
    //    }
    //}
    //public class YG:JL
    //{
    //    public override void DaKa()
    //    {
    //        Console.WriteLine("员工9点打卡");
    //    }
    //}
    //public class CX:JL
    //{
    //    public override void DaKa()
    //    {
    //        Console.WriteLine("程序员不打卡");
    //    }
    //}
}
