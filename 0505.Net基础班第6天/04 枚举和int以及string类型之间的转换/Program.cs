using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_枚举和int以及string类型之间的转换
{
    public enum QQstate
    {
        Online,
        Busy,
        Leave,
        Offline,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转成int
            //QQstate state = QQstate.Busy;
            //int i = (int)state;
            //Console.WriteLine(i);
            //Console.WriteLine((int)QQstate.Online);
            //Console.ReadKey();
            #endregion

            #region 将int类型强转为枚举类型
            //int n = 0;
            //QQstate state = (QQstate)n;
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion

            #region 将枚举类型转换为string类型
            //所有的类型都可以转换为string类型
            //QQstate state = QQstate.Online;
            //Console.WriteLine(state.ToString());
            //Console.ReadKey();
            #endregion

            #region 将字符串类型转换为枚举类型
            //string s = "8";
            //QQstate state = (QQstate)Enum.Parse(typeof(QQstate), s);
            ////调用Parse这个方法是为了将一个字符串转换为枚举类型，这个方法的完成需要我们提供的一些条件
            ////这些条件就是参数，第一个参数就是获得你要转换的这个枚举的类型：typeof(QQstate)
            ////因为我们在一个命名空间下能够有很多种枚举，需要告诉Parse这个方法你需要转的是哪个枚举。
            ////第二个参数是你要转换的字符串，
            ////左边声明对应的枚举类型接收。
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion

            //枚举类型
            //提示用户选择一个在线状态，我们接受并且将用户输入转换为枚举类型再次打印到控制台中
            //Console.WriteLine("请输入您的用户状态1.Online;2.Busy;3.Leave;4.Offline;5.QMe");
            //bool judgment = true;
            //while (judgment)
            //{
            //    try
            //    {
            //        string number = Console.ReadLine();
            //        string state = "";
            //        switch (number)
            //        {
            //            case "1":
            //                state = "Online";
            //                break;
            //            case "2":
            //                state = "Busy";
            //                break;
            //            case "3":
            //                state = "Leave";
            //                break;
            //            case "4":
            //                state = "Offline";
            //                break;
            //            case "5":
            //                state = "QMe";
            //                break;
            //        }
            //        QQstate qqstate = (QQstate)Enum.Parse(typeof(QQstate), state);
            //        judgment = false;
            //        Console.WriteLine("您的用户状态为{0}", state);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入有效选项");
            //    }
            //}
           
            
            Console.ReadKey();

        }
    }
}
