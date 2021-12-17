using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;
using System.Windows.Forms;

namespace Games_Logic_Library {
    public static class Twenty_One_Game {
        public const int NUM_OF_PLAYERS = 2;

        private static CardPile cardPile = new CardPile( true );
        private static Hand[] hands = new Hand[2];
        private static int[] totalPoints = new int[2];
        private static int[] numOfGamesWon = new int[2];
        private static int numOfUserAcesWithValueOne = 0;
        private static int numOfAces = 0;

        /// <summary>
        /// initializes the class variables at start of a new game
        /// </summary>
        public static void SetUpGame () {
            numOfUserAcesWithValueOne = 0;
            numOfAces = 0;
            cardPile = new CardPile( true );
            cardPile.Shuffle();
            for (int i = 0; i < NUM_OF_PLAYERS; i++) {
                hands[i] = new Hand( cardPile.DealCards( 2 ) );
                totalPoints[i] = CalculateHandTotal( i );
            }

            if (totalPoints[0] != 21 && totalPoints[1] == 21) {
                numOfGamesWon[1] += 1;
            }
            else if (totalPoints[1] != 21 && totalPoints[0] == 21) {
                numOfGamesWon[0] += 1;
            }
        }

        /// <summary>
        /// deals one card from cardPile to the hand of who and returns that card
        /// </summary>
        /// <param name="who">Whose hand</param>
        /// <returns>Returns the added card</returns>
        public static Card DealOneCardTo ( int who ) {
            hands[who].Add( cardPile.DealOneCard() );
            totalPoints[ who ] = CalculateHandTotal( who );

            if (totalPoints[ 0 ] > 21) numOfGamesWon[1] += 1;
            else if (totalPoints[ 1 ] > 21) numOfGamesWon[0] += 1;

            return hands[who].GetCard(hands[who].GetCount() - 1);
        }

        /// <summary>
        /// adds the faceValues of all cards in the hand of who and
        /// returns that total which is adjusted if who is the Player 
        /// and has one or more aces valued as 1.
        /// </summary>
        /// <param name="who">Hand Owner</param>
        /// <returns>Total amount of facevalues of that hand</returns>
        public static int CalculateHandTotal ( int who ) {
            int acesFound = 0;
            int faceIntValue = 0;
            int totalHandValue = 0;
            for (int i = 0; i < hands[who].GetCount(); i++) {
                FaceValue faceValue = hands[who].GetCard( i ).GetFaceValue();

                if (faceValue.ToString() == "Two")
                    faceIntValue = 2;
                else if (faceValue.ToString() == "Three")
                    faceIntValue = 3;
                else if (faceValue.ToString() == "Four")
                    faceIntValue = 4;
                else if (faceValue.ToString() == "Five")
                    faceIntValue = 5;
                else if (faceValue.ToString() == "Six")
                    faceIntValue = 6;
                else if (faceValue.ToString() == "Seven")
                    faceIntValue = 7;
                else if (faceValue.ToString() == "Eight")
                    faceIntValue = 8;
                else if (faceValue.ToString() == "Nine")
                    faceIntValue = 9;
                else if (faceValue.ToString() == "Ten" || faceValue.ToString() == "Jack" || faceValue.ToString() == "Queen" || faceValue.ToString() == "King")
                    faceIntValue = 10;
                else if (faceValue.ToString() == "Ace" && who == 1)
                    faceIntValue = 11;
                else if (faceValue.ToString() == "Ace" && who == 0) {
                    acesFound += 1;
                    faceIntValue = 0;
                }

                totalHandValue = totalHandValue + faceIntValue;
            }

            if ( who == 0 ) {
                acesFound = acesFound - numOfAces;

                for (int i = 0; i < acesFound; i++) {
                    DialogResult exit = MessageBox.Show( "Would you like to count Ace as 1?", "Ace Found!", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                    if (exit == DialogResult.Yes) IncrementNumOfUserAcesWithValueOne();
                    numOfAces++;
                }

                totalHandValue = totalHandValue + numOfUserAcesWithValueOne + ( numOfAces - numOfUserAcesWithValueOne ) * 11;
            }
            return totalHandValue;
        }

        /// <summary>
        ///  plays the Dealer’s turn until the Dealer stands or goes bust.
        /// </summary>
        public static void PlayForDealer () {
            while (totalPoints[1] < 17) {
                DealOneCardTo( 1 );
            }

            if (totalPoints[0] > totalPoints[1] && totalPoints[0] <= 21) numOfGamesWon[0] += 1;
            else if (totalPoints[1] > totalPoints[0] && totalPoints[1] <= 21) numOfGamesWon[1] += 1;
            
        }

        /// <summary>
        /// returns the hand of who
        /// </summary>
        /// <param name="who">Hand Owner</param>
        /// <returns>The cards in the hand of who</returns>
        public static Hand GetHand ( int who ) {
            return hands[who];
        }

        /// <summary>
        /// returns the points total of who
        /// </summary>
        /// <param name="who">Hand Owner</param>
        /// <returns>Total Points of who</returns>
        public static int GetTotalPoints ( int who ) {
            return totalPoints[who];
        }

        /// <summary>
        /// returns number of games won by who
        /// </summary>
        /// <param name="who">Hand Owner</param>
        /// <returns>Games Won of who</returns>
        public static int GetNumOfGamesWon ( int who ) {
            return numOfGamesWon[who];
        }

        /// <summary>
        ///  returns the number of Aces that the user has chosen to have value of 1
        /// </summary>
        /// <returns>Aces with value of 1</returns>
        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }

        /// <summary>
        ///  adds 1 to the numOfUserAcesWithValueOne variable
        /// </summary>
        public static void IncrementNumOfUserAcesWithValueOne () {
            numOfUserAcesWithValueOne += 1;
        }

        /// <summary>
        /// Resets all arrays and variables if the user wishes to play the game again
        /// after closing the Form
        /// </summary>
        public static void ResetTotals () {
            for (int i = 0; i < NUM_OF_PLAYERS; i++) {
                hands[i] = new Hand();
                totalPoints[i] = 0;
                numOfGamesWon[i] = 0;
            }
            numOfUserAcesWithValueOne = 0;
        }

    }
}
