using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ////练习1：随机输入你心中想到的名字，然后输出它的字符串长度 Length：可以得到字符串的长度
            //Console.WriteLine("请随机输入名字");
            //string name = Console.ReadLine();
            //Console.WriteLine(name.Length);
            //Console.ReadKey();

            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////将字符串转换成大写
            ////lessonOne=lessonOne.ToUpper();
            ////将字符串转换为小写
            ////lessonOne = lessonOne.ToLower();
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////lessonTwo = lessonTwo.ToUpper();
            ////lessonTwo = lessonTwo.ToLower();
            ////if (lessonOne.ToUpper() == lessonTwo.ToUpper())
            //if(lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你俩喜欢的课程不相同");
            //}
            //Console.ReadKey();


            //string s = "a d v ; _  kd";
            ////分割字符串
            //char[] chs = {' ',';','_'};
            //string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);

            ////string[] chs = { " ",";","_","''" };
            ////string[] str=s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            ////for (int i = 0; i < str.Length; i++)
            ////{
            ////    Console.WriteLine(str[i]);
            ////}

            //Console.ReadKey();


            ////练习：从日期字符串（“2008-08-08”）中分析出年、月、日：2008年08月08日
            ////让用户输入一个日期格式如：2008-08-08，你输出的日期为2008年1月2日
            //Console.WriteLine("请输入日期：");
            //string year = Console.ReadLine();
            //char[] chs = { '-' };
            //string[] years = year.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",years[0], years[1],years[2]);
            //Console.ReadKey();

            //string str = "国家关键人物老赵";
            //if (str.Contains("老赵"))
            //{
            //    str=str.Replace("老赵", "**");//将老赵替换为**
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();

            ////Substring 截取字符串
            //string str = "春眠不觉晓";
            //str=str.Substring(2, 2);//前一个数字是截取的开始，第二个是截取几个
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "春眠不觉晓";
            //if (str.EndsWith("晓")) //判断字符串是否以给定的字符结尾     StartWith()是否以给定的开始
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //Console.ReadKey();


            //string str = "春眠不觉晓";
            //int index = str.IndexOf('不');//拿到第一次出现的位置   str.LastIndexOf('') 找到最后一次出现的位置
            //Console.WriteLine(index);
            //Console.ReadKey();

            ////LastIndexOf   Substring
            //string path = @"c:\a等\s\d\e等\f\c\s\w\f\等等";
            //int index = path.LastIndexOf('\\');
            //path = path.Substring(index+1);
            //Console.WriteLine(path);
            //Console.ReadKey();

            //string str = "     hahahhaha    ";
            ////str = str.Trim();//去掉两端的空格
            ////str = str.TrimStart();//去掉开头
            //str = str.TrimEnd();//去掉最后
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "";
            //if (string.IsNullOrEmpty(str))//判断空或者是null
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //Console.ReadKey();

            string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            string newNames=string.Join("|", names);
            Console.WriteLine(newNames);
            Console.ReadKey();
        }
    }
}
