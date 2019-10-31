using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_面向对象复习3
{
    class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son("张三", 10m, "A");
            son.PlayGame();
            son.SayHello();
            Daughter daughter = new Daughter("丽丽", 100m, "B");
            daughter.Dance();
            daughter.SayHello();
            Console.ReadKey();
        }
    }
    public class Father
    {
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private decimal _property;

        public decimal Property
        {
            get { return _property; }
            set { _property = value; }
        }
        private string _bloodType;

        public string BloodType
        {
            get { return _bloodType; }
            set { _bloodType = value; }
        }
        public Father(string lastName, decimal property, string bloodType)
        {
            this.LastName = lastName;
            this.Property = property;
            this.BloodType = bloodType;
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我每月{1}钱，我的血型是{2}", this.LastName, this.Property, this.BloodType);
        }
    }
    public class Son : Father
    {
        public Son(string lastName, decimal property, string bloodType)
            : base(lastName, property, bloodType)
        {

        }
        public void PlayGame()
        {
            Console.WriteLine("儿子会玩游戏");
        }
    }
    public class Daughter : Father
    {
        public Daughter(string lastName, decimal property, string bloodType)
            : base(lastName, property, bloodType)
        {

        }
        public void Dance()
        {
            Console.WriteLine("女儿会跳舞");
        }
    }
}
