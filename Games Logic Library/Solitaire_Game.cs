using System;
using System.Collections.Generic;
using System.Text;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Solitaire_Game {
        private static int Piles = 7;
        private static int Suits = 4;

        private static CardPile drawPile = new CardPile();
        private static CardPile discardPile = new CardPile();
        private static CardPile[] suitPiles = new CardPile[Suits];

        private static Hand[] tableauPiles = new Hand[Piles];
        private static Hand[] suitPileHands = new Hand[Suits];
        private static Hand comeFromHand = new Hand();
        private static Hand enterToHand = new Hand();

        private static Card addedCard = new Card();
        public static Card newtabFrom = new Card();
        public static Card topCard = new Card();
        public static Card tabCard = new Card();

        public static int[] cardFace = new int[7];
        public static int cardsUp;

        /// <summary>
        /// Initialises the system by creating neccessary 
        /// CardPiles, Hands and Arrays
        /// </summary>
        public static void SetUpGame() {           
            drawPile = new CardPile(true);
            discardPile = new CardPile(false);           
            drawPile.Shuffle();
            for(int i = 0; i < suitPiles.Length; i++) {
                suitPileHands[i] = new Hand();
            }

            for(int i = 0; i < tableauPiles.Length; i++) {
                tableauPiles[i] = new Hand(drawPile.DealCards(i+1));
            }
            for(int i = 0; i < cardFace.Length; i++) {
                cardFace[i] = 1;
            }
        }

        /// <summary>
        /// Determines if its possible to add a King to a Tableu Pile
        /// returns true if possible else returns false
        /// </summary>
        /// <param name="whichTabFrom"></param>
        /// <returns>true </returns>false
        public static bool AddKingToEmptyTab(int whichTabFrom) {
            int cardsUp = FaceUpCards(whichTabFrom);
            Card topCard = TableuReturn(whichTabFrom).GetCard(TableuReturn(whichTabFrom).GetCount()- cardsUp);
            if (FaceValuetoInt(topCard) == 13) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Adds Multiple cards to a new Tableu Pile from another Tableu Pile by taking into account the
        /// Number of Face up cards in the original tab pile, the tab the cards are coming from and 
        /// </summary>
        /// <param name="originTabFaceUp"></param>
        /// <param name="tabComingFrom"></param>
        /// <param name="addedCard"></param>
        /// <param name="specifiedTab"></param>
        public static void AddMultipleCards(int originTabFaceUp, int tabComingFrom, int specifiedTab) {
            for (int i = originTabFaceUp; i > 0; i--) {
                int sizetabFrom = TableuReturn(tabComingFrom).GetCount();
                sizetabFrom = sizetabFrom - i;
                addedCard = TableuReturn(tabComingFrom).GetCard(sizetabFrom);
                RemoveFromTableu(addedCard, tabComingFrom);
                AddtoTableu(addedCard, specifiedTab);
            }
        }

        /// <summary>
        /// Determines if it is possoble to add a card from one tab to another 
        /// Also takes into account which card is being pressed
        /// Returns true if possible else returns false
        /// </summary>
        /// <param name="tabCardWhich"></param>
        /// <param name="whichTabFrom"></param>
        /// <returns>true</returns>false
        public static bool AddFromTabtoTab(int tabCardWhich, int whichTabFrom) {
            cardsUp = FaceUpCards(whichTabFrom);
            cardsUp--;
            tabCard = TableuReturn(tabCardWhich).GetCard((TableuReturn(tabCardWhich)).GetCount());
            int inCard = ((TableuReturn(whichTabFrom)).GetCount()) - cardsUp;
            topCard = TableuReturn(whichTabFrom).GetCard(inCard);

                if (FaceValuetoInt(tabCard) == FaceValuetoInt(topCard)+1) {
                    int stringin1 = CardSuitToInt(tabCard);
                    int stringin2 = CardSuitToInt(topCard);

                    if (((stringin1 == 2) & (stringin2 == 1))) {
                        return false;
                    } else if (((stringin1 == 1) & (stringin2 == 2))) {
                        return false;
                    } else if (((stringin1 == 0) & (stringin2 == 3))) {
                        return false;
                    } else if (((stringin1 == 3) & (stringin2 == 0))) {
                        return false;
                    } else {
                        return true;
                    }


                } else {
                    return false;
                }
        }

        /// <summary>
        /// Increase the number of face up cards of a tableu pile
        /// </summary>
        /// <param name="whichTab"></param>
        /// <param name="HowMany"></param>
        public static void IncreaseFacesUp(int whichTab, int HowMany) {
            cardFace[whichTab] += HowMany;
        }

        /// <summary>
        /// Reduce the number of face up cards of a tableu pile
        /// However the number of face up cards cannot be lower than one 
        /// in order to ensure in each tab at least one card is faced up
        /// </summary>
        /// <param name="whichTab"></param>
        /// <param name="HowMany"></param>
        public static void ReduceFacesUp(int whichTab, int HowMany) {
            cardFace[whichTab] -= HowMany;
            for(int i = 0; i < cardFace.Length; i++) {
                if(cardFace[i] <= 0) {
                    cardFace[i] += 1;
                }
            }
        }
        
        /// <summary>
        /// Returns the top card of a suit pile
        /// </summary>
        /// <param name="whichSuit"></param>
        /// <returns>Card</returns>
        public static Card ReturnSuitTopCard(int whichSuit) {
            return suitPileHands[whichSuit].GetCard(suitPileHands[whichSuit].GetCount());
        }

        /// <summary>
        /// Returnd the number of face up cards from a suit pile
        /// </summary>
        /// <param name="whichTab"></param>
        /// <returns>int </returns>
        public static int FaceUpCards(int whichTab) {           
            return cardFace[whichTab];
        }

        /// <summary>
        /// Returns a Hand from the Tableu Pile Array of Hands
        /// </summary>
        /// <param name="whichTab"></param>
        /// <returns>Hand </returns>
        public static Hand TableuReturn(int whichTab) {
            return tableauPiles[whichTab];
        }

        /// <summary>
        /// Returns the last card from a Tab pile
        /// </summary>
        /// <param name="whichTab"></param>
        /// <returns>Card</returns>
        public static Card ReturnTabLastCard(int whichTab) {
            Hand HandofLastCard = tableauPiles[whichTab];
            int LastCardpos = HandofLastCard.GetCount();
            Card LastCard = HandofLastCard.GetCard(LastCardpos);
            return LastCard;
        }

        /// <summary>
        /// Determines if two cards are similar
        /// returns true if similar else returns false
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns>true </returns>false
        public static bool CardSimilarity(Card card1, Card card2) {
            if (FaceValuetoInt(card1) == FaceValuetoInt(card2)) {
                int stringin1 = CardSuitToInt(card1);
                int stringin2 = CardSuitToInt(card2);
                if(stringin1 == stringin2) {
                    return true;
                } 
                else {
                    return false;
                }
            } 
            else {
                return false;
            }
        }

        /// <summary>
        /// Adds a card to the corresponding Tableu Pile
        /// </summary>
        /// <param name="card"></param>
        /// <param name="whichPile"></param>
        public static void AddtoTableu(Card card, int whichPile) {
            tableauPiles[whichPile].Add(card);
        }

        /// <summary>
        /// Removes a card from a corresponding Tableu Pile
        /// </summary>
        /// <param name="card"></param>
        /// <param name="whichPile"></param>
        public static void RemoveFromTableu(Card card, int whichPile) {
            tableauPiles[whichPile].Remove(card);
        }

        /// <summary>
        /// Determines if its possible to add a card to a suit pile 
        /// while taking account if the suit pile is initially empty as well
        /// as the preceeding card
        /// </summary>
        /// <param name="AddedCard"></param>
        /// <param name="whichSuit"></param>
        /// <returns>true </returns>false
        public static bool AddToSuitPile(Card AddedCard,int whichSuit) {
            if(suitPileHands[whichSuit].GetCount() == 0) {
                if(FaceValuetoInt(AddedCard) == 1) {
                    suitPileHands[whichSuit].Add(AddedCard);
                    return true;
                }
                else {
                    return false;
                }
            } 
            else {
                Card LastCard = suitPileHands[whichSuit].GetCard(suitPileHands[whichSuit].GetCount());
                if (FaceValuetoInt(LastCard)+1 == FaceValuetoInt(AddedCard)) {
                    int stringin1 = CardSuitToInt(AddedCard);
                    int stringin2 = CardSuitToInt(LastCard);
                    if (stringin1 == stringin2) {
                        suitPileHands[whichSuit].Add(AddedCard);
                        return true;
                    } else {
                        return false;
                    }
                } 
                else {
                    return false;
                }
            }
            
        }

        /// <summary>
        /// Returns a Hand from an array Hands of Suit Piles
        /// </summary>
        /// <param name="whichSuit"></param>
        /// <returns>Hand </returns>
        public static Hand ReturnSuit(int whichSuit) {
            return suitPileHands[whichSuit];
        }

        /// <summary>
        /// Creates a Hand consisting of 24 cards left over after the other 
        /// other cards are placed in the tableu piles
        /// </summary>
        /// <returns>Hand </returns>
        public static Hand DrawPile() {
            Hand DrawHand = new Hand(drawPile.DealCards(24));
            return DrawHand;
        }

        /// <summary>
        /// Determines if it is possible to add a new card to the tableu pile
        /// while taking into account the preceeding card it is added onto
        /// returns true only if the face values differ by 1 and the suits are different
        /// else returns false
        /// </summary>
        /// <param name="newCard"></param>
        /// <param name="clickCard"></param>
        /// <returns>true </returns>false
        public static bool AddtoTabLogic(Card newCard, Card clickCard) {
            if ((FaceValuetoInt(newCard) == FaceValuetoInt(clickCard) + 1)) {
                int stringin1 = CardSuitToInt(newCard);
                int stringin2 = CardSuitToInt(clickCard);
                if (stringin1 != stringin2) {
                    if (((stringin1 == 2) & (stringin2 == 1))) {
                        return false;
                    } else if (((stringin1 == 1) & (stringin2 == 2))) {
                        return false;
                    } else if (((stringin1 == 0) & (stringin2 == 3))) {
                        return false;
                    } else if (((stringin1 == 3) & (stringin2 == 0))) {
                        return false;
                    } 
                    else {
                        return true;
                    }
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }

        /// <summary>
        /// Converts a Card's Suit into an integer and returns it
        /// </summary>
        /// <param name="card"></param>
        /// <returns>int </returns>
        public static int CardSuitToInt(Card card) {
            int CardInt = 0;
            Suit suitVal = card.GetSuit();
            string stringIn = suitVal.ToString();
            if(stringIn == "Clubs") {
                CardInt = 0;
            }
            else if(stringIn == "Diamonds") {
                CardInt = 1;
            }
            else if(stringIn == "Hearts") {
                CardInt = 2;
            }
            else if(stringIn == "Spades") {
                CardInt = 3;
            }
            return CardInt;
        }

        /// <summary>
        /// Determines which Tableu Pile a card comes from
        /// and returns an integer of it 
        /// </summary>
        /// <param name="card"></param>
        /// <returns>int </returns>
        public static int WhichTabPile(Card card) {
            int k = 0;
            for (int i = 0; i < Piles; i++) {
                bool there = tableauPiles[i].Contains(card);
                if (there) {
                    k = i;
                }
            }
            return k;
        }

        /// <summary>
        /// Converts a Card's Face value into an integer
        /// and returns it
        /// </summary>
        /// <param name="incard"></param>
        /// <returns>int </returns>
        public static int FaceValuetoInt(Card incard) {
            FaceValue faceValue = incard.GetFaceValue();
            int faceIntValue = 0;
            if (faceValue.ToString() == "Two") {
                faceIntValue = 2;
            } else if (faceValue.ToString() == "Three") {
                faceIntValue = 3;
            } else if (faceValue.ToString() == "Four") {
                faceIntValue = 4;
            } else if (faceValue.ToString() == "Five") {
                faceIntValue = 5;
            } else if (faceValue.ToString() == "Six") {
                faceIntValue = 6;
            } else if (faceValue.ToString() == "Seven") {
                faceIntValue = 7;
            } else if (faceValue.ToString() == "Eight") {
                faceIntValue = 8;
            } else if (faceValue.ToString() == "Nine") {
                faceIntValue = 9;
            } else if (faceValue.ToString() == "Ten" ) {
                faceIntValue = 10;
            } else if (faceValue.ToString() == "Jack") {
                faceIntValue = 11;
            } else if (faceValue.ToString() == "Queen") {
                faceIntValue = 12;
            } else if (faceValue.ToString() == "King") {
                faceIntValue = 13;
            } else if (faceValue.ToString() == "Ace") {
                faceIntValue = 1;
            }
            return faceIntValue;
            }
        
        }

        
}

