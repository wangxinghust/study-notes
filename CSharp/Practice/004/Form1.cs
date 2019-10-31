using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            //先获取坐标点
            //if 执行你写的五个函数中的一个

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            // button1.Visible = true;
        }
    }
}
