using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_石头剪刀布
{
    public enum Result
    {
        玩家赢,
        电脑赢,
        平手,
        无法判断
    }
    class Referee
    {
        public static Result Judge(int playerNumber,int computerNumber)
        {
            switch(computerNumber-playerNumber)
            {
                case 1:
                case -2: return Result.玩家赢;
                    
                case 2:
                case -1: return Result.电脑赢;
                    
                case 0: return Result.平手;
                default: return Result.无法判断;
            }
        }
    }
}
