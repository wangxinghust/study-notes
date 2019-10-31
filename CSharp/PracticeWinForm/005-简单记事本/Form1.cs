using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtWords.WordWrap = false;
            btnWordWrap.Visible = false;
            btnsave.Visible = false;
            txtWords.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text;
            if(name=="admin"&&pwd=="admin")
            {
                MessageBox.Show("欢迎进入记事本");
                btnWordWrap.Visible = true;
                btnsave.Visible = true;
                txtWords.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                btnLogin.Visible = false;
                btnRest.Visible = false;
                txtName.Visible = false;
                txtPwd.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入");
                Rest();
            }
        }
        /// <summary>
        /// 重置操作，重复两遍了，可提取方法
        /// </summary>
        private void Rest()
        {
            //清空
            txtName.Clear();
            txtPwd.Clear();
            //让文本框获得焦点
            txtName.Focus();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Rest();
        }
        /// <summary>
        /// 自动换行功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            //首先判定当前是否是自动换行
            if(btnWordWrap.Text=="自动换行")
            {

                btnWordWrap.Text = "取消自动换行";//为毛我这儿的自动换行文字变更不起作用呢
                //取消自动换行
                txtWords.WordWrap = true;
                //btnWordWrap.Text = "取消自动换行";
            }
            else if(btnWordWrap.Text=="取消自动换行")//错误在这，先前if前没加else，文字变更后，执行到此，又改回去了，还是需要单步调试执行才好看出错误啊
            {
                txtWords.WordWrap = false;
                btnWordWrap.Text = "自动换行";
            }
        }
        /// <summary>
        /// 保存功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsave_Click(object sender, EventArgs e)
        {
            using(FileStream fsWrite=new FileStream(@"E:\new.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str = txtWords.Text.Trim();
                byte[] buffer = Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
