﻿using Fall2020_CSC403_Project.code;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fall2020_CSC403_Project
{
    public partial class FrmGameOver : Form
    {
        public FrmGameOver()
        {
            InitializeComponent();
            
            string playerName = Game.player.playerName;
            File.AppendAllLines(@"leaderboard.txt", new string[] { playerName + " " + Game.player.Score.ToString()}); 
            string content = File.ReadAllText(@"leaderboard.txt");
            ScoreBoardTextBox.Text = content;

        }

        // quit button
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // retry button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }



    }
}
