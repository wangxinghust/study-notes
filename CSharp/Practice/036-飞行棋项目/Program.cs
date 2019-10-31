using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_飞行棋项目
{
    class Program
    {
        //使用静态字段模拟全局变量
        public static int[] Maps = new int[100];
        //声明一个静态数组用来存储玩家A和玩家B的坐标
        public static int[] PlayerPos = new int[2];
        //声明一个静态数组用来存储玩家A和玩家B的姓名
        public static string[] PlayerNames = new string[2];
        //声明一个标记，用于标记是否暂停
        public static bool[] Flags = new bool[2];
        static void Main(string[] args)
        {
            GameShow();
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家A的姓名不能为空，请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[1] == PlayerNames[0])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能与玩家A的姓名相同，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
            }
            #endregion
            //玩家姓名输入Ok之后，清屏
            Console.Clear();//清屏
            GameShow();
            Console.WriteLine("{0}的士兵用A表示", PlayerNames[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayerNames[1]);
            InitialMap();//在画地图之前必须先初始化地图
            DrawMap();
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)//当玩家A跟玩家B没有一个人在终点的时候，两个玩家不停的进行游戏
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if(PlayerPos[0]>=99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerNames[0], PlayerNames[1]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerNames[1], PlayerNames[0]);
                    break;
                }

            }
            Win();



            Console.ReadKey();

        }
        /// <summary>
        /// 游戏胜利结果
        /// </summary>
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
        /// <summary>
        /// 当玩家坐标发生改变时调用
        /// </summary>
        public static void ChangPos()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }
        }
        /// <summary>
        /// 玩游戏
        /// </summary>
        private static void PlayGame(int playNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("{0}按任健健开始掷骰子", PlayerNames[playNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}掷出了{1}", PlayerNames[playNumber], rNumber);
            PlayerPos[playNumber] += rNumber;
            ChangPos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerNames[playNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playNumber]);
            Console.ReadKey(true);
            //玩家A有可能踩到了玩家B 方块 幸运轮盘 地雷 暂停 时空隧道
            if (PlayerPos[playNumber] == PlayerPos[1 - playNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格", PlayerNames[playNumber], PlayerNames[1 - playNumber], PlayerNames[playNumber]);
                PlayerPos[1 - playNumber] -= 6;
                ChangPos();
                Console.ReadKey(true);
            }
            else
            {
                switch (Maps[PlayerPos[playNumber]])
                {
                    case 0: Console.WriteLine("玩家{0}踩到了方块，安全", PlayerNames[playNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1: Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择1--交换位置，2--轰炸对方", PlayerNames[playNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}跟玩家{1}的位置进行交换", PlayerNames[playNumber], PlayerNames[1 - playNumber]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playNumber];
                                PlayerPos[playNumber] = PlayerPos[1 - playNumber];
                                PlayerPos[1 - playNumber] = temp;
                                Console.WriteLine("交换完成，按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}退6格", PlayerNames[playNumber], PlayerNames[1 - playNumber], PlayerNames[1 - playNumber]);
                                Console.ReadKey(true);
                                PlayerPos[1 - playNumber] -= 6;
                                ChangPos();
                                Console.WriteLine("玩家{0}退了6格", PlayerNames[1 - playNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2 1--交换位置 2--轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2: Console.WriteLine("玩家{0}踩到了地雷，退6格", PlayerNames[playNumber]);
                        PlayerPos[playNumber] -= 6;
                        ChangPos();
                        Console.ReadKey(true);
                        break;
                    case 3: Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerNames[playNumber]);
                        Flags[playNumber] = true;
                        Console.ReadKey(true);
                        //PlayGame(1-playNumber);//测试一下，暂停时直接再次调用玩游戏的方法  测试可行 可以再加上清屏重绘地图的操作
                        break;
                    case 4: Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playNumber]);
                        PlayerPos[playNumber] += 10;
                        ChangPos();
                        Console.ReadKey(true);
                        break;
                }
            }
            //ChangPos();//清屏前判定一下也行，方法更好
            Console.Clear();
            DrawMap();
        }
        /// <summary>
        /// 游戏头绘制
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***飞行棋项目***");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("****************");
        }
        /// <summary>
        /// 地图初始化
        /// </summary>
        public static void InitialMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘
            for (int i = 0; i < luckyturn.Length; i++)
            {
                //int index = luckyturn[i];
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }
        /// <summary>
        /// 绘制游戏地图
        /// </summary>
        public static void DrawMap()
        {
            Console.WriteLine("图例：幸运轮盘◎ 地雷☆ 暂停▲ 时空隧道卐");

            #region 第一横行
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }//for 
            #endregion

            //画完第一横行后，应该换行
            Console.WriteLine();

            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            #endregion

            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion

            //换行
            Console.WriteLine();

            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            #endregion

            #region 第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //画完后换行
            Console.WriteLine();
        }
        /// <summary>
        /// 从画地图的方法中抽象出来的一个方法，用于画地图的元素
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static string DrawStringMap(int i)
        {
            string str = "";
            //如果玩家A和玩家B的坐标相同，并且都在这个地图上，画一个尖括号
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
            {
                str = "<>";
            }
            else if (PlayerPos[0] == i)//表示玩家A在第一行上，但是玩家A和玩家B不在同一位置
            {
                //shift+空格切换全角
                str = "Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        str = "卐";
                        break;
                }//switch
            }//else 
            return str;
        }
    }
}
