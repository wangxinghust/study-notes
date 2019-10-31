using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_多态练习
{
    class Manager:Staff
    {
        public override void PunchClock()
        {
            Console.WriteLine("经理11点打卡");
        }
    }
}
