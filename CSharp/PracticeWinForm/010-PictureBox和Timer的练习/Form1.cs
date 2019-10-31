using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace _010_PictureBox和Timer的练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] path = Directory.GetFiles(@"D:\pic\pic3-this\电影\秒速五厘米");
        int i = 0;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            //在窗体加载的时候，给每一个PictureBox都赋值一个图片的路径
            pictureBox1.Image = Image.FromFile(@"D:\pic\pic3-this\电影\秒速五厘米\[BDPAN][ID228]5.Centimeters.Per.Second.2007.1080p[www.bdpan.com]_20180110213720.JPG");
            pictureBox2.Image = Image.FromFile(@"D:\pic\pic3-this\电影\秒速五厘米\[BDPAN][ID228]5.Centimeters.Per.Second.2007.1080p[www.bdpan.com]_20180110213720.JPG");
            pictureBox3.Image = Image.FromFile(@"D:\pic\pic3-this\电影\秒速五厘米\[BDPAN][ID228]5.Centimeters.Per.Second.2007.1080p[www.bdpan.com]_20180110213720.JPG");
            pictureBox4.Image = Image.FromFile(@"D:\pic\pic3-this\电影\秒速五厘米\[BDPAN][ID228]5.Centimeters.Per.Second.2007.1080p[www.bdpan.com]_20180110213720.JPG");
            pictureBox5.Image = Image.FromFile(@"D:\pic\pic3-this\电影\秒速五厘米\[BDPAN][ID228]5.Centimeters.Per.Second.2007.1080p[www.bdpan.com]_20180110213720.JPG");
            pictureBox6.Image = Image.FromFile(@"D:\pic\pic3-this\电影\秒速五厘米\[BDPAN][ID228]5.Centimeters.Per.Second.2007.1080p[www.bdpan.com]_20180110213720.JPG");

            //播放音乐
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\wx\Documents\Visual Studio 2013\Projects\PracticeWinForm\010-PictureBox和Timer的练习\Resources\Free-Converter.com-20181004234100-827911803.wav";
            sp.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //每隔一秒钟 换一张图片
            //i++;
            //if(i==path.Length)
            //{
            //    i = 0;
            //}
            pictureBox1.Image = Image.FromFile(path[r.Next(0,path.Length)]);
            pictureBox2.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox3.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox4.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox5.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox6.Image = Image.FromFile(path[r.Next(0, path.Length)]);
        }
    }
}
