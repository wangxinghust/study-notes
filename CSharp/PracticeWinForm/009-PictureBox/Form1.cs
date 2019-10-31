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

namespace _009_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\pic\pic3-this\wallpaper\41412-106.jpg");

        }
        string[] path = Directory.GetFiles(@"D:\pic\pic3-this\wallpaper");
        int i = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = path.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
