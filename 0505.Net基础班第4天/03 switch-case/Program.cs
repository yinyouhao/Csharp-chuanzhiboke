using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //李四的年终工作评定，A级工资涨500，B级工资涨200，C级工资不变，D级工资降200，E级工资降500
            //设李四的原工资为5000，请用户输入李四的评价，然后显示李四来年的工资

            #region 用if-else语句做
            //Console.WriteLine("请输入您对李四的评价：");
            //string evaluation = Console.ReadLine();
            //int salary = 5000;
            //bool b = true;    //(1)布尔类型用于条件的判断
            //if (evaluation == "A")
            //{
            //    salary += 500;//salary=salary+500
            //}
            //else if (evaluation == "B")
            //{
            //    salary += 200;
            //}
            //else if (evaluation == "C")
            //{
            //    salary = salary;
            //}
            //else if (evaluation == "D")
            //{
            //    salary -= 200;
            //}
            //else if (evaluation == "E")
            //{
            //    salary -= 500;
            //}
            //else 
            //{
            //    Console.WriteLine("请输入有效字符");
            //    b = false;    //（2）在这种情况下，输入的非ABCDE中的一个，布尔类型为false
            //}
            //if (b == true)    //（3）在输入为ABCDE中的一个的时候，才能输出对于来年工资的判断
            //{
            //    Console.WriteLine("经评定，李四下年的工资为：{0}", salary);
            //}
            //Console.ReadKey();
            #endregion

            #region 用switch语句做
            Console.WriteLine("请输入您对李四的评价：");
            string evaluation = Console.ReadLine();
            int salary = 5000;
            bool b = true;
            switch (evaluation)
            {
                case "A": salary += 500;
                    break;
                case "B":salary += 200;
                    break;
                case "C":salary = salary;
                    break;
                case "D":salary -= 200;
                    break;
                case "E":salary -= 500;
                    break;
                default:Console.WriteLine("输入了不正确的字符");
                    b = false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("经评价，李四的工资为{0}", salary);
            }
            Console.ReadKey();
            #endregion


        }
    }
}
