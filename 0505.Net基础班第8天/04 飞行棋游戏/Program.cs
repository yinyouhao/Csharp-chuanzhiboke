using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_飞行棋游戏
{
    class Program
    {
        //因为声明的很多方法要用到这个数组，因此将其定义为静态字段，用静态字段模拟全局变量
        public static int[] Maps = new int[100];//普通组为⬜
        //声明一个静态数组用来存储玩家A和玩家B的坐标
        public static int[] PlayerPos = new int[2];



        //存储两个玩家的姓名
        static string[] PlayerNames = new string[2];
        //两个玩家的标记
        static bool[] Flags = new bool[2];//默认全为false
        static void Main(string[] args)
        {
            GameShow();//画游戏头
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("输入姓名不能为空，请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == PlayerNames[0] || PlayerNames[1] == "")
            {
                if(PlayerNames[1] == PlayerNames[0])
                {
                    Console.WriteLine("玩家B的姓名不能与玩家A相同，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("用户名不能为空，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
            }
            #endregion
            //玩家姓名输入OK之后，首先清屏
            Console.Clear();//清屏
            GameShow();
            Console.WriteLine("{0}的士兵用A表示", PlayerNames[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayerNames[1]);
            InitailMap();//画地图之前首先初始化地图
            DrawMap();

            //当玩家A和玩家B两个人没有一个在终点的时候 两个玩家不停地去玩游戏
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了玩家{1}", PlayerNames[0], PlayerNames[1]);
                    break;
                }
                if (Flags[1] == true)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了玩家{1}", PlayerNames[1], PlayerNames[0]);
                    break;
                }
            }//while
            Console.ReadKey();
        }
        public static void GameShow()//画游戏头
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("******0505.Net基础班飞行棋*********");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("***********************************");
        }
     
        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6,23,40,55,69,83};//幸运转盘⚪
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5,13,17,33,38,50,64,80,94};//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停🔺
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卍
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }//初始化地图

        public static void DrawMap()
        {
            Console.WriteLine("图例：幸运转盘：○    地雷：☆    暂停：△    时空隧道：卍");
            #region 第一横行

            //第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }//for
            #endregion
            //画完第一横行后应该换行
            Console.WriteLine();

            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            #endregion

            #region 第二横行
            for (int i = 64; i>=35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            //画完第二横行 应该换行
            #endregion
            Console.WriteLine();

            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion

            #region 第三横行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();//画完之后换行
        }//DrawMap()方法的结尾

        /// <summary>
        /// 从画地图的方法中抽象出来的一个方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            #region 画图
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)//保证玩家1，0在第一行上
            {
                str="<>";
            }
            else if (PlayerPos[0] == i)
            {
                //shift＋空格 转换字母为全角，全角占一个格子，半角仅占半个。
                str="Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                //shift＋空格 转换字母为全角，全角占一个格子，半角仅占半个。
                str="Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str="□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str="○";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str="☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        str="△";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.White;
                        str="卍";
                        break;
                }//switch
            }//else
            return str;
            #endregion
        }

        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="玩家代号"></param>
        public static void PlayGame(int playerNumber)
        {
            Random r = new Random();
            int rNumber=r.Next(1, 7);//产生1到6的随机数
            Console.WriteLine("{0}按任意键开始掷骰子", PlayerNames[playerNumber]);
            Console.ReadKey(true);//这样就不会把按的任意键显示到屏幕上
            Console.WriteLine("{0}掷出了{1}", PlayerNames[playerNumber], rNumber);
            PlayerPos[playerNumber] += rNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            //玩家A可能踩到玩家B 方块 幸运转盘 地雷 暂停 时空隧道
            if (PlayerPos[playerNumber] == PlayerPos[1-playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                PlayerPos[1 - playerNumber] -= 6;
                ChangePos();
                Console.ReadKey(true);
            }
            else//踩到了关卡
            {
                //玩家的坐标
                switch (Maps[PlayerPos[playerNumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全。", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运转盘，请选择 1--交换位置 2--轰炸对方", PlayerNames[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择跟玩家{1}交换位置", PlayerNames[playerNumber], PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playerNumber];
                                PlayerPos[playerNumber] = PlayerPos[1 - playerNumber];
                                PlayerPos[1 - playerNumber] = temp;
                                Console.WriteLine("交换完成！！按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                PlayerPos[1 - playerNumber] -= 6;
                                ChangePos();
                                Console.WriteLine("玩家{0}退了6格", PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2 1---交换位置 2---轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，退6格", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        PlayerPos[playerNumber] -= 6;
                        ChangePos();
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerNames[playerNumber]);
                        Flags[playerNumber] = true;
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playerNumber]);
                        PlayerPos[playerNumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;

                }//switch
            }//else
            ChangePos();//perfect
            Console.Clear();
            DrawMap();
        }

        /// <summary>
        /// 当玩家坐标改变时调用
        /// </summary>
        public static void ChangePos()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >=99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[0] = 99;
            }
        }

    }
}
