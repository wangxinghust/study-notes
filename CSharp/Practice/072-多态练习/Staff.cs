using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_多态练习
{
    class Staff
    {
        public virtual void PunchClock()
        {
            Console.WriteLine("九点打卡");
        }
    }
}
