using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自己练习
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 8.7895;
            //让数字仅保留两位小数的方法
            //法一：（能够四舍五入）
            Console.WriteLine("{0:0.00}",t);
            //法二：（也能四舍五入）
            Console.WriteLine(t.ToString("0.00"));  
            Console.ReadKey();
        }
    }
}
