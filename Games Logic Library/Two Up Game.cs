using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Two_Up_Game {
        private static Coin coin1;
        private static Coin coin2;
        private static int playersScore;
        private static int computersScore;

        /// <summary>
        /// initialize the class variables at the start of a new game.
        /// </summary>
        public static void SetUpGame() {
            coin1 = new Coin();
            coin2 = new Coin();
            playersScore = 0;
            computersScore = 0;
        }

        /// <summary>
        /// Flips both coins
        /// </summary>
        public static void TossCoins() {
            coin1.Flip();
            coin2.Flip();
        }

        /// <summary>
        /// returns a string which will be either “Heads” “Tails” or “Odds” 
        /// depending upon the result of tossing both coins.
        /// </summary>
        /// <returns>String of the outcome of the toss</returns>
        public static string TossOutcome() {
            if (coin1.IsHeads() == coin2.IsHeads()) {
                if (coin1.IsHeads()) playersScore += 1;
                else computersScore += 1;
                return coin1.ToString();
            }
            else return "Odds";
        }

        /// <summary>
        /// indicates which of the coins is to be checked if its face is Heads.
        /// </summary>
        /// <param name="whichCoin">If whichCoin will be 1, check coin1 and if whichCoin is 2 check coin2</param>
        /// <returns>True if the coin's face is heads and false if it is tails</returns>
        public static bool IsHeads(int whichCoin) {
            if (whichCoin == 1) return coin1.IsHeads();
            else if (whichCoin == 2) return coin2.IsHeads();
            else return false;
        }

        /// <summary>
        /// Returns the player's current score
        /// </summary>
        /// <returns>Player Score</returns>
        public static int GetPlayersScore() {
            return playersScore;
        }

        /// <summary>
        /// Returns the computer's current score
        /// </summary>
        /// <returns>computer Score</returns>
        public static int GetComputersScore() {
            return computersScore;
        }
    }
}
