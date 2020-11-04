using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ArrayList的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //添加单个元素
            list.Add(true);
            list.Add(1);
            //添加集合元素
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            list.AddRange(list);
            //list.Clear();//清除所有元素
            //list.Remove(true);//移除单个元素
            //list.RemoveAt(0);//根据下标删除元素
            //list.RemoveRange(0, 3);//根据下标删除一定范围的元素
            //list.Sort();//升序排列
            list.Reverse();//反转
            list.Insert(1, "插入的");//在指定的索引位置插入元素
            list.InsertRange(0,new string[] { "张三", "李四" });//在指定的位置插入一个集合
            bool b=list.Contains(1);//判断是否包含某一个元素
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
