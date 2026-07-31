/**************************************
 Ingrid Pimentel
 CIST 2341
 Mini Lab 2 - Twenty One Game
 April 21,2026

Honor Statement:
I Promisse that I wrote this code 
I did not copy this code
I did not use AI to generate thsi code
***************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyOneGame
{
    public partial class TwentyOneGame : Form
    {
        Random rand = new Random();
        int total = 0;
        public TwentyOneGame()
        {
            InitializeComponent();
        }
        private void RollBtn_Click(object sender, EventArgs e)
        {
            int dice1 = rand.Next(1, 7);
            int dice2 = 0;
            bool rolledTwoDice = false;

            if (total < 15)
            {
                dice2 = rand.Next(1, 7);
                total = total + dice1 + dice2;
                rolledTwoDice = true;
            }
            else
            {
                total = total + dice1;
            }

            switch (dice1)
            {
                case 1:
                    Dice1Pic.Image = Image.FromFile("die1.png");
                    break;
                case 2:
                    Dice1Pic.Image = Image.FromFile("die2.png");
                    break;
                case 3:
                    Dice1Pic.Image = Image.FromFile("die3.png");
                    break;
                case 4:
                    Dice1Pic.Image = Image.FromFile("die4.png");
                    break;
                case 5:
                    Dice1Pic.Image = Image.FromFile("die5.png");
                    break;
                case 6:
                    Dice1Pic.Image = Image.FromFile("die6.png");
                    break;
            }

            if (rolledTwoDice)
            {
                switch (dice2)
                {
                    case 1:
                        Dice2Pic.Image = Image.FromFile("die1.png");
                        break;
                    case 2:
                        Dice2Pic.Image = Image.FromFile("die2.png");
                        break;
                    case 3:
                        Dice2Pic.Image = Image.FromFile("die3.png");
                        break;
                    case 4:
                        Dice2Pic.Image = Image.FromFile("die4.png");
                        break;
                    case 5:
                        Dice2Pic.Image = Image.FromFile("die5.png");
                        break;
                    case 6:
                        Dice2Pic.Image = Image.FromFile("die6.png");
                        break;
                }
            }
            else
            {
                Dice2Pic.Image = null;
            }

            Dice1Lbl.Text = dice1.ToString();
            Dice2Lbl.Text = dice2.ToString();
            TotalLbl.Text = total.ToString();

            if (total == 21)
            {
                MessageBox.Show("You win!");
            }
            else if (total > 21)
            {
                MessageBox.Show("You lose!");
            }
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            total = 0;
            Dice1Lbl.Text = "";
            Dice2Lbl.Text = "";
            TotalLbl.Text = "";
            Dice1Pic.Image = null;
            Dice2Pic.Image = null;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}