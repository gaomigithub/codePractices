using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabbedProgram
{
    public partial class Form1 : Form
    {
        public int image = 1;
        public int score = 0;


        Slots slotGame = new Slots();
        CardGame poker = new CardGame();
        Guess guess = new Guess();
        Toss toss = new Toss();
        Roulette roulette = new Roulette();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnChangeFace_Click(object sender, EventArgs e)
        {
            switch (image)
            {
                case 1:
                    picFace.Load("../../images/evilface.png");
                    break;
                case 2:
                    picFace.Load("../../images/sadface.png");
                    break;
                case 3:
                    picFace.Load("../../images/happyface.png");
                    break;
            }
            ++image;
            if (image == 4)
                image = 1;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showDeck();

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            slotGame.play();
            int n;
            n = slotGame.getRandom();

            switch (n)
            {
                case 0:
                    picFace.Load("../../images/evilface.png");
                    break;
                case 1:
                    picFace.Load("../../images/sadface.png");
                    break;
                case 2:
                    picFace.Load("../../images/happyface.png");
                    break;
                case 3:
                    picFace.Load("../../images/texting.jpg");
                    break;
                case 4:
                    picFace.Load("../../images/tongue.jpg");
                    break;

            }
            txtSpinNum.Text = n.ToString();
        }

        private void showDeck()
        {
            txtDeckBefore.Text = poker.getDeck();
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            poker.shuffleDeck();
            txtDeckAfter.Text = poker.getDeck();
            score += 1;
            txtScore.Text = score.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            // Show what player's choice on the label
            lblPlayer.Text = btnScissors.Text;

            // Show what computer's choice on the label
            string strPC = string.Empty;
            switch (guess.PC())
            {
                case 1:
                    strPC = "Scissors";
                    break;
                case 2:
                    strPC = "Rock";
                    break;
                case 3:
                    strPC = "Paper";
                    break;
                default:
                    throw new Exception("Unknown: Cannot decide what the Player show!");
            }
            lblPC.Text = strPC; // show what the computer's hand out 

            // Obtain the value in label and converse to int
            int vPlayer = guess.ChangeStrToInt(lblPlayer.Text);
            // Call the way of Judge. Compare the values and show the result in the label
            int pc = guess.PC();
            lblResult.Text = guess.Judge(vPlayer, pc);

            if (lblResult.Text == "Win")
            {
                score += 1;
                txtScore.Text = score.ToString();
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {

            lblPlayer.Text = btnRock.Text;
            string strPC = string.Empty;
            switch (guess.PC())
            {
                case 1:
                    strPC = "Scissors";
                    break;
                case 2:
                    strPC = "Rock";
                    break;
                case 3:
                    strPC = "Paper";
                    break;
                default:
                    throw new Exception("Unknown: Cannot decide what the Player show!");
            }
            lblPC.Text = strPC;
            int vPlayer = guess.ChangeStrToInt(btnRock.Text);
            int pc = guess.PC();
            lblResult.Text = guess.Judge(vPlayer, pc);

            if (lblResult.Text == "Win")
            {
                score += 1;
                txtScore.Text = score.ToString();
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            lblPlayer.Text = btnPaper.Text;
            string strPC = string.Empty;
            switch (guess.PC())
            {
                case 1:
                    strPC = "Scissors";
                    break;
                case 2:
                    strPC = "Rock";
                    break;
                case 3:
                    strPC = "Paper";
                    break;
                default:
                    throw new Exception("Unknown: Cannot decide what the Player show!");
            }
            lblPC.Text = strPC;
            int vPlayer = guess.ChangeStrToInt(btnPaper.Text);
            int pc = guess.PC();
            lblResult.Text = guess.Judge(vPlayer, pc);

            if (lblResult.Text == "Win")
            {
                score += 1;
                txtScore.Text = score.ToString();
            }
        }


        // Toss part
        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select a choice!", "Error!");
            }
            else
            {
                // user input
                if (radioButton1.Checked)
                    toss.userGuess = "Heads";
                if (radioButton2.Checked)
                    toss.userGuess = "Tails";
                toss.HeadsorTails();

                switch (toss.HeadsorTails())
                {
                    case "Heads":
                        picCoin.Load("../../images/heads.jpg");
                        break;
                    case "Tails":
                        picCoin.Load("../../images/tails.jpg");
                        break;
                }

                if (!toss.userGuess.Equals(toss.headOrTail))
                {
                    MessageBox.Show("You lost!");
                    picCoin.Image = null;

                }
                else
                {
                    MessageBox.Show("You won!");
                    score += 1;
                    txtScore.Text = score.ToString();
                    picCoin.Image = null;

                }
            }
        }


        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSpin_Roulette_Click(object sender, EventArgs e)
        {
            if (!rdoRed.Checked && !rdoBlack.Checked)
            {
                MessageBox.Show("Please select a choice!", "Error!");
            }
            else
            {
                if (rdoRed.Checked)
                    roulette.userGuess = "Red";
                if (rdoBlack.Checked)
                    roulette.userGuess = "Black";
            }
        }
    }
}
