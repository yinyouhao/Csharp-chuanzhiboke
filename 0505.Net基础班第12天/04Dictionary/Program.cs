using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2, "李四");
            dic.Add(3, "王五");
            foreach (var item in dic.Keys)
            {
                Console.WriteLine("{0}---{1}", item, dic[item]);
            }
            Console.ReadKey();
        }
    }
}
