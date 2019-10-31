using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _025_多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个线程去执行这个复杂方法
            th = new Thread(Test);
            //标记这个线程准备就绪了，可以随时被执行 具体什么时候执行这个线程，由CPU决定
            //将线程设置为后台线程
            th.IsBackground = true;
            th.Start();
        }
        /// <summary>
        /// 让button1点击后完成一个相当复杂的事
        /// </summary>
        private void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(i);

                //取消跨线程的访问
                Control.CheckForIllegalCrossThreadCalls = false;
                textBox1.Text = i.ToString();//会抛多种异常，也有可能不抛异常
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你点击关闭窗体的时候，判断新线程是否为null
            if(th!=null)
            {
                //结束这个线程
                th.Abort();//线程被关闭后就没法重新Start
            }
        }
    }
}


//前台线程：只有所有的前台线程都关闭才能完成程序关闭
//后台线程：只要所有的前台线程结束，后台线程就自动结束

//在.Net下，是不允许跨线程访问