using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;


namespace Games_Logic_Library {
    public static class Snake_Eyes_Game {
        private static bool firstRoll;
        private static int rollTotal;
        private static int playerTotal;
        private static int houseTotal;
        private static int possiblePoints;
        private static Die[] dice = new Die[2];
       
        /// <summary>
        /// Initialises the class variables at the start of a new game
        /// </summary>
        public static void SetUpGame() {
            rollTotal = 0;
            possiblePoints = 0;
            houseTotal = 0;
            playerTotal = 0;
            for (int i = 0; i < dice.Length; i++) {
                dice[i] = new Die();
            }
        }

        /// <summary>
        /// Plays the first roll of the game
        /// and determines the outcome
        /// <summary>
        /// <returns>a boolean indicating if the player needs to roll again</returns>
        public static bool FirstRoll() {
            firstRoll = true;
            rollTotal = 0;
            possiblePoints = 0;
            for (int i = 0; i < dice.Length; i++) {
                dice[i].RollDie();
                rollTotal = rollTotal + dice[i].GetFaceValue();
            }

            if (rollTotal == 2) {
                playerTotal += 2;
                return true;
            }
            else if (rollTotal == 7 || rollTotal == 11) {
                playerTotal += 1;
                return true;
            }
            else if (rollTotal == 3 || rollTotal == 12) {
                houseTotal += 2;
                return true;
            }
            else {
                possiblePoints = rollTotal;
                return false;
            }
        }

        /// <summary>
        /// Plays a subsequent roll of the dice
        /// and determines the outcome.
        /// </summary>
        /// <returns>a boolean indicating if the player needs to roll again</returns>
        public static bool AnotherRoll() {
            rollTotal = 0;
            for (int i = 0; i < dice.Length; i++) {
                dice[i].RollDie();
                rollTotal = rollTotal + dice[i].GetFaceValue();
            }

            if (rollTotal == 7) {
                houseTotal += 2;
                return true;
            }
            else if (rollTotal == possiblePoints) {
                playerTotal += possiblePoints;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Returns the face value of the specified die
        /// </summary>
        /// <param name="whichDice">Die number</param>
        /// <returns>Face Value of that die</returns>
        public static int GetDiceFaceValue (int whichDice) {
            return dice[whichDice].GetFaceValue();
        }

        /// <summary>
        /// Returns the Player's total points
        /// </summary>
        /// <returns>Player's total</returns>
        public static int GetPlayersPoints() {
            return playerTotal;
        }

        /// <summary>
        /// Returns the house total
        /// </summary>
        /// <returns>House total</returns>
        public static int GetHousePoints() {
            return houseTotal;
        }

        /// <summary>
        /// Returns the possible points that the player requires to roll to win
        /// </summary>
        /// <returns>Possible points</returns>
        public static int GetPossiblePoints() {
            return possiblePoints;
        }

        /// <summary>
        /// Returns the total of the current roll
        /// </summary>
        /// <returns>Total Roll outcome</returns>
        public static int GetRollTotal() {
            return rollTotal;
        }

        /// <summary>
        /// returns a string to indicate if 
        /// the player has won, lost or no result from that roll.
        /// </summary>
        /// <returns>String with outcome of the roll</returns>
        public static string GetRollOutcome() {
            if (firstRoll) {
                if (rollTotal == 2 || rollTotal == 7 || rollTotal == 11) return "Congratulations, You won!";
                else if (rollTotal == 3 || rollTotal == 12) return "Ops, You lost!";
                else {
                    firstRoll = false;
                    return "Roll Dice Again";
                }
            }
            else {
                if (rollTotal == possiblePoints) return "Congratulations, You won!";
                else if (rollTotal == 7) return "Ops, You lost!";
                else return "Roll Dice Again";
            }
            
        }
    }
}
