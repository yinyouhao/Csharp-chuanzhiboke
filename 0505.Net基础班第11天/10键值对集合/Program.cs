using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个键值对集合对象
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误的");
            ht[4] = "kfaojg";//通过这种方法也可以添加数据
            //ht.Add(1, "李四");//通过这种方法不能把某个键的值替换
            ht[1] = "把张三干掉";//这种方法可以替换某一个键的值

            if (!ht.ContainsKey("abc"))
            {
                ht.Add("abc", "cba");
            }
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是：{0}，对应的值是{1}", item, ht[item]);
            }
            Console.ReadKey();
        }
    }
}
