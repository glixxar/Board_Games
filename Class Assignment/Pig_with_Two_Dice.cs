using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;

namespace Class_Assignment {
    public partial class Pig_with_Two_Dice : Form {

        int counter = 0;
        public Pig_with_Two_Dice() {
            InitializeComponent();
            SystemInitialise();
        }

        /// <summary>
        /// Initialiases the system 
        /// Resets all text and disables and enables buttons
        /// </summary>
        private void SystemInitialise() {
            Pig_Double_Dice_Game.SetUpGame();
            whoseTurn.Text = Pig_Double_Dice_Game.GetFirstPlayersName();
            rollOrHold.Text = "Roll";
            Player1Score.Text = "";
            Player2Score.Text = "";
            YesRadio.Checked = false;
            NoRadio.Checked = false;
            RollButton.Enabled = true;
            RestartGroup.Enabled = false;
            counter = 0;
        }

        /// <summary>
        /// Updates Dice Image
        /// </summary>
        /// <param name="whichPic"></param>
        /// <param name="dieFace"></param>
        private void PictureBoxUpdate(PictureBox whichPic, int dieFace) {
            whichPic.Image = Images.GetDieImage(dieFace);
        }

        /// <summary>
        /// Obtains scores of Players
        /// </summary>
        private void GetPoints() {
            Player1Score.Text = "" + Pig_Double_Dice_Game.GetPointsTotal("Player 1");
            Player2Score.Text = "" + Pig_Double_Dice_Game.GetPointsTotal("Player 2");
        }

        /// <summary>
        /// Initialises Player 1's turn
        /// </summary>
        private void Player1Starts() {
            Pig_Double_Dice_Game.player1Turn = true;
            Pig_Double_Dice_Game.player2Turn = false;
        }

        /// <summary>
        /// Initialises Player 2's turn 
        /// </summary>
        private void Player2Starts() {
            Pig_Double_Dice_Game.player2Turn = true;
            Pig_Double_Dice_Game.player1Turn = false;
        }

        /// <summary>
        /// Set the system to Game Over state
        /// </summary>
        private void GameOver() {
            RollButton.Enabled = false;
            HoldButton.Enabled = false;
            RestartGroup.Enabled = true;
        }
        
        /// <summary>
        /// Event for when the Roll button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e) {
            bool play = Pig_Double_Dice_Game.PlayGame();
            counter = 0;
            rollTimer.Start();
            rollOrHold.Text = "Roll or Hold";
            if (play) { // In the event when any player tosses a 1 the user is informed
                rollOrHold.Text = "Roll";
                if (Pig_Double_Dice_Game.player1Turn) {
                    MessageBox.Show("Sorry you have thrown a 1. Your turn is over! Your score reverts to " + Pig_Double_Dice_Game.GetPointsTotal("Player 1"), "Turn Over");
                    Player2Starts();
                    whoseTurn.Text = Pig_Double_Dice_Game.GetNextPlayersName();
                } else if (Pig_Double_Dice_Game.player2Turn) {
                    MessageBox.Show("Sorry you have thrown a 1. Your turn is over! Your score reverts to " + Pig_Double_Dice_Game.GetPointsTotal("Player 2"), "Turn Over");
                    Player1Starts();
                    whoseTurn.Text = Pig_Double_Dice_Game.GetNextPlayersName();
                }
                GetPoints();
            }
            // Updates Points based on which Players turn it is
            HoldButton.Enabled = true;
            if ((Pig_Double_Dice_Game.player1Turn) && (!play)) {
                whoseTurn.Text = Pig_Double_Dice_Game.GetNextPlayersName();
                GetPoints();
            }
            if ((Pig_Double_Dice_Game.player2Turn) && (!play)) {
                whoseTurn.Text = Pig_Double_Dice_Game.GetNextPlayersName();
                GetPoints();
            }
            // Checks to see if any player has won
            bool wins = Pig_Double_Dice_Game.HasWon();
            if (wins) {
                if (Pig_Double_Dice_Game.GetPointsTotal("Player 1") >= 100) {
                    GameOver();
                    Pig_Double_Dice_Game.player1Turn = true;
                    MessageBox.Show("Well done " + Pig_Double_Dice_Game.GetNextPlayersName() + " has won the game");
                } else if (Pig_Double_Dice_Game.GetPointsTotal("Player 2") >= 100) {
                    GameOver();
                    Pig_Double_Dice_Game.player2Turn = true;
                    MessageBox.Show("Well done " + Pig_Double_Dice_Game.GetNextPlayersName() + " has won the game");
                }
            }

        }

        /// <summary>
        /// Event for when Hold Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldButton_Click(object sender, EventArgs e) {
            Pig_Double_Dice_Game.tempScore = 0;
            if (Pig_Double_Dice_Game.player1Turn) {
                GetPoints();
                HoldButton.Enabled = false;
                rollOrHold.Text = "Roll";
                Player2Starts();
                whoseTurn.Text = Pig_Double_Dice_Game.GetNextPlayersName();

            } else if (Pig_Double_Dice_Game.player2Turn) {
                GetPoints();
                HoldButton.Enabled = false;
                rollOrHold.Text = "Roll";
                Player1Starts();
                whoseTurn.Text = Pig_Double_Dice_Game.GetNextPlayersName();
            }
        }

        /// <summary>
        /// Event for when the player decides to play again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YesRadio_CheckedChanged(object sender, EventArgs e) {
            SystemInitialise();
        }

        /// <summary>
        /// Event for when the player decides to quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoRadio_CheckedChanged(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you really want to Quit?",
            "Quit?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            // If the user clicked the Yes button
            if (result == DialogResult.Yes) {
                this.Close();
            } else {

            }
        }

        /// <summary>
        /// Animating the rolling sequence of the Dices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollTimer_Tick(object sender, EventArgs e) {
            counter++;
            Random diceVal1 = new Random();
            if (counter < 18) {
                int randDice1 = diceVal1.Next(1, 5);
                PictureBoxUpdate(OnePigPictureBox1, randDice1);
                PictureBoxUpdate(OnePigPictureBox2, randDice1+1);

            } else {
                rollTimer.Stop();
                PictureBoxUpdate(OnePigPictureBox1, Pig_Double_Dice_Game.GetFaceValue(0));
                PictureBoxUpdate(OnePigPictureBox2, Pig_Double_Dice_Game.GetFaceValue(1));
            }
        }
    }
}
