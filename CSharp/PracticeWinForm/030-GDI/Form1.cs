using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _030_GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen=new Pen(Brushes.CadetBlue);
            Rectangle rec=new Rectangle(50,50,170,70);
            g.DrawRectangle(pen, rec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen=new Pen(Brushes.CadetBlue);
            Rectangle rec=new Rectangle(50,50,170,70);

            g.DrawPie(pen, rec, 0, 270);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("淼王星", new Font("宋体", 20, FontStyle.Underline), Brushes.Blue, new Point(100, 100));
        }
    }
}
