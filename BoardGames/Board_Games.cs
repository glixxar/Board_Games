using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGames {
    public partial class Board_Games : Form {

        Form CoinForm = new Two_Up();
        Form DiceForm = new Which_Dice_Game();
        Form CardForm = new Which_Card_Game();

        public Board_Games () {
            InitializeComponent();
        }

        private void coinRadioButton_CheckedChanged ( object sender, EventArgs e ) {
            startButton.Enabled = true;
        }

        private void startButton_Click ( object sender, EventArgs e ) {

            if (coinRadioButton.Checked) CoinForm.ShowDialog();
            else if (diceRadioButton.Checked) DiceForm.ShowDialog();
            else if (cardRadioButton.Checked) CardForm.ShowDialog();
        }

        private void exitButton_Click ( object sender, EventArgs e ) {
            DialogResult exit = MessageBox.Show( "Are you sure you want to exit the application?", "EXIT",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question );

            if (exit == DialogResult.Yes) Close();

        }
    }
}
