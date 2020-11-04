using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 自己练习
{

        //enum CardDeckSettings : uint
        //{
        //    SingleDeck=0x01,
        //    LargePicture=0x02,
        //    FancyNumbers=0x04,
        //    Animation=0x08
        //}

        //public enum CardDeckSettings//定义了一个枚举类型
        //{
        //    SingleDick=0x01,
        //    LargePictures=0x02,
        //    FancyNumbers=0x04,
        //    Animation=0x08
        //}
        //public class MyClass
        //{
        //    bool UseSingleDeck = false,
        //        UseBigPics = false,
        //        UseFancyNumbers = false,
        //        UseAnimation = false,
        //        UseAnimationAndFancyNumbers = false;

        //    public void SetOptions(CardDeckSettings ops)
        //    {
        //        UseSingleDeck = ops.HasFlag(CardDeckSettings.SingleDick);
        //        UseBigPics = ops.HasFlag(CardDeckSettings.LargePictures);
        //        UseFancyNumbers = ops.HasFlag(CardDeckSettings.FancyNumbers);
        //        UseAnimation = ops.HasFlag(CardDeckSettings.Animation);

        //        CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
        //        UseAnimationAndFancyNumbers= ops.HasFlag(testFlags);
        //    }
        //    public void PrintOptions()
        //    {
        //        Console.WriteLine("Option settings:");
        //        Console.WriteLine("Use Single Deck---{0}", UseSingleDeck);
        //        Console.WriteLine("Use Large Pictures---{0}", UseBigPics);
        //        Console.WriteLine("Use Fancy Numbers---{0}", UseFancyNumbers);
        //        Console.WriteLine("Show Animation---{0}", UseAnimation);
        //        Console.WriteLine("Show Animation and FancyNumbers---{0}", UseAnimationAndFancyNumbers);
        //    }
        //}
    class Program
    {
        static void Main(string[] args)
        {
            ////CardDeckSettings ops = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers | CardDeckSettings.SingleDeck;
            ////bool useFancyNumbers = ops.HasFlag(CardDeckSettings.FancyNumbers);
            ////Console.WriteLine(useFancyNumbers);

            //MyClass mc = new MyClass();//用用户定义的类定义了一个新变量
            //CardDeckSettings ops = CardDeckSettings.SingleDick | CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;//定义ops为这三者的和
            //mc.SetOptions(ops);//利用自定义函数进行判断
            //mc.PrintOptions();//利用自定义函数进行输出
            //Console.ReadKey();

            //int[,] arr = new int[2, 3];
            //int[] number = new int[10];
            //int[] G = new int[90];
            //int[,] M = new int[90,34];
            //arr[1, 2] = 90;
            //int n = arr[1, 2];
            //Console.WriteLine(n);

            //int[,,] intArry = new int[4, 3, 2]
            //{
            //    {{ 1,2},{5,4 },{3,8 } },
            //    {{ 1,2},{5,4 },{3,8 } },
            //    {{ 1,2},{5,4 },{3,8 } },
            //    {{ 1,2},{5,4 },{3,8 } }
            //};

            //int[,,] intArry2 =           
            //{
            //    {{ 1,2},{5,4 },{3,8 } },
            //    {{ 1,2},{5,4 },{3,8 } },
            //    {{ 1,2},{5,4 },{3,8 } },
            //    {{ 1,2},{5,4 },{3,8 } }
            //};

            var arry = new int[,] { { 1, 2 ,3}, { 5, 4,2 }, { 3, 8,5 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arry[i, j]);
                }
            }
            Console.ReadKey();

            
            

        }
    }
}
