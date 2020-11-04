using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool b = int.TryParse("123", out number);
            Console.WriteLine(number);
            Console.WriteLine(b);
            Console.ReadKey();
            
        }
    }
}
