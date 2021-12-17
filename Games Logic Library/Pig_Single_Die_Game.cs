using System;
using System.Collections.Generic;
using System.Text;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Pig_Single_Die_Game {

        private static Die dice = new Die();
        private static int faceValue;
        private static int[] pointsTotal = new int[2];
        private static string[] playersName = new string[] { "Player 1", "Player 2" };

        public static bool player1Turn;
        public static bool player2Turn;
        public static int tempScore;


        /// <summary>
        /// Initializes the class variables at the start of a new game.
        /// </summary>
        public static void SetUpGame() {
            dice = new Die();
            tempScore = 0;
            faceValue = 0;
            for (int t = 0; t < pointsTotal.Length; t++) {
                pointsTotal[t] = 0;
            }
            player1Turn = true;
            player2Turn = false;
        }

        /// <summary>
        /// Returns the current faceValue of the die
        /// </summary>
        /// <returns>int </returns>
        public static int GetFaceValue() {
            faceValue = dice.GetFaceValue();
            return faceValue;
        }

        /// <summary>
        /// Returns true if player has won this game else returns false
        /// </summary>
        /// <returns>true </returns>false
        public static bool HasWon() {
            for (int s = 0; s < pointsTotal.Length; s++) {
                if (pointsTotal[s] >= 30) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        ///  rolls the die once for the current player, updating the player’s score 
        ///  appropriately according to the faceValue just rolled.This method returns true if the player
        /// has rolled a “1”, otherwise it returns false.
        /// </summary>
        /// <returns>true </returns>false
        public static bool PlayGame() {
            dice.RollDie();
            int score = dice.GetFaceValue();
            tempScore = tempScore + score;
            if ((score == 1) || (score < 2)) {
                if (player1Turn) {
                    pointsTotal[0] = pointsTotal[0] - tempScore + 1;
                    tempScore = 0;
                } else if (player2Turn) {
                    pointsTotal[1] = pointsTotal[1] - tempScore + 1;
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
        /// Returns the name of the player going first
        /// </summary>
        /// <returns>string </returns>
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
