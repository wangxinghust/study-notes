using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGame(str);
        }

        private void PlayGame(string str)
        {
            this.labelPlayer.Text = str;
            Player player = new Player();
            int playerNumber = player.ShowFist(str);
            Computer computer = new Computer();
            int computerNumber = computer.ShowFist();
            labelComputer.Text = computer.Fist;
            Result res = Referee.Judge(playerNumber, computerNumber);
            labelResult.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGame(str);
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }
    }
}
