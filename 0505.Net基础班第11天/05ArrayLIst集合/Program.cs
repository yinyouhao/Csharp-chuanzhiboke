using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _05ArrayLIst集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建集合对象
            ArrayList list = new ArrayList();
            //集合：很多数据的一个集合
            //数组：长度不可变，类型单一
            //集合的好处：长度可以任意改变 类型随便
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.Add("张三");
            list.Add('男');
            list.Add(new int[] { 1, 2, 2 });
            Person per = new Person();
            list.Add(per);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void PersonSay()
        {
            Console.WriteLine("我是人类");
        }
    }
}
