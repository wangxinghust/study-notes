using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_子窗体嵌入2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        /* 
         * click 首字母C大写
        private void button1_click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.ChangeTextBoxValue+=frm_ChangeTextBoxValue;
            frm.Show(this);
        }
         * */
        private void frm_ChangeTextBoxValue(string txt)
        {
            this.textBox1.Text = txt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.ChangeTextBoxValue += frm_ChangeTextBoxValue;
            frm.Show(this);

        }
    }
}
