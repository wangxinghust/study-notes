using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileDisk md = new MobileDisk();
            MP3 mp3 = new MP3();
            UDisk u = new UDisk();
            Computer cpu = new Computer();
            cpu.MS = md;
            cpu.CpuRead();
        }
    }
    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }
    public class MobileDisk:MobileStorage
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }
        public override void Write()
        {
            throw new NotImplementedException();
        }
    }
    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }
        public override void Write()
        {
            throw new NotImplementedException();
        }
    }
    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }
        public override void Write()
        {
            throw new NotImplementedException();
        }
        public void PlayMusic()
        {

        }
    }
    public class Computer
    {
        public MobileStorage MS
        {
            get;
            set;
        }
        public void CpuRead()
        {
            this.MS.Read();
        }
        public void CpuWrite()
        {
            this.MS.Write();
        }
    }
}
