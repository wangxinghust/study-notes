using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_模拟电脑_移动硬盘_U盘_MP3
{
    class MP3:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3读");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3自己播放音乐");
        }
    }
}
