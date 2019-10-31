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

namespace _034_播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //在程序加载的时候 取消播放器的自动播放功能
            musicPlayer.settings.autoStart = false;
            //musicPlayer.URL = @"D:\音乐\安又琪-见坏就收.mp3";

            //listBox多选
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            //静音
            label1.Image = Image.FromFile(@"声音.png");//相对路径
        }
        /// <summary>
        /// 播放或者暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayorPause_Click(object sender, EventArgs e)
        {
            if (btnPlayorPause.Text == "播放")
            {
                try
                {
                    if (musicPlayer.URL != listPath[listBox1.SelectedIndex])
                    {
                        //获得选中的歌曲
                        musicPlayer.URL = listPath[listBox1.SelectedIndex];
                    }
                    musicPlayer.Ctlcontrols.play();
                    btnPlayorPause.Text = "暂停";
                }
                catch { }

            }
            else if (btnPlayorPause.Text == "暂停")
            {
                musicPlayer.Ctlcontrols.pause();
                btnPlayorPause.Text = "播放";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
            btnPlayorPause.Text = "播放";
        }

        //声明一个泛型集合存储音乐文件的全路径
        List<string> listPath = new List<string>();
        /// <summary>
        /// 打开对话框 选择音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\音乐";
            ofd.Filter = "MP3文件|*.mp3|音乐文件|*.wav|所有文件|*.*";
            ofd.Title = "选择你想要的文件吧";
            ofd.Multiselect = true;
            ofd.ShowDialog();

            //获得对话框选中的文件的全路径
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listPath.Add(path[i]);
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }
        /// <summary>
        /// 双击播放对应的音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                return;
            }
            try
            {
                musicPlayer.URL = listPath[listBox1.SelectedIndex];//选中空白区域返回的值是-1
                musicPlayer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
            }
            catch { }
        }
        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //获得当前选中项的索引
                int index = listBox1.SelectedIndex;
                //清空所有选中项的索引
                listBox1.SelectedIndices.Clear();
                index++;
                if (index == listBox1.Items.Count)
                {
                    index = 0;
                }
                //将改变后的索引重新赋值给当前选中项的索引
                listBox1.SelectedIndex = index;
                musicPlayer.URL = listPath[index];
                musicPlayer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
            }
            catch { }

        }
        /// <summary>
        /// 点击上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //获得当前选中项的索引
                int index = listBox1.SelectedIndex;
                //清空所有选中项的索引
                listBox1.SelectedIndices.Clear();
                index--;
                if (index == -1)
                {
                    index = listBox1.Items.Count - 1;
                }
                //将改变后的索引重新赋值给当前选中项的索引
                listBox1.SelectedIndex = index;
                musicPlayer.URL = listPath[index];
                musicPlayer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
            }
            catch { }

        }
        /// <summary>
        /// 点击删除选中项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //要删除列表中的选中项 listPath
            //先删列表还是集合？ 先删列表的会出错 因为SelectIndex值改变了

            //首先获取要删除的歌曲的数量
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //删集合
                listPath.RemoveAt(listBox1.SelectedIndex);
                //删列表
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }
        /// <summary>
        /// 点击放音或者静音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Tag.ToString() == "1")
            {
                //目的：静音
                musicPlayer.settings.mute = true;
                label1.Tag = 2;
                label1.Image = Image.FromFile(@"静音.png");
            }
            else if (label1.Tag.ToString() == "2")
            {
                musicPlayer.settings.mute = false;
                label1.Tag = 1;
                label1.Image = Image.FromFile(@"声音.png");
            }
        }
        /// <summary>
        /// 放大音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume += 5;
        }
        /// <summary>
        /// 降低音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume -= 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果歌曲播放中
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lblInformation.Text = musicPlayer.currentMedia.durationString + "\r\n" + musicPlayer.Ctlcontrols.currentPositionString;
                ////如果歌曲当前的播放时间等于歌曲的总时间 则下一曲
                //if (musicPlayer.currentMedia.duration <= musicPlayer.Ctlcontrols.currentPosition+1)
                //{
                //    try
                //    {
                //        //获得当前选中项的索引
                //        int index = listBox1.SelectedIndex;
                //        //清空所有选中项的索引
                //        listBox1.SelectedIndices.Clear();
                //        index++;
                //        if (index == listBox1.Items.Count)
                //        {
                //            index = 0;
                //        }
                //        //将改变后的索引重新赋值给当前选中项的索引
                //        listBox1.SelectedIndex = index;
                //        musicPlayer.URL = listPath[index];
                //        musicPlayer.Ctlcontrols.play();
                //        btnPlayorPause.Text = "暂停";
                //    }
                //    catch { }

                //}
            }
        }
        /// <summary>
        /// 自动播放下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                try
                {
                    //获得当前选中项的索引
                    int index = listBox1.SelectedIndex;
                    //清空所有选中项的索引
                    listBox1.SelectedIndices.Clear();
                    index++;
                    if (index == listBox1.Items.Count)
                    {
                        index = 0;
                    }
                    //将改变后的索引重新赋值给当前选中项的索引
                    listBox1.SelectedIndex = index;
                    musicPlayer.URL = listPath[index];
                    musicPlayer.Ctlcontrols.play();
                    btnPlayorPause.Text = "暂停";
                }
                catch { }
            }
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                try
                {
                    musicPlayer.Ctlcontrols.play();
                }
                catch { }
            }
        }

        //开始做歌词 放弃做歌词，参考资料
        void IsExistLrc(string songPath)
        {
            songPath += ".lrc";
            if (File.Exists(songPath))
            {
                //读取歌词文件
                string[] lrcText = File.ReadAllLines(songPath);
                //格式化歌词
            }
            else
            {
                label2.Text = ">>>>>歌词为找到<<<<<";
            }
        }
        void FormatLrc(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                string[] lrcTemp = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                string[] lrcNewTemp= lrcTemp[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
