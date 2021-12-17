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
    public partial class Which_Dice_Game : Form {
        public Which_Dice_Game() {
            InitializeComponent();
        }

        private void buttonPigExit_Click(object sender, EventArgs e) {

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

        private void radio1Die_CheckedChanged(object sender, EventArgs e) {
            
                Pig_Game singlePig = new Pig_Game();
                singlePig.ShowDialog();
            
        }

        private void radio2Die_CheckedChanged(object sender, EventArgs e) {
            
                Pig_with_Two_Dice twoPig = new Pig_with_Two_Dice();
                twoPig.ShowDialog();
            
        }

        
    }
}
