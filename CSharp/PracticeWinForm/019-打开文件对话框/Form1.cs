using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _019_打开文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击弹出对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建打开对话框对象
            OpenFileDialog ofd = new OpenFileDialog();
            //设置对话框的标题
            ofd.Title = "请选择要打开的文本文件";
            //设置对话框是否可以多选
            ofd.Multiselect = true;
            //设置对话框的初始目录
            ofd.InitialDirectory = @"C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\Extensions\op12ii5i.ch3\Modules\NuGet\tr\";
            //设置对话框的文件类型
            ofd.Filter = "文本文件|*.txt|媒体文件|*.wmv|图片文件|*.jpg|所有文件|*.*";
            //展示对话框
            ofd.ShowDialog();

            //获得在打开对话框中被选中的文件的路径
            string path = ofd.FileName;
            if(path=="")
            {
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                //实际读取到的字节数
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }
    }
}
