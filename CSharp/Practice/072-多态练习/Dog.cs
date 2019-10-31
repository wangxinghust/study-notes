using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_多态练习
{
    class Dog:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗汪汪叫");
        }
    }
}
