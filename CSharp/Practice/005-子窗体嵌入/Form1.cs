using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_子窗体嵌入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void changetxt(string text);
        public event changetxt changetxt_event;

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);//传递窗体1指针
            frm.changetext_event += new Form2.changetext(frm_changetext_event);
            frm.Show(this);//窗体不会置于父窗体的外边
        }
        void frm_changetext_event(string text)
        {
            textBox1.Text = text;
        }

        private void button2_click(object sender, EventArgs e)
        {
            changetxt_event(textBox1.Text);
        }
    }
}
