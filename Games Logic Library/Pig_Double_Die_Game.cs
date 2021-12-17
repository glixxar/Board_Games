using System;
using System.Collections.Generic;
using System.Text;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Pig_Double_Dice_Game {
        private static Die[] dice = new Die[2];
        private static int[] faceValue = new int[2];
        private static int[] pointsTotal = new int[2];
        private static string[] playersName = new string[] { "Player 1", "Player 2" };

        private const int noDice = 2;
        public static bool player1Turn;
        public static bool player2Turn;
        public static int tempScore;

        /// <summary>
        /// Initializes the class variables at the start of a new game
        /// </summary>
        public static void SetUpGame() {
            //+SetUpGame()  initializes the class variables at the start of a new game
            for (int i = 0; i < dice.Length; i++) {
                dice[i] = new Die();
            }
            for (int t = 0; t < pointsTotal.Length; t++) {
                pointsTotal[t] = 0;
                faceValue[t] = 0;
            }
            tempScore = 0;
            player1Turn = true;
            player2Turn = false;
        }

        /// <summary>
        /// Returns the current faceValue of the dieuik
        /// </summary>
        /// <param name="whichDie"></param>
        /// <returns></returns>
        public static int GetFaceValue(int whichDie) {
            //+GetFaceValue(): int returns the current faceValue of the dieuik
            faceValue[whichDie] = dice[whichDie].GetFaceValue();
            return faceValue[whichDie];
        }

        /// <summary>
        ///  rolls the dice once for the current player, updating the player’s score
        ///  appropriately according to the faceValues of the dice just rolled
        ///  This method returns true if the player has rolled a single “1”, otherwise it returns false
        /// </summary>
        /// <returns>false </returns>true
        public static bool PlayGame() {
            for (int d = 0; d < noDice; d++) {
                dice[d].RollDie();
            }
            int score1 = dice[0].GetFaceValue();
            int score2 = dice[1].GetFaceValue();
            int score = 0;

            if ((score1 == score2) && (score1 == 1)) {
                score = 25;
            } else if ((score1 == score2) && (score1 != 1)) {
                score = (dice[0].GetFaceValue() + dice[1].GetFaceValue()) * 2;
            } else if (((score1 < 2) && (score2 > 1)) || ((score2 < 2) && (score1 > 1))) {
                score = 0;
            } else {
                score = dice[0].GetFaceValue() + dice[1].GetFaceValue();
            }

            tempScore += score;
            if (((score1 < 2) && (score2 > 1)) || ((score2 < 2) && (score1 > 1))) {
                if (player1Turn) {
                    pointsTotal[0] = pointsTotal[0] - tempScore;
                    tempScore = 0;
                } else if (player2Turn) {
                    pointsTotal[1] = pointsTotal[1] - tempScore;
                    tempScore = 0;
                }
                return true;
            } else {
                if (player1Turn) {
                    pointsTotal[0] += score;
                } else if (player2Turn) {
                    pointsTotal[1] += score;
                }
                return false;
            }
        }

        /// <summary>
        /// Returns true if player has won this game else returns false
        /// </summary>
        /// <returns>false </returns>true
        public static bool HasWon() {
            for (int s = 0; s < pointsTotal.Length; s++) {
                if (pointsTotal[s] >= 100) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns the name of the player going first
        /// </summary>
        /// <returns>string  </returns>
        public static string GetFirstPlayersName() {
            return playersName[0];
        }

        /// <summary>
        /// Returns the name of the next player
        /// </summary>
        /// <returns>string </returns>
        public static string GetNextPlayersName() {
            if (player1Turn) {
                return playersName[0];
            } else {
                return playersName[1];
            }
        }

        /// <summary>
        /// Returns the specified player’s current points total
        /// </summary>
        /// <param name="nameOfPlayer"></param>
        /// <returns>int </returns>
        public static int GetPointsTotal(string nameOfPlayer) {
            int index = Array.IndexOf(playersName, nameOfPlayer);
            return pointsTotal[index];
        }
    }
}
