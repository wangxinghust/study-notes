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
    public partial class Form2 : Form
    {
        public delegate void ChangeForm1TextBoxValue(string txt);
        public event ChangeForm1TextBoxValue ChangeTextBoxValue;

        public Form2(Form1 frm)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeTextBoxValue(this.textBox1.Text);
        }
    }
}
