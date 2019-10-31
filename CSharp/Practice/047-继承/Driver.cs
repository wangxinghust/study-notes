using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_继承
{
    class Driver:Teacher
    {
        
        private double _driveTime;

        public double DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }

       
        public void Drive()
        {
            Console.WriteLine("司机会开车");
        }
    }
}
