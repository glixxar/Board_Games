using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Crazy_Eights_Game {
        private static CardPile drawPile;
        private static CardPile disposalPile;
        private static Hand[] hands;
        public const int NUM_OF_PLAYERS = 2;

        /// <summary>
        /// initializes the class variables at start of a new game
        /// </summary>
        public static void SetUpGame() {
            drawPile = new CardPile( true );
            disposalPile = new CardPile( false );
            hands = new Hand[2];
        }

        /// <summary>
        /// Draws the first 8 cards to each hand from the Draw Pile 
        /// and adds one card to the disposal pile
        /// </summary>
        public static void DrawCards() {
            for (int i = 0; i < NUM_OF_PLAYERS; i++) {
                hands[i] = new Hand( drawPile.DealCards( 8 ) );
            }
            disposalPile.Add( drawPile.DealOneCard() );
        }

        /// <summary>
        /// Returns the specified hand
        /// </summary>
        /// <param name="who">Hand Owner</param>
        /// <returns>Hand</returns>
        public static Hand GetHand( int who ) {
            return hands[who];
        }

        /// <summary>
        /// Counts the cards at who
        /// </summary>
        /// <param name="who">Hand Owner</param>
        /// <returns>Card amount with who</returns>
        public static int GetHandCount( int who ) {
            return hands[who].GetCount();
        }
        /// <summary>
        /// Returns the last card in the disposal pile
        /// </summary>
        /// <returns>Last Card in the disposal pile</returns>
        public static Card LastDisposalCard() {
            return disposalPile.GetLastCardInPile();
        }

        /// <summary>
        /// Returns the top card in the draw pile
        /// </summary>
        /// <returns>Top Card in the draw pile</returns>
        public static Card LastDrawCard () {
            return drawPile.GetLastCardInPile();
        }

        /// <summary>
        /// Draws one card from the draw pile to the specified hand if the hand doesn't contain more than 13 cards
        /// </summary>
        /// <param name="who"></param>
        public static void DrawCardFromPile (int who) {
            if (hands[who].GetCount() < 13)
                hands[who].Add( drawPile.DealOneCard() );
        }

        /// <summary>
        /// Checks if the selected card from the who is suitable to be placed
        /// on top of the disposal pile
        /// </summary>
        /// <param name="who">Hand Owner</param>
        /// <param name="index">Selected Card number</param>
        /// <returns>True if it matches the rules</returns>
        public static bool checkPlayedCard (int who, int index) {
            Card disposedCard = disposalPile.GetLastCardInPile();
            Card playedCard = hands[who].GetCard( index );

            if (disposedCard.GetFaceValue() == playedCard.GetFaceValue()
                || disposedCard.GetSuit() == playedCard.GetSuit()
                || playedCard.GetFaceValue().ToString() == "Eight") {
                return true;
            }
            return false;
        }

        /// <summary>
        /// if the selected card is suitable to be played,
        /// it moves to the top of the disposal pile and gets removed from the hand
        /// </summary>
        /// <param name="who">Hand Owner</param>
        /// <param name="index">Selected Card number</param>
        public static void PlaceCard (int who, int index) {
            if (checkPlayedCard(who, index)) {
                Card card = hands[who].GetCard( index );
                disposalPile.Add(card);
                hands[who].RemoveAt( index );
            }
        }

        /// <summary>
        /// If the draw pile is empty,
        /// all the cards in the disposal pile move to the draw pile excluding the top card in the disposal pile
        /// </summary>
        public static void ReplacePile () {
            Card disposedCard = disposalPile.GetLastCardInPile();
            for (int i = 0; i < disposalPile.GetCount() - 1; i++) {
                drawPile.Add(disposalPile.GetLastCardInPile() );
            }
            disposalPile = new CardPile(false);
            disposalPile.Add( disposedCard );
        }
    }
}
