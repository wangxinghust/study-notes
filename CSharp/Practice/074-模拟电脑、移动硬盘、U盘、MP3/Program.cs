using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_模拟电脑_移动硬盘_U盘_MP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来模拟实现将移动硬盘或者U盘或者MP3查到电脑上进行读取数据

            //MobileDisk md = new MobileDisk();
            //UDisk u = new UDisk();
            //MP3 mp3 = new MP3();
            //Computer cpu = new Computer();
            //cpu.CpuRead(md);
            //cpu.CpuWrite(md);

            MobileStorage ms = new UDisk();
            Computer cpu = new Computer();
            cpu.Ms = ms;
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();

        }
    }
}
