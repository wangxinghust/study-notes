using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_里氏转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建10个对象，通过一个循环，去调用他们各自打招呼的方法
            Person[] persons = new Person[10];
            Random r = new Random();
            for (int i = 0; i < persons.Length; i++)
            {
                int rNumber = r.Next(1, 7);
                switch(rNumber)//1-6
                {
                    case 1: persons[i] = new Student();
                        break;
                    case 2: persons[i] = new Teacher();
                        break;
                    case 3: persons[i] = new Beast();
                        break;
                    case 4: persons[i] = new Belle();
                        break;
                    case 5: persons[i] = new LadyKiller();
                        break;
                    case 6: persons[i] = new Person();
                        break;
                }
            }
            for (int i = 0; i < persons.Length; i++)
            {
                if(persons[i] is Student)
                {
                    ((Student)persons[i]).StudentSayHello();
                }
                else if(persons[i] is Teacher)
                {
                    ((Teacher)persons[i]).TeacherSayHello();
                }
                else if(persons[i] is Beast)
                {
                    ((Beast)persons[i]).BeastSayHello();
                }
                else if(persons[i] is Belle)
                {
                    ((Belle)persons[i]).BelleSayHello();
                }
                else if(persons[i] is LadyKiller)
                {
                    ((LadyKiller)persons[i]).LadyKillerSayHello();
                }
                else
                {
                    persons[i].PersonSayHello();
                }
            }
        }
    }
}
