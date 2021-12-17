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

namespace BoardGames {
    public partial class Two_Up : Form {
        int timerTicks = 0;

        public Two_Up () {
            InitializeComponent();
            Two_Up_Game.SetUpGame();
            Two_Up_Game.TossCoins();
            updateTwoUpImages();
        }

        /// <summary>
        /// Updates the two coins pictureboxes according to the toss outcome
        /// </summary>
        private void updateTwoUpImages () {
            
            UpdatePictureBoxImage( coin1PictureBox, Two_Up_Game.IsHeads( 1 ) );
            UpdatePictureBoxImage( coin2PictureBox, Two_Up_Game.IsHeads( 2 ) );
        }

        /// <summary>
        /// Places heads or tails into the given pictureBox.
        /// </summary>
        /// <param name="whichPB">PictureBox Name</param>
        /// <param name="isHeads">True to display Heads and false to display Tails</param>
        private void UpdatePictureBoxImage ( PictureBox whichPB, bool isHeads ) {
            whichPB.Image = Images.GetCoinImage( isHeads );
        }// end UpdatePictureBoxImage


        private void throwCoinButton_Click ( object sender, EventArgs e ) {
            throwCoinButton.Enabled = false;
            twoUpTimer.Start();     //Starts the timer
        }

        private void playAgainButton_Click ( object sender, EventArgs e ) {
            throwCoinButton.Enabled = true;
            playAgainButton.Visible = false;
        }

        /// <summary>
        /// Displays an exit MessageBox and closes the game if the user presses yes.
        /// 
        /// When the user chooses to cancel the game, all the variables, labels, tables, and buttons are set back 
        /// as they were at the start of the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click ( object sender, EventArgs e ) {
            DialogResult exit = MessageBox.Show( "Are you sure you want to exit?", "EXIT",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

            if (exit == DialogResult.Yes) {
                Two_Up_Game.SetUpGame();
                Two_Up_Game.TossCoins();
                updateTwoUpImages();
                throwCoinButton.Enabled = true;
                playAgainButton.Visible = false;
                outcomeLabel.Visible = false;
                playerScoreLabel.Text = "0";
                computerScoreLabel.Text = "0";
                this.Hide();
            }
        }

        /// <summary>
        /// Tosses both coins and displays the outcome of the round.
        /// </summary>
        private void tossCoin() {
            Two_Up_Game.TossCoins();
            string TwoUpOutcome = Two_Up_Game.TossOutcome();

            outcomeLabel.Visible = true;
            outcomeLabel.Text = TwoUpOutcome;
            playerScoreLabel.Text = "" + Two_Up_Game.GetPlayersScore();
            computerScoreLabel.Text = "" + Two_Up_Game.GetComputersScore();
            updateTwoUpImages();

            if (TwoUpOutcome != "Odds") {
                throwCoinButton.Enabled = false;
                playAgainButton.Visible = true;
            }
            else {
                throwCoinButton.Enabled = true;
            }
        }

        /*
         *  Changes both dice pictureBoxes randomly 10 times
         *  Then it rolls the original dices 
         */
        private void twoUpTimer_Tick ( object sender, EventArgs e ) {
            if (coin1PictureBox.Image == coin2PictureBox.Image) {
                UpdatePictureBoxImage( coin1PictureBox, true);
                UpdatePictureBoxImage( coin2PictureBox, false );
            }

            Bitmap PictureSwap = new Bitmap( coin1PictureBox.Image );
            coin1PictureBox.Image = coin2PictureBox.Image;
            coin2PictureBox.Image = PictureSwap;
            timerTicks++;

            if (timerTicks > 10) {
                timerTicks = 0;
                twoUpTimer.Stop();
                tossCoin();
            }
        }
    }
}
