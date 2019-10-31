using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _032_单例模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = Form2.GetSingle();//new Form2();
            frm2.Show();
        }
    }
}


//2.单例模式
//将构造函数私有化
//提供一个静态方法，返回一个对象
//创建一个单例