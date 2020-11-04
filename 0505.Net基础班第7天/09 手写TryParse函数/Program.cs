using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_手写TryParse函数
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool b = MyTryParse("123", out num);
            //bool b = int.TryParse("123", out num);
            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        public static bool MyTryParse(string str,out int number)
            //返回值的类型是bool类型，也就是这个方法的值；括号里面的是输入给的值，out规定的是返回过去的除了式子本身之外的值
        {
            number = 0;
            try
            {
                number = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
