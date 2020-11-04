using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06部分类
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public partial class Person//加上partial之后，就能取一个名字，同时对这个类进行编程
    {
        private string _name;
        public void Test()
        {

        }
    }
    public partial class Person
    {
        public void Test(string name)
        {

        }
    }
}
