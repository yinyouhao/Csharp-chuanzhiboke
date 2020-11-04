using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int result = n++ + ++n*2+ --n + n++;
           // number++;
            Console.WriteLine(n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}//5 13 12 12
