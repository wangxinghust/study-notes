﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _023_简单记事本2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载程序时，隐藏panel
            panel1.Visible = false;
            //取消文本框的自动换行
            textBox1.WordWrap = false;
            //文本框滚动条设置
            textBox1.ScrollBars = ScrollBars.Both;
        }
        /// <summary>
        /// 点击按钮的时候，隐藏panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        List<string> listPath = new List<string>();
        /// <summary>
        /// 打开对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文本文件";
            ofd.InitialDirectory = @"D:\personal\undergraduate_study\课程设计\课程设计1306班";
            ofd.Multiselect = true;
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            ofd.ShowDialog();

            //获得用户选中的文件路径
            string path = ofd.FileName;
            //将文件路径存储到list泛型集合中
            listPath.Add(path);
            //获得用户打开文件的文件名
            string fileName = Path.GetFileName(path);
            //将文件名放到ListBox中
            listBox1.Items.Add(fileName);
            if (path == "")
            {
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }
        /// <summary>
        /// 保存对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"D:\personal\undergraduate_study\课程设计\课程设计1306班";
            sfd.Title = "请选择要保存的文件路径";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();

            //获得用户要保存的文件的路径
            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream fsWrite = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text == "☆自动换行")
            {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "★取消自动换行";
                textBox1.ScrollBars = ScrollBars.Vertical;
            }
            else if (自动换行ToolStripMenuItem.Text == "★取消自动换行")
            {
                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "☆自动换行";
                textBox1.ScrollBars = ScrollBars.Both;
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }
        /// <summary>
        /// 双击打开对应的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //要获得双击的文件所对应的全路径
            string path = listPath[listBox1.SelectedIndex];
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }
    }
}
