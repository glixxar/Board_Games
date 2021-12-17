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
using Low_Level_Objects_Library;

namespace BoardGames {
    public partial class Crazy_Eights : Form {
        TableLayoutPanel[] tableLayoutPanels;

        public Crazy_Eights () {
            InitializeComponent();
            Crazy_Eights_Game.SetUpGame();

            tableLayoutPanels = new TableLayoutPanel[Twenty_One_Game.NUM_OF_PLAYERS] { playerTableLayoutPanel, computerTableLayoutPanel };
        }

        private void dealButton_Click ( object sender, EventArgs e ) {
            Crazy_Eights_Game.DrawCards();
            UpdateGUI();
        }

        /// <summary>
        /// Updates the Table Layout of the specified hand
        /// </summary>
        /// <param name="hand">Hand</param>
        /// <param name="tableLayoutPanel">Table Layout Panel name</param>
        private void DisplayGuiHand ( Hand hand, TableLayoutPanel tableLayoutPanel ) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Size = new Size( 46, 63 );
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding( 0 );
                pictureBox.Image = Images.GetCardImage( card );
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add( pictureBox );
            }
        }// End DisplayGuiHand

        /// <summary>
        /// Displays the card image in the specified picturebox.
        /// The side of the card is specified by a boolean variable (front)
        /// </summary>
        /// <param name="card">Card</param>
        /// <param name="picturebox">Picture Box Name</param>
        /// <param name="front">True to display the front of the card and false to display the back</param>
        private void DisplayGuiCard ( Card card, PictureBox picturebox, bool front ) {
            // Construct a PictureBox object.
            PictureBox pictureBox = new PictureBox();
            // Tell the PictureBox to use all the space inside its square.
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Size = new Size( 46, 63 );
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // Remove spacing around the PictureBox. (Default is 3 pixels.)
            pictureBox.Margin = new Padding( 0 );
            pictureBox.Click += new EventHandler( drawPilePictureBox_Click );
            if (front) pictureBox.Image = Images.GetCardImage( card );
            else pictureBox.Image = Images.GetBackOfCardImage();
            // Add the PictureBox object to the tableLayoutPanel.
            picturebox.Controls.Add( pictureBox );
        }// End DisplayGuiCard

        /// <summary>
        /// Update the GUI
        /// </summary>
        private void UpdateGUI() {
            for (int i = 0; i < Crazy_Eights_Game.NUM_OF_PLAYERS; i++) {
                DisplayGuiHand( Crazy_Eights_Game.GetHand( i ), tableLayoutPanels[i] );
            }
            DisplayGuiCard( Crazy_Eights_Game.LastDisposalCard(), discardPilePictureBox, true );
            DisplayGuiCard( Crazy_Eights_Game.LastDrawCard(), drawPilePictureBox, false );
        }

        private void drawPilePictureBox_Click ( object sender, EventArgs e ) {
            Crazy_Eights_Game.DrawCardFromPile(0);
            UpdateGUI();
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
                Card card = new Card();
                Hand hand = new Hand();
                Crazy_Eights_Game.SetUpGame();
                for (int i = 0; i < Crazy_Eights_Game.NUM_OF_PLAYERS; i++) {
                    DisplayGuiHand( hand, tableLayoutPanels[i] );
                }
                discardPilePictureBox = new PictureBox();
                drawPilePictureBox = new PictureBox();
                this.Hide();
            }
        }
    }
}
