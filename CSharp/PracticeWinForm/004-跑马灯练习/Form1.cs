using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_跑马灯练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒了，关不掉了吧！");
            
            //截取字符串，首字母拉到尾部
            label1.Text=label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }
        /// <summary>
        /// 每隔一秒钟就把当前的时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();

            //每一秒判断一下时间
            if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 41 && DateTime.Now.Second == 50)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"F:\BaiduYunGuanjia\sounds\1.wav";
                sp.Play();
            }
        }
        /// <summary>
        /// 当窗体加载的时候，将当前系统的时间赋值给我的label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "唯一的爱";
        }
    }
}

//Timer 在指定的时间间隔内做指定的事