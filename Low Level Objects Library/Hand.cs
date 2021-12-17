using System;
using System.Collections;
using System.Collections.Generic;

namespace Low_Level_Objects_Library {
    public class Hand : IEnumerable {
        private List<Card> hand = new List<Card>();

        public Hand() {
        }

        /// <summary>
        /// creates hand from a list of cards passed as the parameter
        /// </summary>
        /// <param name="cards">Cards</param>
        public Hand(List<Card> cards) {
            foreach (Card card in cards) {
                hand.Add(card);
            }
        }

        /// <summary>
        /// returns the number of cards in the hand
        /// </summary>
        /// <returns>Amount of cards in the hand</returns>
        public int GetCount() {
            return hand.Count;
        }

        /// <summary>
        /// returns the card at specified position but does not remove that card from the hand.
        /// Also takes into accound indexes start from 0 while count starts from 1
        /// Subtracts difference in order to ensure errors do not occur
        /// </summary>
        /// <param name="index">Position of the card</param>
        /// <returns>Returns the card at index position</returns>
        public Card GetCard(int index) {
            if(index < 0) {
                index += 1;
            }
            if (hand.Count == index) {
                index = hand.Count - 1;
            }
            return hand[index];
        }

        /// <summary>
        /// Adds a card to the hand
        /// </summary>
        /// <param name="card">Card</param>
        public void Add(Card card) {
            hand.Add(card);
        }

        /// <summary>
        /// Searches for the specified card in the hand and return a boolean if found
        /// </summary>
        /// <param name="card">Card</param>
        /// <returns>true if hand contain the specified card</returns>
        public bool Contains(Card card) {
            var  result = hand.Find(x => x == card);
            if(result != null) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// removes a specified card from the hand and returns this card
        /// </summary>
        /// <param name="card">Card</param>
        /// <returns>Returns the removed card</returns>
        public bool Remove(Card card) {
            return hand.Remove(card);
        }

        /// <summary>
        /// removes the card at the specified position in the hand 
        /// where index is zero-based index value.
        /// </summary>
        /// <param name="index">Position of that paper </param>
        public void RemoveAt(int index) {
            hand.RemoveAt(index);
        }

        /// <summary>
        /// Sorts the card in the hand
        /// </summary>
        public void Sort() {
            hand.Sort();
        }

        public IEnumerator GetEnumerator() {
            return hand.GetEnumerator();
        }
    }
}
