using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _03_判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入需要判断的年份：");
                int year = Convert.ToInt32(Console.ReadLine());
                string judgment = Year(year);
                Console.WriteLine(judgment);
                Console.ReadKey();
            }
         
        }
        public static string Year(int year)
        {
            if((year%4==0&&year%100!=0)||(year%400==0))
            {
                return ("闰年");
            }
            else
            {
                return ("平年");
            }
        }
    }
}
