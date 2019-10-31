using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_protect访问修饰符
{
    class Person
    {
        protected string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
