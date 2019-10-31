using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载的时候，将年份添加到下拉框中
            //获得当前的年份
            int year = DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                cboYear.Items.Add(i+"年");
            }
            //改变三个ComboBox的下拉样式
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDay.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //添加之前应该先清空之前的内容
            cboMonth.Items.Clear();
            cboDay.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i+"月");
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDay.Items.Clear();
            //定义一个变量来存储天数
            int day=0;
            //获得月份
            string strMonth = cboMonth.SelectedItem.ToString().Split(new char[]{'月'},StringSplitOptions.RemoveEmptyEntries)[0];//切掉月，并去除返回的含有空字符的数组元素
            int month = Convert.ToInt32(strMonth);
            string strYear = cboYear.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int year = Convert.ToInt32(strYear);
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: day = 31;
                    break;
                case 2:
                    if((year%400==0)||(year%100!=0&&year%4==0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default :day=30;
                    break;
            }
            for (int i = 1; i <= day; i++)
            {
                cboDay.Items.Add(i + "日");
            }
            //MessageBox.Show(cboMonth.Text);
            //switch(cboMonth.Text)
            //{
                
            //}
        }
    }
}
