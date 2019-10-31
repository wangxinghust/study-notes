using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当文本框中的内容发生改变的时候，将值赋值给Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWords_TextChanged(object sender, EventArgs e)
        {
            lb1.Text = txtWords.Text;
        }
    }
}
//WordWrap:指示文本框是否换行
//PasswordChar 让文本框显示一个单一的字符
//ScollBars 是否显示滚动条
//事件 TextChanged 当文本框中的内容发生改变的时候触发这个事件