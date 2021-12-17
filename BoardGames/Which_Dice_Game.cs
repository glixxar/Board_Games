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
    public partial class Which_Dice_Game : Form {
        Form SnakeEyesForm = new Snake_Eyes();      //Creates Snake Eyes Form
        Form ShipCaptainAndCrewForm = new Ship_Captain_Crew();      //Creates Ship Captain Crew Form

        public Which_Dice_Game () {
            InitializeComponent();
        }

        //Displays Exit message before exiting
        private void diceExitButton_Click ( object sender, EventArgs e ) {
            DialogResult exit = MessageBox.Show( "Are you sure you want to exit?", "EXIT",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question );

            if (exit == DialogResult.Yes) this.Close();
        }

        //Shows the dialog of the chosen form from the combobox
        private void diceComboBox_SelectedIndexChanged ( object sender, EventArgs e ) {
            int diceGameNo = diceComboBox.SelectedIndex;

            if (diceGameNo == 0) SnakeEyesForm.ShowDialog();
            else if (diceGameNo == 1) ShipCaptainAndCrewForm.ShowDialog();
        }

    }
}
