using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。“abc”+“cba”
            //Console.WriteLine("输入");
            //string enter = Console.ReadLine();//字符串本质上就是一个存储字符的数组
            //char[] chs = enter.ToCharArray();//将字符串转换为一个char类型的数组，然后将其中的字符两两互换
            //for (int i = 0; i < chs.Length/2; i++)
            //{
            //    char zhong = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = zhong;
            //}
            //for (int i = 0; i < chs.Length; i++)
            //{
            //    Console.Write(chs[i]);
            //}

            //倒序循环
            //for (int i = enter.Length-1; i>=0; i--)
            //{
            //    Console.Write(enter[i]);
            //}



            //练习2：将“hello c sharp"反转为"sharp c hello"
            //string str = "hello c sharp";
            //char[] chs = { ' ' };
            //string[] zhong=str.Split(chs);
            //for (int i = zhong.Length-1; i>=0; i--)
            //{
            //    Console.Write(zhong[i]+' ');
            //}


            //课上练习3：从Email中提取用户名和域名：abc@163.com
            //string email = "abc@163.com";
            ////Console.WriteLine("用户名为：{0}", email.Substring(0, 3));
            ////Console.WriteLine("域名为：{0}", email.Substring(4));
            //int index = email.IndexOf('@');
            //string userName = email.Substring(0, index);
            //string yuMing = email.Substring(index + 1);
            //Console.WriteLine(yuMing);
            //Console.WriteLine(userName);


            ////课上练习4：文本文件中存储了多个文章标题、作者，
            ////标题和作者之间用若干空格隔开，每行一个，标题有的长有的短，输出到控制台的时候最多标题长度为10
            ////如果超过10，则截取长度为8的字符串并且最后添加"..."，加一个竖线后输出作者的名字
            //string path = @"C:\Users\YY\Desktop\1.txt";
            //string[] contents = File.ReadAllLines(path);
            //string[] chs = { " " };
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    string[] seg = contents[i].Split();
            //    if (seg[0].Length > 8)
            //    {
            //        seg[0] = seg[0].Substring(0, 8);
            //    }
            //    Console.WriteLine(seg[0] + "|" + seg[seg.Length - 1]);
            //}

            //string path = @"C:\Users\YY\Desktop\1.txt";
            //string[] contents = File.ReadAllLines(path);
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    string[] strNew = contents[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine((strNew[0].Length>10?strNew[0].Substring(0,8)+"......":strNew[0]) + "|" + strNew[1]);
            //}

            //让用户输入一句话，找出所以e的位置
            //法1：用IndexOf()来做
            //int i = 1;
            //string str = "abcdeefgfeskjd";
            //int xuhao=str.IndexOf('e');
            //Console.WriteLine("第1次出现的位置为{0}", xuhao);
            //while (xuhao != -1)
            //{
            //    i++;
            //    xuhao = str.IndexOf('e', xuhao + 1);
            //    if (xuhao == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次出现的位置为{1}", i,xuhao);
            //}

            //法2：利用字符串是字符的数组来做
            //int j = 0;
            //string str = "abcdeefgfeskjd";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')
            //    {
            //        j++;
            //        Console.WriteLine("字符串中第{0}次出现e的位置是{1}",j,i);
            //    }
            //}


            //用户输入一句话，判断这句话中有没有邪恶，如果有就替换成**输出
            //string str = "老牛很邪恶";
            //bool judgment=str.Contains("邪恶");
            //str=str.Replace("邪恶", "**");
            //Console.WriteLine(judgment + str);

            //把{"张三","李四","王二","赵五","陈六"};变成：张三|李四|王二|赵五|陈六，然后把|切割掉
            string[] str= { "张三", "李四", "王二", "赵五", "陈六" };
            string name=string.Join("|", str);
            Console.WriteLine(name);
            str= name.Split(new char[] { '|' },StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == '|')
            //    {
            //        name[i] = null;
            //    }
            //}
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            //Console.WriteLine(name);


            Console.ReadKey();
        }
    }
}
