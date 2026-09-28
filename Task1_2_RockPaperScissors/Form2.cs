using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_2_RockPaperScissors
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // User's choice
            string userChoice = txtChoice.Text.Trim().ToLower();

            // Check whether the input is valid or ot
            if (userChoice != "rock" &&
                userChoice != "paper" &&
                userChoice != "scissors")
            {
                lblResult.Text = "Please enter rock, paper, or scissors.";
                return;
            }
            else { lblPlayer.Text = "Player chooses " + userChoice; 
            }

            // Computer's move
            string[] choices = { "rock", "paper", "scissors" };
            Random random = new Random();
            string computerChoice = choices[random.Next(3)];
            lblComp.Text = "Computer chooses " + computerChoice;

            //Compare the choices
            string result;

            if (userChoice == computerChoice)
            {
                lblResult.Text = "It's a draw!";
            }
            else if (
                (userChoice == "rock" && computerChoice == "scissors") ||
                (userChoice == "paper" && computerChoice == "rock") ||
                (userChoice == "scissors" && computerChoice == "paper")
                )
            { lblResult.Text = "You win!"; }
            else
            { lblResult.Text = "Computer wins!"; }
        }

        private void lblComp_Click(object sender, EventArgs e)
        {

        }
    }
}
