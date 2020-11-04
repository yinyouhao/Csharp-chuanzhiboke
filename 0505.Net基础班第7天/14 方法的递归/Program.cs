using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_方法的递归
{
    class Program
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            TellStory();
            Console.ReadKey();
        }
        public static void TellStory()
        {
            Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            if (i >= 10)
            {
                return;
            }
            i++;
            TellStory();
        }
            
    }
    
}
