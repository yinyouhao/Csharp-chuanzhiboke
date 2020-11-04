using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_switch_case练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////用户输入姓名，然后显示这个人上辈子的职业。
            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();
            //switch(name)
            //{
            //    case "张三":Console.WriteLine("他的工作为老师");
            //        break;
            //    case "李四":Console.WriteLine("他的工作为医生");
            //        break;
            //    case "王二":Console.WriteLine("他的工作为作家");
            //        break;
            //    default:Console.WriteLine("不认识的一律按没工作处理。");
            //        break;
            //}
            //Console.ReadKey();


            //成绩A>=90;90到80B；80到70C；70到60D；60以下E
            Console.WriteLine("请输入成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            string level = "";
            switch(score/10)
            {
                case 10://表示case10和case9执行的代码是完全一样的
                case 9:level = "A";
                    break;
                case 8:level = "B";
                    break;
                case 7:level = "C";
                    break;
                case 6:level = "D";
                    break;
                default:level = "E";
                    break;
            }
            Console.WriteLine("您的成绩等级为{0}", level);
            Console.ReadKey();
        }
    }
}
