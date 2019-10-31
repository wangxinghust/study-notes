﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_老师或者学生登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(rdoStudent.Checked||rdoTeacher.Checked)
            //{

            //}     可以先判断是否有选中，也可以给单选一个默认选中的值
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text;
            if(rdoStudent.Checked)
            {
                if(name=="student"&&pwd=="student")
                {
                    MessageBox.Show("学生登录成功");
                }
                else
                {
                    MessageBox.Show("学生登录失败");
                    txtName.Clear();
                    txtPwd.Clear();
                    txtName.Focus();
                }
            }
            else
            {
                if (name == "teacher" && pwd == "teacher")
                {
                    MessageBox.Show("老师登录成功");
                }
                else
                {
                    MessageBox.Show("老师登录失败");
                    txtName.Clear();
                    txtPwd.Clear();
                    txtName.Focus();
                }
            }
        }
    }
}
