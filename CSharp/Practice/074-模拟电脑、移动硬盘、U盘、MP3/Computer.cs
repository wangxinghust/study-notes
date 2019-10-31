using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_模拟电脑_移动硬盘_U盘_MP3
{
    class Computer
    {
        private MobileStorage _ms;

        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }
        public void CpuRead()
        {
            this.Ms.Read();
        }
        public void CpuWrite()
        {
            this.Ms.Write();
        }
    }

}
