using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _042_颜色设置
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorDialog colorForm = new ColorDialog();
            if (colorForm.ShowDialog() == DialogResult.OK)
            {
                Color col = new Color();
                col = colorForm.Color;
                int nArgb = colorForm.Color.ToArgb();
                label1.Text = nArgb.ToString();
                string dgvColorA = col.A.ToString();
                string dgvColorR = col.R.ToString();
                string dgvColorG = col.G.ToString();
                string dgvColorB = col.B.ToString();
                
                //如果没取到色，返回的数值是-1
            }            
        }
    }
}
