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
    public partial class Snake_Eyes : Form {
        bool firstRoll = true;
        bool anotherRoll = false;
        int currentPlayersScore = 0;
        int currentHouseScore = 0;
        int timerTicks = 0; //timer counter

        public Snake_Eyes () {  
            InitializeComponent();
            StartGame();    //starts the game
        }

        private void rollButton_Click ( object sender, EventArgs e ) {
            rollButton.Enabled = false;
            snakeEyesTimer.Start();     //timer starts
        }

        private void continueButton_Click ( object sender, EventArgs e ) {      //Resumes the game

            continueButton.Enabled = false;
            rollButton.Enabled = true;
            UpdateDicePictureBox();
            rollLabel.Text = "First Roll";
            dummyLabel.Visible = false;
        }

        /*
         * When cancelling the game, the final results of the match is displayed and a proper exit YesMoMessagebox is displayed 
         * If the user pressed yes, the program will return to Which Dice Game Form, else the game will continue
         */
        private void cancelButton_Click ( object sender, EventArgs e ) {
            int playersScore = Snake_Eyes_Game.GetPlayersPoints();
            int houseScore = Snake_Eyes_Game.GetHousePoints();


            if (playersScore > houseScore)  MessageBox.Show( "Congratulations! You won this game! Well done!", "WINNER");
            else if (playersScore < houseScore) MessageBox.Show( "Ops! House won this game! \n\nBut Never Give Up! and Good luck next time!", "LOST" );
            else MessageBox.Show( "Wow! Neither You or House won this game! \n\nIt was a DRAW!", "DRAW" );

            DialogResult exit = MessageBox.Show( "Are you sure you want to exit?", "EXIT",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

            if (exit == DialogResult.Yes) {     //Makes the game ready if the user wishes to return back to the game without closing Application
                StartGame();
                this.Hide();
            }
        }

        /// <summary>
        /// Method called after rollDice button is pressed.
        /// It identifies if thats the first turn and roll the dice accordingly.
        /// Then it displays the result of the roll.
        /// </summary>
        private void rollDice () {
            currentPlayersScore = Snake_Eyes_Game.GetPlayersPoints();
            currentHouseScore = Snake_Eyes_Game.GetHousePoints();

            if (firstRoll) firstRoll = Snake_Eyes_Game.FirstRoll();
            else anotherRoll = Snake_Eyes_Game.AnotherRoll();

            if (firstRoll || anotherRoll) {
                playerScoreLabel.Text = "" + Snake_Eyes_Game.GetPlayersPoints();
                houseScoreLabel.Text = "" + Snake_Eyes_Game.GetHousePoints();
                firstRoll = true;
                anotherRoll = false;
                continueButton.Enabled = true;
                rollButton.Enabled = false;
            }
            else {
                dummyLabel.Visible = true;
            }

            dummyLabel.Text = rollWinner();
            rollLabel.Text = Snake_Eyes_Game.GetRollOutcome();
            UpdateDicePictureBox();
        }

        /// <summary>
        /// Ensures the game is ready to start
        /// </summary>
        private void StartGame () {
            firstRoll = true;
            anotherRoll = false;
            Snake_Eyes_Game.SetUpGame();
            UpdateDicePictureBox();
            continueButton.Enabled = false;
            rollButton.Enabled = true;
            UpdateDicePictureBox();
            rollLabel.Text = "First Roll";
            playerScoreLabel.Text = "0";
            houseScoreLabel.Text = "0";
            dummyLabel.Visible = false;
        }

        /// <summary>
        /// Updates the 2 dice pictures according to the roll outcomes.
        /// </summary>
        private void UpdateDicePictureBox () {
            UpdatePictureBoxImage( dice1PictureBox, Snake_Eyes_Game.GetDiceFaceValue( 0 ) );
            UpdatePictureBoxImage( dice2PictureBox, Snake_Eyes_Game.GetDiceFaceValue( 1 ) );
        }

        /// <summary>
        /// Changes the picture in the given picturebox.
        /// </summary>
        /// <param name="whichPB">PictureBox of the Dice</param>
        /// <param name="faceValue">Picture of the Dice facevalue</param>
        private void UpdatePictureBoxImage ( PictureBox whichPB, int faceValue ) {
            whichPB.Image = Images.GetDieImage( faceValue );
        }// end UpdatePictureBoxImage

        /// <summary>
        /// Displays the status of the game, whether the player is winning or losing or the number of rolls required
        /// </summary>
        /// <returns>A message with the status of the roll</returns>
        private string rollWinner () {
            int newPlayersScore = Snake_Eyes_Game.GetPlayersPoints();
            int newHouseScore = Snake_Eyes_Game.GetHousePoints();

            if (currentPlayersScore == newPlayersScore && currentHouseScore == newHouseScore) return "You need to roll " + Snake_Eyes_Game.GetPossiblePoints() + " point(s)";

            if (currentPlayersScore != newPlayersScore) return "You have received " + ( newPlayersScore - currentPlayersScore ) + " point(s)";

            if (currentHouseScore < newHouseScore) return "House has received " + ( newHouseScore - currentHouseScore ) + " point(s)";

            return "Error occured!";
        }

        /*
         *  Changes both dice pictureBoxes randomly 10 times
         *  Then it rolls the original dices 
         */
        private void snakeEyesTimer_Tick ( object sender, EventArgs e ) {
            Random randomNumber = new Random();
            UpdatePictureBoxImage( dice1PictureBox, randomNumber.Next( 1, 7 ) );
            UpdatePictureBoxImage( dice2PictureBox, randomNumber.Next( 1, 7 ) );
            timerTicks++;

            if (timerTicks > 10) {
                snakeEyesTimer.Stop();
                rollButton.Enabled = true;
                rollDice();
                timerTicks = 0;
            }
        }
    }
}
