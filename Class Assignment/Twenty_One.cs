using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace Class_Assignment {
    public partial class Twenty_One : Form {
        TableLayoutPanel[] tableLayoutPanels;
        Label[] pointsLabels;
        Label[] gamesWonLabels;

        public Twenty_One() {
            InitializeComponent();

            //Creates new labels to display the hands, total Points, and games won for each player
            tableLayoutPanels = new TableLayoutPanel[Twenty_One_Game.NUM_OF_PLAYERS] { playerTableLayoutPanel, dealerTableLayoutPanel };
            pointsLabels = new Label[Twenty_One_Game.NUM_OF_PLAYERS] { playerTotalPointsLabel, dealerTotalPointsLabel };
            gamesWonLabels = new Label[Twenty_One_Game.NUM_OF_PLAYERS] { playerGamesWonLabel, dealerGamesWonLabel };
        }

        private void testButton_Click(object sender, EventArgs e) {      // Testing the Functionality of the Low Level Libraries
            const int testNumOfCardsForDealer = 2;
            const int testNumOfCardsForPlayer = 8;

            CardPile testCardPile = new CardPile(true);
            testCardPile.Shuffle();

            Hand testHandForDealer = new Hand(testCardPile.DealCards(testNumOfCardsForDealer));
            Hand testHandForPlayer = new Hand(testCardPile.DealCards(testNumOfCardsForPlayer));

            DisplayGuiHand(testHandForDealer, tableLayoutPanels[1]);
            DisplayGuiHand(testHandForPlayer, tableLayoutPanels[0]);
        }

        private void dealButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < Twenty_One_Game.NUM_OF_PLAYERS; i++) {
                pointsLabels[i].Visible = true;
            }


            dealerBustedLabel.Visible = false;
            playerBustedLabel.Visible = false;

            Twenty_One_Game.SetUpGame();    // Starts the Game

            if ((Twenty_One_Game.GetTotalPoints(1) == 21 && Twenty_One_Game.GetTotalPoints(0) != 21)
                || Twenty_One_Game.GetTotalPoints(0) == 21 && Twenty_One_Game.GetTotalPoints(1) != 21) {
                GameStatus(true);
            } else {
                GameStatus(false);
            }


            UpdateGUI();
        }

        /// <summary>
        /// Starts the Computer's Turn
        /// Displays busted if and when the computer is busted
        /// Calculates the total points in each hand and displays result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standButton_Click(object sender, EventArgs e) {
            Twenty_One_Game.PlayForDealer();

            if (Twenty_One_Game.GetTotalPoints(0) > 21) {
                playerBustedLabel.Visible = true;
            } else if (Twenty_One_Game.GetTotalPoints(1) > 21) {
                dealerBustedLabel.Visible = true;
            }

            GameStatus(true);
            UpdateGUI();
        }

        /// <summary>
        /// Draws one card to the Player's hand 
        /// Displays busted if the player is busted
        /// and changes the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitButton_Click(object sender, EventArgs e) {
            if (Twenty_One_Game.GetTotalPoints(0) <= 21) {
                Twenty_One_Game.DealOneCardTo(0);
            }

            if (Twenty_One_Game.GetTotalPoints(0) > 21) {
                playerBustedLabel.Visible = true;
                GameStatus(true);
            }

            UpdateGUI();
        }

        /// <summary>
        /// Displays an exit MessageBox 
        /// Closes the game if the user presses yes.
        /// When the user chooses to cancel the game
        /// all the variables, labels, tables, and buttons are reset 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "EXIT",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exit == DialogResult.Yes) {
                Hand hand = new Hand();
                Twenty_One_Game.ResetTotals();
                GameStatus(true);

                for (int i = 0; i < Twenty_One_Game.NUM_OF_PLAYERS; i++) {
                    DisplayGuiHand(hand, tableLayoutPanels[i]);
                    pointsLabels[i].Text = 0.ToString();
                    gamesWonLabels[i].Text = 0.ToString();
                }

                dealerBustedLabel.Visible = false;
                playerBustedLabel.Visible = false;

                numOfAcesLabel.Text = 0.ToString();

                this.Hide();
            }
        }

        /// <summary>
        /// Method to change the visilibity of busted labels when lost
        /// Also determines the status/enability of the hit, stand and deal buttons
        /// </summary>
        /// <param name="startDeal"> if true start round / if false continue round </param>
        private void GameStatus(bool startDeal) {
            if (startDeal) {
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
            } else {
                hitButton.Enabled = true;
                standButton.Enabled = true;
                dealButton.Enabled = false;
                dealerBustedLabel.Visible = false;
                playerBustedLabel.Visible = false;
            }
        }

        /// <summary>
        /// Update the GUI form to display the game, games won, number of aces and total points
        /// </summary>
        private void UpdateGUI() {
            for (int i = 0; i < Twenty_One_Game.NUM_OF_PLAYERS; i++) {
                DisplayGuiHand(Twenty_One_Game.GetHand(i), tableLayoutPanels[i]);
                pointsLabels[i].Text = Twenty_One_Game.GetTotalPoints(i).ToString();
                gamesWonLabels[i].Text = Twenty_One_Game.GetNumOfGamesWon(i).ToString();
            }
            numOfAcesLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
        }

        /// <summary>
        /// Updates the Table Layout of the specified hand
        /// </summary>
        /// <param name="hand">Hand</param>
        /// <param name="tableLayoutPanel">Table Layout Panel name</param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand
    }
}
