using System;

namespace _13_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //比较三个数字的大小,输出最大的数字

            #region 使用if-elseif做
            ////接收三个数字
            //Console.WriteLine("请输入第一个数字");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int numberThree = Convert.ToInt32(Console.ReadLine());

            ////将三个数字依次与剩下的两个进行比较
            //if(numberOne>numberTwo&&numberOne>numberThree) //第一个和剩下的两个比
            //{
            //    Console.WriteLine(numberOne);
            //}
            //else if(numberTwo>numberOne&&numberTwo>numberThree)//第二个和剩下的两个比
            //{
            //    Console.WriteLine(numberTwo);
            //}
            //else if(numberThree>numberTwo&&numberThree>numberOne)//第三个和剩下的两个比
            //{
            //    Console.WriteLine(numberThree);
            //}
            //Console.ReadKey();
            #endregion
            #region 使用if做
            ////接收三个数字
            //Console.WriteLine("请输入第一个数字");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int numberThree = Convert.ToInt32(Console.ReadLine());
            //if(numberOne>numberTwo)
            //{
            //    if(numberOne>numberThree)
            //    {
            //        Console.WriteLine(numberOne);
            //    }
            //    else
            //    {
            //        Console.WriteLine(numberThree);
            //    }
            //}
            //else
            //{
            //    if(numberTwo>numberThree)
            //    {
            //        Console.WriteLine(numberTwo);
            //    }
            //    else
            //    {
            //        Console.WriteLine(numberThree);
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region 用数字的形式存储密码
            ////练习1：提示用户输入密码，如果密码是“88888”则提示正确，否则要求再输入一次
            ////如果密码“88888”则提示正确，否则提示错误，程序结束
            //Console.WriteLine("请输入用户密码：");
            //int password = Convert.ToInt32(Console.ReadLine());
            //if (password >= 10000)//首先判断输入的数据够不够五位
            //{
            //    if (password == 88888)
            //    {
            //        Console.WriteLine("密码正确");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误,请重新输入！");
            //        password = Convert.ToInt32(Console.ReadLine());
            //        if (password == 88888)
            //        {
            //            Console.WriteLine("密码正确");
            //        }
            //        else
            //        {
            //            Console.WriteLine("密码错误两次，系统退出");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("请输入五位数的密码");
            //}
            //Console.ReadKey();
            #endregion
            #region 用字符串的形式存储密码
            ////用字符的形式判断密码是否正确
            ////优点是判断方便，缺点是不能判断几位字符
            //Console.WriteLine("请输入用户密码：");
            //string password = Console.ReadLine();

            //if (password=="88888")
            //{
            //    Console.WriteLine("密码正确");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误，请重新输入！");
            //    password = Console.ReadLine();
            //    if(password == "88888")
            //    {
            //        Console.WriteLine("输入正确");
            //    }
            //    else
            //    {
            //        Console.WriteLine("错误次数达到两次，系统自动关闭");
            //    }
            //}

            //Console.ReadKey();
            #endregion

            //提示用户输入用户名和账号密码，用户名是：admin；密码是88888
            //则提示正确，如果用户名输入错误提示用户名不存在，密码错误提示密码错误
            #region 用户名和密码分开输入
            //Console.WriteLine("请输入用户名：");
            //string name = Console.ReadLine();
            ////首先接受用户名
            //if (name == "admin")
            //{
            //    Console.WriteLine("请输入密码：");
            //    string password = Console.ReadLine();
            //    //用户名正确时，接受密码
            //    if (password == "88888")
            //    {
            //        Console.WriteLine("登录成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误");
            //    }
            //}
            //else
            ////如果用户名错误，提示用户不存在
            //{
            //    Console.WriteLine("用户不存在");
            //}
            //Console.ReadKey();
            #endregion
            #region 用户名和密码同时输入
            //Console.WriteLine("请输入用户名和密码");
            //string name = Console.ReadLine();
            //string password = Console.ReadLine();
            //if(name=="admin"&&password=="88888")
            //{
            //    Console.WriteLine("登录成功");
            //}
            //else if(name=="admin")//已经不满足上一步的条件，说明姓名和密码必错一个
            //{
            //    Console.WriteLine("密码错误");
            //}
            //else if(password=="88888")
            //{
            //    Console.WriteLine("用户名不存在");
            //}
            //Console.ReadKey();
            #endregion

            //提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于18，则告知不允许查看，如果年龄大于等于10岁且小于18
            //则提示用户是否继续观看(yes/no)，如果用户输入的是yes则提示用户请查看，否则提示“退出，你放弃查看”
            Console.WriteLine("请输入您的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            //年龄大于等于18
            if(age>=18)
            {
                Console.WriteLine("允许查看");
            }
            else if(age>=10)
            //年龄大于10时
            {
                Console.WriteLine("您是否要继续观看（yes/no)？");
                string judgment = Console.ReadLine();
                if(judgment=="yes")
                {
                    Console.WriteLine("请查看");
                }
                else
                {
                    Console.WriteLine("退出，您已经放弃观看");
                }
            }
            else
            //年龄小于10时
            {
                Console.WriteLine("小屁孩玩4399去");
            }
            Console.ReadKey();
        }
    }
}
