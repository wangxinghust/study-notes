﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_里氏转换练习
{
    class Beast:Person
    {
        public void BeastSayHello()
        {
            Console.WriteLine("我是野兽");
        }
    }
}
