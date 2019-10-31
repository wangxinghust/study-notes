using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_模拟电脑_移动硬盘_U盘_MP3
{
    class UDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘读");
        }

        public override void Write()
        {
            Console.WriteLine("U盘写");
        }
    }
}
