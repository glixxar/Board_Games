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
    public partial class Which_Card_Game : Form {

        public Which_Card_Game() {
            InitializeComponent();

            comboCard.DataSource = Card_Game_Class.InitialiseCardCombo();
        }

        private void comboCard_SelectedIndexChanged(object sender, EventArgs e) {
            Twenty_One twenty_one = new Twenty_One();
            Solitaire solitaire = new Solitaire();
            if (comboCard.SelectedIndex == 1) {
                solitaire.ShowDialog();
            } else if (comboCard.SelectedIndex == 2) {
                twenty_one.ShowDialog();
            }

        }

        private void buttonCardChooseExit_Click(object sender, EventArgs e) {
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
