using System;
using System.Drawing;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace Class_Assignment {
    public partial class Solitaire : Form {
        private const int noSuits = 4;
        private const int noTableus = 7;

        private Hand drawHand = new Hand();
        private Hand discHand = new Hand();
        private Card clickCard = new Card();
        private Card tabCard = new Card();

        private int click_count = 0;
        private int tabComingFrom;
        private int sizetabFrom;
        private int tabCardWhich;
        private int originTabFaceUp;

        private bool reset = false;
        private bool fromDiscard = false;
        private bool fromTab = false;
        private bool fromSuit = false;

        private Card tempCard = new Card();
        private Card ClickedCard = new Card();
        private Card cardInstance = new Card();
        private Card LastCard = new Card();

        private Hand[] tableaupiles = new Hand[7];
        private TableLayoutPanel[] tableLayoutPanels;
        private PictureBox[] suitPiles;

        public Solitaire() {
            InitializeComponent();
            SystemInitialise();
        }

        /// <summary>
        /// Initialises the system
        /// </summary>
        private void SystemInitialise() {
            Solitaire_Game.SetUpGame();
            discardPile.Enabled = false;
            click_count = 0;
            tableLayoutPanels = new TableLayoutPanel[noTableus] {
                tableLayoutPanel1, tableLayoutPanel2, tableLayoutPanel3, tableLayoutPanel4, tableLayoutPanel5, tableLayoutPanel6, tableLayoutPanel7
            };
            suitPiles = new PictureBox[noSuits] {
                suitPile1, suitPile2, suitPile3, suitPile4
            };
            UpdateTabPiles();
            drawHand = Solitaire_Game.DrawPile();
            Card topCard = drawHand.GetCard(0);
            drawPiles.Image = Images.GetCardImage(topCard);
            drawPiles.Image = Images.GetBackOfCardImage();
            reset = false;
        }

        /// <summary>
        /// Event handler for when the draw pile is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawPiles_Click(object sender, EventArgs e) {
            discardPile.Enabled = true;
            click_count++;
            // Updates the discard pile when the draw pile is clicked until it is empty
            // when the draw pile is empty all cards are returned from discard pile to draw pile
            if (click_count < (drawHand.GetCount() + discHand.GetCount())) {
                clickCard = drawHand.GetCard(drawHand.GetCount() - 1);
                drawHand.Remove(clickCard);
                discHand.Add(clickCard);
                discardPile.Image = Images.GetCardImage(clickCard);
            } else {
                discardPile.Image = null;
                click_count = 0;
                foreach (Card card in discHand) {
                    drawHand.Add(card);
                }
                foreach (Card card in drawHand) {
                    discHand.Remove(card);
                }
            }
        }

        /// <summary>
        /// Updates the tableu piles
        /// </summary>
        private void UpdateTabPiles() {
            for (int k = 0; k < noTableus; k++) {
                DisplayGuiHand(Solitaire_Game.TableuReturn(k), tableLayoutPanels[k], Solitaire_Game.FaceUpCards(k));
            }
        }

        /// <summary>
        /// Displays the table pile based on an inputted hand and the table layout panel as well as the number of face
        /// up cards
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="tableLayoutPanel"></param>
        /// <param name="faceUp"></param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel, int faceUp) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            for (int i = 0; i < hand.GetCount(); i++) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Size = new Size(65, 95);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                // Displays and disables cards based on the number cards are facing up
                if (i < hand.GetCount() - faceUp) {
                    pictureBox.Image = Images.GetCardImage(hand.GetCard(i));
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    pictureBox.Tag = hand.GetCard(i);
                    pictureBox.Image = Images.GetBackOfCardImage();
                    pictureBox.Tag = hand.GetCard(i);
                    pictureBox.Enabled = false;
                } else {
                    pictureBox.Image = Images.GetCardImage(hand.GetCard(i));
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    pictureBox.Tag = hand.GetCard(i);
                    pictureBox.Enabled = true;
                }
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }

        /// <summary>
        /// Event handler only for when the tableu pile is empty when clicked and a King card is trying to be added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emptyTab_Click(object sender, EventArgs e) {
            int emptyTab = -1;
            // Determines if there are any empty tab piles
            for (int p = 0; p < noTableus; p++) {
                Hand handCheck = Solitaire_Game.TableuReturn(p);
                int j = handCheck.GetCount();
                if (j == 0) {
                    emptyTab = p;
                }
            }

            // If statement for determining where a card comes from as well as 
            // logic for determining a card should be added or not
            if (fromTab) {
                fromTab = false;
                reset = true;
                if (emptyTab > -1) {
                    if (Solitaire_Game.AddKingToEmptyTab(tabComingFrom)) {
                        originTabFaceUp = Solitaire_Game.FaceUpCards(tabComingFrom);
                        Solitaire_Game.ReduceFacesUp(tabComingFrom, originTabFaceUp);
                        Solitaire_Game.IncreaseFacesUp(emptyTab, originTabFaceUp);
                        Solitaire_Game.AddMultipleCards(originTabFaceUp, tabComingFrom, emptyTab);
                        UpdateTabPiles();
                    }
                }
            } else if (fromDiscard) {
                fromDiscard = false;
                reset = true;
                if (emptyTab > -1) {
                    if (Solitaire_Game.FaceValuetoInt(clickCard) == 13) {
                        discHand.Remove(clickCard);
                        Solitaire_Game.AddtoTableu(clickCard, emptyTab);
                        int discCards = discHand.GetCount();
                        if (discCards == 0) {
                            discardPile.Image = null;
                        } else {
                            Card nextCard = discHand.GetCard(discCards);
                            discardPile.Image = Images.GetCardImage(nextCard);
                        }
                        UpdateTabPiles();
                    }
                }
            }
        }

        /// <summary>
        /// Updates the Discard pile's picturebox
        /// </summary>
        /// <param name="discCards"></param>
        private void DiscPileUpdate(int discCards) {
            if (discCards > 0) {
                Card nextCard = discHand.GetCard(discCards);
                discardPile.Image = Images.GetCardImage(nextCard);
            } else {
                discardPile.Image = null;
            }
        }

        /// <summary>
        /// Event handler for when any of the pictureboxes that are faced up are pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, EventArgs e) {
            // Resets a user's input
            if (reset) {
                fromTab = true;
                reset = false;
                PictureBox clickBox = (PictureBox)sender;
                ClickedCard = (Card)clickBox.Tag;
                tabComingFrom = Solitaire_Game.WhichTabPile(ClickedCard);
                LastCard = Solitaire_Game.ReturnTabLastCard(tabComingFrom);
                cardInstance = ClickedCard;
            } else {
                // Determines where a card comes from as well as tells the system if the card
                // originates from a tab
                if (!fromTab) {
                    if (fromDiscard) {
                        fromDiscard = false;
                        reset = true;
                        PictureBox clickedPictureBox = (PictureBox)sender;
                        Card newCard = (Card)clickedPictureBox.Tag;

                        int TabCheck = Solitaire_Game.WhichTabPile(newCard);
                        Card LastCard = Solitaire_Game.ReturnTabLastCard(TabCheck);
                        int FaceUp = Solitaire_Game.FaceUpCards(TabCheck);

                        // Logic for adding a card from the discard pile to a tab pile 
                        if (FaceUp > 1) {
                            Hand tabReturned = Solitaire_Game.TableuReturn(TabCheck);
                            int tabLength = tabReturned.GetCount();
                            if (Solitaire_Game.AddtoTabLogic(LastCard, clickCard)) {
                                reset = true;
                                int Tab = Solitaire_Game.WhichTabPile(LastCard);
                                discHand.Remove(clickCard);
                                Solitaire_Game.AddtoTableu(clickCard, Tab);
                                Solitaire_Game.IncreaseFacesUp(Tab, 1);
                                UpdateTabPiles();
                                int discCards = discHand.GetCount();
                                DiscPileUpdate(discCards);
                            } else {
                                MessageBox.Show("Invalid");
                                reset = true;
                            }
                        } else {
                            if (Solitaire_Game.AddtoTabLogic(LastCard, clickCard)) {
                                reset = true;
                                int Tab = Solitaire_Game.WhichTabPile(LastCard);
                                discHand.Remove(clickCard);
                                Solitaire_Game.AddtoTableu(clickCard, Tab);
                                Solitaire_Game.IncreaseFacesUp(Tab, 1);
                                UpdateTabPiles();
                                int discCards = discHand.GetCount();
                                DiscPileUpdate(discCards);
                            } else {
                                MessageBox.Show("Invalid");
                                reset = true;
                            }
                        }

                    } else if (fromSuit) {
                        fromDiscard = false;
                        reset = true;
                    } else {
                        fromTab = true;
                        reset = true;
                    }
                } else {
                    // Logic for handling when cards are moved between tab piles
                    fromTab = false;
                    PictureBox clickedPictureBox = (PictureBox)sender;
                    tabCard = (Card)clickedPictureBox.Tag;
                    tabCardWhich = Solitaire_Game.WhichTabPile(tabCard);
                    reset = true;
                    if (Solitaire_Game.CardSimilarity(cardInstance, LastCard)) {
                        originTabFaceUp = Solitaire_Game.FaceUpCards(tabComingFrom);
                        sizetabFrom = (Solitaire_Game.TableuReturn(tabComingFrom)).GetCount();
                        Card addedCard = (Solitaire_Game.TableuReturn(tabComingFrom)).GetCard(sizetabFrom);
                        if (Solitaire_Game.AddtoTabLogic(tabCard, addedCard)) {
                            Solitaire_Game.RemoveFromTableu(addedCard, tabComingFrom);
                            Solitaire_Game.AddtoTableu(addedCard, Solitaire_Game.WhichTabPile(tabCard));
                            Solitaire_Game.IncreaseFacesUp(Solitaire_Game.WhichTabPile(tabCard), 1);
                            Solitaire_Game.ReduceFacesUp(tabComingFrom, 1);
                            UpdateTabPiles();
                        } else {
                            MessageBox.Show("Invalid Move");
                        }
                    } else {
                        if (Solitaire_Game.AddtoTabLogic(tabCard, cardInstance)) {
                            originTabFaceUp = Solitaire_Game.FaceUpCards(tabComingFrom);
                            Solitaire_Game.IncreaseFacesUp(tabCardWhich, originTabFaceUp);
                            Solitaire_Game.ReduceFacesUp(tabComingFrom, originTabFaceUp);
                            Solitaire_Game.AddMultipleCards(originTabFaceUp, tabComingFrom, tabCardWhich);
                            UpdateTabPiles();
                        } else {
                            MessageBox.Show("Invalid Move");
                        }

                    }

                }
            }

        }

        /// <summary>
        /// Event handler for when the discard pile is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void discardPile_Click(object sender, EventArgs e) {
            fromDiscard = true;
            // Resets the user input only when neccessary
            // Also determines whether the card is trying to be added onto the discard pile or taken out
            if (reset) {
                Card tempCard = new Card();
                tempCard = clickCard;
                reset = false;
            } else if (fromDiscard & !fromTab & !fromSuit) {
                Card tempCard = new Card();
                tempCard = clickCard;
            } else if (fromTab) {
                fromDiscard = false;
                fromTab = false;
                reset = true;
                MessageBox.Show("Invalid Move, cannot put card from Tab pile back into Discard Pile");
            } else if (fromSuit) {
                fromDiscard = false;
                fromSuit = false;
                reset = true;
                MessageBox.Show("Invalid Move, cannot put card from Suit pile back into Discard Pile");
            }

        }

        /// <summary>
        /// Evaluates when a card from a tableu is added to the suit pile
        /// </summary>
        /// <param name="cardInstance"></param>
        /// <param name="whichSuit"></param>
        /// <param name="tabComingFrom"></param>
        private void SuitReceivedTabCard(Card cardInstance, int whichSuit, int tabComingFrom) {
            fromTab = false;
            reset = true;
            // Logic for adding a card from a tab pile to the suit pile
            if (Solitaire_Game.AddToSuitPile(cardInstance, whichSuit)) {
                int originTabFaceUp = Solitaire_Game.FaceUpCards(tabComingFrom);
                Solitaire_Game.ReduceFacesUp(tabComingFrom, originTabFaceUp-1);
                Solitaire_Game.RemoveFromTableu(cardInstance, tabComingFrom);
                UpdateTabPiles();
                suitPiles[whichSuit].Image = Images.GetCardImage(Solitaire_Game.ReturnSuitTopCard(whichSuit));
            } else {
                MessageBox.Show("Invalid Move");
            }
        }

        /// <summary>
        /// Evaluates when a card from discard pile is added to the suit pile
        /// </summary>
        /// <param name="tempCard"></param>
        /// <param name="whichSuit"></param>
        private void SuitRecievedDiscCard(Card tempCard, int whichSuit) {
            fromDiscard = false;
            reset = true;
            // Logic for addind a card from the discard pile to the suit pile
            if (Solitaire_Game.AddToSuitPile(tempCard, whichSuit)) {
                discHand.Remove(tempCard);
                int discCards = discHand.GetCount();
                if (discCards == 0) {
                    discardPile.Image = null;
                } else {
                    Card nextCard = discHand.GetCard(discCards);
                    discardPile.Image = Images.GetCardImage(nextCard);
                }

                suitPiles[whichSuit].Image = Images.GetCardImage(Solitaire_Game.ReturnSuitTopCard(whichSuit));
            } else {
                MessageBox.Show("Invalid Move");
            }
        }

        /// <summary>
        /// Event handler for when first suit pile is presed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suitPile1_Click(object sender, EventArgs e) {
            if (fromTab) {
                SuitReceivedTabCard(cardInstance, 0, tabComingFrom);
            } else if (fromDiscard) {
                SuitRecievedDiscCard(clickCard, 0);
            }
        }

        /// <summary>
        /// Event handler for when second suit pile is presed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suitPile2_Click(object sender, EventArgs e) {
            if (fromTab) {
                SuitReceivedTabCard(cardInstance, 1, tabComingFrom);
            } else if (fromDiscard) {
                SuitRecievedDiscCard(clickCard, 1);
            }
        }

        /// <summary>
        /// Event handler for when third suit pile is presed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suitPile3_Click(object sender, EventArgs e) {
            if (fromTab) {
                SuitReceivedTabCard(cardInstance, 2, tabComingFrom);
            } else if (fromDiscard) {
                SuitRecievedDiscCard(clickCard, 2);
            }
        }

        /// <summary>
        /// Event handler for when fourth suit pile is presed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suitPile4_Click(object sender, EventArgs e) {
            if (fromTab) {
                SuitReceivedTabCard(cardInstance, 3, tabComingFrom);
            } else if (fromDiscard) {
                SuitRecievedDiscCard(clickCard, 3);
            }
        }
    }
}
