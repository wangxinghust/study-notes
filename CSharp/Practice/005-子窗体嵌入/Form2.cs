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
    public partial class Form2 : Form
    {
        public delegate void changetext(string text);
        public event changetext changetext_event;

        public Form2(Form1 frm)
        {
            InitializeComponent();
            frm.changetxt_event += new Form1.changetxt(frm_changetxt_event);
        }
        void frm_changetxt_event(string text)
        {
            textBox1.Text = text;
        }
        private void button1_click(object sender, EventArgs e)
        {
            changetext_event(textBox1.Text);
        }
    }
}
