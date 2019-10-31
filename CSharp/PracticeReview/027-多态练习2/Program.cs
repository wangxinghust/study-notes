using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_多态练习2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Bark();
    }
    public class Cat : Animal
    {
        public override void Bark()
        {
            throw new NotImplementedException();
        }
        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
    public class Dog : Animal
    {
        public override void Bark()
        {
            throw new NotImplementedException();
        }
        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
