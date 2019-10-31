using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_方法的递归
{
    class Program
    {
        public static int _i = 0;
        static void Main(string[] args)
        {
            TellStory();
            Console.ReadKey();
        }

        //找到一个文件夹中所有的文件 需要递归

        public static void TellStory()
        {
            Console.WriteLine("从前有座山\n山里有座庙\n庙里有个老和尚和小和尚\n有一天，小和尚哭了，老和尚给小和尚讲了一个故事");
            _i++;//利用静态字段来终止方法递归的无限循环
            if (_i >= 10)
            {
                return;
            }
            TellStory();
        }
    }
}
