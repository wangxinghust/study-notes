using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _026_播放音乐的下一曲
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listSongs = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"C:\Windows\WinSxS\amd64_microsoft-windows-shell-sounds_31bf3856ad364e35_10.0.17134.1_none_fc93088a1eb3fd11";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.wav";
            ofd.ShowDialog();

            //获得在文件夹中选择的所有文件的全路径
            string[] path = ofd.FileNames;
            string[] fileName = new string[path.Length];
            for (int i = 0; i < path.Length; i++)
            {
                //fileName[i] = Path.GetFileName(path[i]);
                //不带扩展名
                fileName[i] = Path.GetFileNameWithoutExtension(path[i]);
                //将音乐文件的全路径存储到list泛型集合中
                listSongs.Add(path[i]);
            }
            listBox1.Items.AddRange(fileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==0)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            else
            {
                listBox1.SelectedIndex--;
            }
            MusicPlay();
        }

        
        /// <summary>
        /// 实现双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MusicPlay();
        }
        /// <summary>
        /// 播放音乐的提取方法
        /// </summary>
        private void MusicPlay()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            sp.Play();
        }
        /// <summary>
        /// 下一曲播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //int index = listBox1.SelectedIndex;
            //index++;
            //if (index == listBox1.Items.Count)
            //{
            //    index = 0;
            //}
            //sp.SoundLocation = listSongs[index];
            if(listBox1.SelectedIndex==listBox1.Items.Count-1)
            {
                listBox1.SelectedIndex = 0;
            }
            else
            {
                listBox1.SelectedIndex++;
            }
            MusicPlay();
        }
    }
}
