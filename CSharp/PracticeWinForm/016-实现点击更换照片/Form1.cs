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

namespace _016_实现点击更换照片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //用来存储图片文件的全路径
        List<string> list = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] path = Directory.GetFiles(@"D:\pic\pic3-this\wallpaper", "*.jpg");
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            for (int i = 0; i < path.Length; i++)
            {
                string filePath = Path.GetFileName(path[i]);
                listBox1.Items.Add(filePath);
                //将图片的全路径添加到list泛型集合中
                list.Add(path[i]);
            }
        }
        /// <summary>
        /// 双击ListBox时显示图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(list[listBox1.SelectedIndex]);
        }
    }
}
