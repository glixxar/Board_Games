using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Assignment {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void radioDice_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }

        private void radioCard_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e) {
            if (radioCard.Checked) {
                Which_Card_Game cardChoose = new Which_Card_Game();
                cardChoose.ShowDialog();
            } 
            else if (radioDice.Checked) {
                Which_Dice_Game diceChoose = new Which_Dice_Game();
                diceChoose.ShowDialog();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e) {
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
    }
}
