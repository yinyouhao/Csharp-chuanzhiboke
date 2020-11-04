using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name();
            //name.number = 10;
            int sum=name.Count(10);//方法的调用，可能会需要传递参数
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
    public class Name
    {
        public int number;//字段的初始化
        int sum = 0;
        public int Count(int number)//方法的声明
        {
            for (int i = 0; i < number; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
