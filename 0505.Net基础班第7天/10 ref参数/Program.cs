using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();

        }
        /// <summary>
        /// 设置一个方法，给工资加上500元奖金
        /// </summary>
        /// <param name="s">传递薪水的变量，由于前面加了ref，因此不用返回值</param>
        public static void JiangJin(ref double s)
        {
            s += 500;
        }
        
    }
}
