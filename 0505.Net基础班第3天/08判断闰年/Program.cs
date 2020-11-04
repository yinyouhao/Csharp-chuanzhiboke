using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            Console.WriteLine("请输入需要判断的年份：");
            int year =Convert.ToInt32(Console.ReadLine());
            bool judgment = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            Console.WriteLine("关于这个年份是否为闰年的判断结果为：{0}", judgment);
            Console.ReadKey();
            }
                
          
            
            
        }
    }
}
