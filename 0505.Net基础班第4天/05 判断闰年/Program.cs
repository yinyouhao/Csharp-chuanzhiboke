using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用户输入年份，在输入月份，输出该月份的天数
            Console.WriteLine("请输入年份："); 
            try //假如输入的年份无效，将会造成异常
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                bool b = true;
                try//输入的月份无效，将会报异常
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    int day = 0;
                    if(month<=12&&month>0)//只有当输入的月份有效时才会进行判断
                    {

                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                day = 30;
                                break;
                            case 2:
                                {
                                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                                    {
                                        day = 29;
                                    }
                                    else
                                    {
                                        day = 28;
                                    }
                                }
                                break;
                        }
                    }//判断月份是否有效的括号
                    else
                    {
                        b = false;
                        Console.WriteLine("输入的月份有误");
                    }
                    if(b)
                    {
                        Console.WriteLine("{0}年的{1}月份一共有{2}天", year, month, day);

                    }
                }//与月份try对应的括号
                catch
                {
                    Console.WriteLine("输入的月份有误");
                }
            }//与年份的try对应的括号
            catch//与年份的try对应的catch
            {
                Console.WriteLine("输入的年份有误");
            }
          
            Console.ReadKey();
        }
    }
}
