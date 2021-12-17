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
    public partial class Which_Card_Game : Form {
        Form TwentyOneForm = new Twenty_One();      //Creates Twenty One form
        Form CrazyEightsForm = new Crazy_Eights();      //Creates Crazy Eights form

        public Which_Card_Game () {
            InitializeComponent();
        }

        //Displays Exit message before exiting
        private void exitButton_Click ( object sender, EventArgs e ) {  
            DialogResult exit = MessageBox.Show( "Are you sure you want to exit?", "EXIT",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

            if (exit == DialogResult.Yes)
                this.Close();
        }

        //Shows the dialog of the chosen form from the combobox
        private void cardComboBox_SelectedIndexChanged ( object sender, EventArgs e ) {
            int cardGameNo = cardComboBox.SelectedIndex;

            if (cardGameNo == 0)
                TwentyOneForm.ShowDialog();
            else if (cardGameNo == 1)
                CrazyEightsForm.ShowDialog();
        }
    }
}
