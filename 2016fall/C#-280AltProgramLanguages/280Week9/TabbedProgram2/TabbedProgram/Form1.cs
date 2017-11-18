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
        Slots slotGame = new Slots();
        CardGame poker = new CardGame();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeFace_Click(object sender, EventArgs e)
        {
            switch (image)
            {
                case 1: picFace.Load("../../images/evilface.png");
                    break;
                case 2: picFace.Load("../../images/sadface.png");
                    break;
                case 3: picFace.Load("../../images/happyface.png");
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
                case 0: picFace.Load("../../images/evilface.png");
                    break;
                case 1: picFace.Load("../../images/sadface.png");
                    break;
                case 2: picFace.Load("../../images/happyface.png");
                    break;
                case 3: picFace.Load("../../images/texting.jpg");
                    break;
                case 4: picFace.Load("../../images/tongue.jpg");
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
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
