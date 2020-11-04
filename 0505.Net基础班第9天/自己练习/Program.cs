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
            City beijing = new City();
            beijing._name = "北京";
            beijing._history = "好几千";
            beijing.XianShi();
            Console.ReadKey();
        }
    }
}
