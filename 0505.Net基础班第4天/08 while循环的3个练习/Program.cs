using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_while循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //double sum = 0;
            //double averge = 0;
            //Console.WriteLine("请输入班级人数：");
            //double population = Convert.ToDouble(Console.ReadLine());
            //double po = population;//定义一个中间变量存储人数，不然的话人数减完最后没法算平均分了
            //while (po > 0)
            //{
            //    Console.WriteLine("请依次输入学员成绩：");
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + score;
            //    po--;
            //    averge = sum / population;
            //}
            //Console.WriteLine("班级人数为{0}，学员的平均成绩为{1}，总成绩为{2}", population, averge, sum);
            //Console.ReadKey();


            ////循环体：提示用户输入学员成绩
            ////循环条件：输入成绩的个数小于成员数
            //Console.WriteLine("请输入班级人数：");
            //int population = Convert.ToInt32(Console.ReadLine());
            //int i = 1;//定义一个变量表示成员顺序
            //double sum = 0;//定义一个变量计算总分数

            //while (population>=i)
            //{

            //    Console.WriteLine("请输入第{0}名学生的成绩：",i);
            //    double score = Convert.ToDouble(Console.ReadLine());
            //    i++;
            //    sum = sum + score;
            //}
            //Console.WriteLine("该班级总共有{0}名学生，总分为{1},平均分为{2}。", population, sum, sum / population);
            //Console.ReadKey();

            //老师问学生，这道题你会做了吗？如果学生回答会了（y）就可以放学，如果学生不会做（n），则老师再讲一遍，再问会了没
            //（1）直到学生会了，才可以放学
            //（2）老师讲了十遍学生还不会，也可以放学
            //Console.WriteLine("这道题你会了吗？");
            //string answer = Console.ReadLine();
            //int number = 1;
            //if (answer == "y") 
            //{
            //    Console.WriteLine("好的，我们可以放学了。");
            //}
            //else if(answer=="n")
            //{
            //    while (number < 10)
            //    {
            //        number++;
            //        Console.WriteLine("好的，我在给你讲一遍。");
            //        Console.WriteLine("这道题你会了吗？");
            //        answer = Console.ReadLine();
            //        if (answer == "y")
            //        {
            //            Console.WriteLine("好的，我们可以放学了。");
            //            break;
            //        }
            //    }
            //    if(number==10)
            //    {
            //        Console.WriteLine("好吧，我们还是放学吧。");
            //    }
            //}
            //Console.ReadKey();

            //string answer = "";
            //int number = 1;
            //while(number<=10&&answer!="yes")
            //{
            //    Console.WriteLine("这是我给你讲的第{0}编，你会了吗？", number);
            //    answer = Console.ReadLine();
            //    if(answer=="yes")
            //    {
            //        Console.WriteLine("放学了");
            //        break;
            //    }
            //    number++;
            //}
            //Console.ReadKey();

            //2006年培养学员80000人，每年增长25%，
            //请问按照此增长速度，到哪一年培训学员人数将达到20万人？

            //循环体：每年增加25%学员
            //循环条件：学员人数>=20万
            //int year = 2006;
            //double population = 80000;
            //while(population<=200000)
            //{
            //    population*=1.25;
            //    year++;
            //}
            //Console.WriteLine(population);
            //Console.WriteLine(year);
            //Console.ReadKey();

            //提示用户输入yes或者y
            //要求：只能输入yes或者y，只要不是yes或者y就要求用户一直重新输入
            //循环体：要求用户在输入不正确的时候一直输入
            //循环条件：用户输入的不正确
            //Console.WriteLine("请输入：");
            //string enter = Console.ReadLine();
            //while (enter!="yes"&&enter!="y")
            //{
            //    Console.WriteLine("请重新输入");
            //    enter = Console.ReadLine();
            //    //if (enter == "yes" || enter == "y")
            //    //{
            //    //    Console.WriteLine("输入正确");
            //    //    break;
            //    //}

            //}
            //Console.ReadKey();

            //提示用户输入用户名和密码，要求用户名等于admin，密码等于88888
            //用户名错误或者密码错误就重新输入
            //但是，最多只能输入3次

            //循环体：接受用户输入的用户名和密码
            //循环条件：用户输入错误三次以内
            //string name = "";
            //string password = "";
            //int i=0;
            //while (name != "admin" || password != "88888")
            //{
            //    Console.WriteLine("请输入用户名：");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    password = Console.ReadLine();
            //    i++;
            //    if (name != "admin" || password != "88888")
            //    {
            //        Console.WriteLine("输入错误");
            //    }
            //    if (i == 3)//当用户输入错误的次数过多时，退出系统
            //    {
            //        Console.WriteLine("错误次数过多，系统退出。");
            //        break;
            //    }
            //}
            //if (i < 3)//如果退出系统的原因不是用户输入错误次数过多，则为输入正确
            //{
            //    Console.WriteLine("输入正确");
            //}
            //Console.ReadKey();

            //写两个循环
            //第一个循环提示用户A输入用户名，要求A的用户名不能为空，只要为空，就一直要求重新输入
            //第二个循环提示用户B输入用户名，要求B的用户名不能与A相同，同时不能为空，否则就一直要求重新输入
            //循环体：接受并判断用户输入的用户名
            //循环条件：用户名不满足条件
            Console.WriteLine("您好新用户，请输入用户名：");
            //string name1 = Console.ReadLine();
            string name1 = "";
            string name2 = "";
            while (name1=="")
            {
                name1 = Console.ReadLine();
                if (name1 == "")
                {
                    Console.WriteLine("用户名不可为空,请重新输入！");
                }
                //if (name1!="")
                //{
                //    Console.WriteLine("用户名可用");
                //    break;
                //}
            }
            Console.WriteLine("用户名可用");//当不满足while循环条件时执行的代码可以放在while外面，不必放在while里面
            while (name2 == ""||name2==name1)
            {
                Console.WriteLine("新用户您好，请输入用户名：");
                name2 = Console.ReadLine();
                if (name2 == "")
                {
                    Console.WriteLine("用户名不可为空，请重新输入！");
                }
                else if (name2 == name1)
                {
                    Console.WriteLine("用户名已存在！请重新输入");
                }
                //else if (name2 != "" && name2 != name1)
                //{
                //    Console.WriteLine("用户名可用");
                //    break;
                //}
            }
            Console.WriteLine("用户名可用");//把这行代码放到while循环外面，当不满足while循环条件的时候执行
            Console.ReadKey();
        }
    }
}
