using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_多态练习
{
    class Programmer:Staff
    {
        public override void PunchClock()
        {
            Console.WriteLine("程序猿不打卡");
        }
    }
}
