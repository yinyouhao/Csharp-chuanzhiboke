using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04protected访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            
        }
    }
    public class Person
    {
        protected string _name;

        public string Name { get => _name; set => _name = value; }
    }
    public class Student :Person
    {
        public void Test()
        {
          
        }
    }
}
