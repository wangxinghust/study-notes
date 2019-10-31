using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _031_验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string str = null;
            for (int i = 0; i < 5; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber.ToString();
            }
            //MessageBox.Show(str);

            //创建GDI对象
            Bitmap bmp = new Bitmap(120, 30);
            Graphics g = Graphics.FromImage(bmp);

            //画五个数字
            for (int i = 0; i < 5; i++)
            {
                //五个数字的起始坐标
                Point p = new Point(i * 20, 0);
                //定义随机用的字体数组
                string[] fonts = { "微软雅黑", "宋体", "黑体", "隶书", "仿宋" };
                //定义随机用的颜色数组
                Color[] colors = { Color.Yellow, Color.Blue, Color.Black, Color.Red, Color.Green };
                //绘制
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 5)]), p);
            }
            //画线
            for (int i = 0; i < 20; i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }
            //画点
            for (int i = 0; i < 800; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Gray);
            }
            //将图片镶嵌到PictuBox中
            pictureBox1.Image = bmp;
        }
    }
}

//为什么绘制出来后，他的纵坐标上下有差别
//每种字体的起始纵坐标本身就有所不同