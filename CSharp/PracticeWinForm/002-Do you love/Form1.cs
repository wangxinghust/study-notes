using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_Do_you_love
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当鼠标进入按钮的可见部分的时候，给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            //这个按钮活动的最大宽度局势 窗体的宽度减去按钮的宽度
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Width;

            Random r = new Random();
            //要个按钮一个随机的坐标
            button2.Location = new Point(r.Next(0, x+1), r.Next(0, y+1));//+1无所谓，一个像素的差距
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I love you");
            this.Close();//关闭当前主窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被坚韧的你点到了");
        }
    }
}
