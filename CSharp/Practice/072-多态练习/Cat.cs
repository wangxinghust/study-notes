using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_多态练习
{
    class Cat:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵叫");
        }
    }
}
