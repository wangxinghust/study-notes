using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_简介
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //在main函数当中创建的窗体对象，我们称之为这个窗体的主窗体
            //也就意味着当你将主窗体关闭后，整个应用程序都关闭了
            Application.Run(new Form1());
        }
    }
}
