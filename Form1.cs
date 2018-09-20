/* Created by Brian Stanwood for ITCS 3112
 * This is a Windows Forms GUI program for playing the card game "Blackjack".
 * The objective is to get your cards equal to 21 without going over or "busting".
 * If their is a tie, dealer always wins over the player. Otherwise, the highest 
 * score wins.
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApp
{
    public partial class Form1 : Form
    {
        // Creates all 52 cards associating their image and value as well as back image to simulate being 
        // flipped over.
        Card ASpades = new Card(Image.FromFile("cards/ASpades.png"), 11, Image.FromFile("cards/back.png")); 
        Card twoSpades = new Card(Image.FromFile("cards/2Spades.png"), 2, Image.FromFile("cards/back.png"));
        Card threeSpades = new Card(Image.FromFile("cards/3Spades.png"), 3, Image.FromFile("cards/back.png"));
        Card fourSpades = new Card(Image.FromFile("cards/4Spades.png"), 4, Image.FromFile("cards/back.png"));
        Card fiveSpades = new Card(Image.FromFile("cards/5Spades.png"), 5, Image.FromFile("cards/back.png"));
        Card sixSpades = new Card(Image.FromFile("cards/6Spades.png"), 6, Image.FromFile("cards/back.png"));
        Card sevenSpades = new Card(Image.FromFile("cards/7Spades.png"), 7, Image.FromFile("cards/back.png"));
        Card eightSpades = new Card(Image.FromFile("cards/8Spades.png"), 8, Image.FromFile("cards/back.png"));
        Card nineSpades = new Card(Image.FromFile("cards/9Spades.png"), 9, Image.FromFile("cards/back.png"));
        Card tenSpades = new Card(Image.FromFile("cards/10Spades.png"), 10, Image.FromFile("cards/back.png"));
        Card jackSpades = new Card(Image.FromFile("cards/JackSpades.png"), 10, Image.FromFile("cards/back.png"));
        Card queenSpades = new Card(Image.FromFile("cards/QueenSpades.png"), 10, Image.FromFile("cards/back.png"));
        Card kingSpades = new Card(Image.FromFile("cards/KingSpades.png"), 10, Image.FromFile("cards/back.png"));
        Card AClubs = new Card(Image.FromFile("cards/AClubs.png"), 11, Image.FromFile("cards/back.png"));
        Card twoClubs = new Card(Image.FromFile("cards/2Clubs.png"), 2, Image.FromFile("cards/back.png"));
        Card threeClubs = new Card(Image.FromFile("cards/3Clubs.png"), 3, Image.FromFile("cards/back.png"));
        Card fourClubs = new Card(Image.FromFile("cards/4Clubs.png"), 4, Image.FromFile("cards/back.png"));
        Card fiveClubs = new Card(Image.FromFile("cards/5Clubs.png"), 5, Image.FromFile("cards/back.png"));
        Card sixClubs = new Card(Image.FromFile("cards/6Clubs.png"), 6, Image.FromFile("cards/back.png"));
        Card sevenClubs = new Card(Image.FromFile("cards/7Clubs.png"), 7, Image.FromFile("cards/back.png"));
        Card eightClubs = new Card(Image.FromFile("cards/8Clubs.png"), 8, Image.FromFile("cards/back.png"));
        Card nineClubs = new Card(Image.FromFile("cards/9Clubs.png"), 9, Image.FromFile("cards/back.png"));
        Card tenClubs = new Card(Image.FromFile("cards/10Clubs.png"), 10, Image.FromFile("cards/back.png"));
        Card jackClubs = new Card(Image.FromFile("cards/JackClubs.png"), 10, Image.FromFile("cards/back.png"));
        Card queenClubs = new Card(Image.FromFile("cards/QueenClubs.png"), 10, Image.FromFile("cards/back.png"));
        Card kingClubs = new Card(Image.FromFile("cards/KingClubs.png"), 10, Image.FromFile("cards/back.png"));
        Card AHearts = new Card(Image.FromFile("cards/AHearts.png"), 11, Image.FromFile("cards/back.png"));
        Card twoHearts = new Card(Image.FromFile("cards/2Hearts.png"), 2, Image.FromFile("cards/back.png"));
        Card threeHearts = new Card(Image.FromFile("cards/3Hearts.png"), 3, Image.FromFile("cards/back.png"));
        Card fourHearts = new Card(Image.FromFile("cards/4Hearts.png"), 4, Image.FromFile("cards/back.png"));
        Card fiveHearts = new Card(Image.FromFile("cards/5Hearts.png"), 5, Image.FromFile("cards/back.png"));
        Card sixHearts = new Card(Image.FromFile("cards/6Hearts.png"), 6, Image.FromFile("cards/back.png"));
        Card sevenHearts = new Card(Image.FromFile("cards/7Hearts.png"), 7, Image.FromFile("cards/back.png"));
        Card eightHearts = new Card(Image.FromFile("cards/8Hearts.png"), 8, Image.FromFile("cards/back.png"));
        Card nineHearts = new Card(Image.FromFile("cards/9Hearts.png"), 9, Image.FromFile("cards/back.png"));
        Card tenHearts = new Card(Image.FromFile("cards/10Hearts.png"), 10, Image.FromFile("cards/back.png"));
        Card jackHearts = new Card(Image.FromFile("cards/JackHearts.png"), 10, Image.FromFile("cards/back.png"));
        Card queenHearts = new Card(Image.FromFile("cards/QueenHearts.png"), 10, Image.FromFile("cards/back.png"));
        Card kingHearts = new Card(Image.FromFile("cards/KingHearts.png"), 10, Image.FromFile("cards/back.png"));
        Card ADiamonds = new Card(Image.FromFile("cards/ADiamonds.png"), 11, Image.FromFile("cards/back.png"));
        Card twoDiamonds = new Card(Image.FromFile("cards/2Diamonds.png"), 2, Image.FromFile("cards/back.png"));
        Card threeDiamonds = new Card(Image.FromFile("cards/3Diamonds.png"), 3, Image.FromFile("cards/back.png"));
        Card fourDiamonds = new Card(Image.FromFile("cards/4Diamonds.png"), 4, Image.FromFile("cards/back.png"));
        Card fiveDiamonds = new Card(Image.FromFile("cards/5Diamonds.png"), 5, Image.FromFile("cards/back.png"));
        Card sixDiamonds = new Card(Image.FromFile("cards/6Diamonds.png"), 6, Image.FromFile("cards/back.png"));
        Card sevenDiamonds = new Card(Image.FromFile("cards/7Diamonds.png"), 7, Image.FromFile("cards/back.png"));
        Card eightDiamonds = new Card(Image.FromFile("cards/8Diamonds.png"), 8, Image.FromFile("cards/back.png"));
        Card nineDiamonds = new Card(Image.FromFile("cards/9Diamonds.png"), 9, Image.FromFile("cards/back.png"));
        Card tenDiamonds = new Card(Image.FromFile("cards/10Diamonds.png"), 10, Image.FromFile("cards/back.png"));
        Card jackDiamonds = new Card(Image.FromFile("cards/JackDiamonds.png"), 10, Image.FromFile("cards/back.png"));
        Card queenDiamonds = new Card(Image.FromFile("cards/QueenDiamonds.png"), 10, Image.FromFile("cards/back.png"));
        Card kingDiamonds = new Card(Image.FromFile("cards/KingDiamonds.png"), 10, Image.FromFile("cards/back.png"));
        // creates players
        Player dealer = new Player();
        Player player1 = new Player();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void labelPScore_Click(object sender, EventArgs e)
        {
           
        }

        // Initial starting of the game by dealing beginning cards and showing scores 
        private void buttonStart_Click(object sender, EventArgs e)
        {
            startDeal();  // deals 2 cards to each player and updates player's score
            buttonStay.Visible = true;
            buttonHit.Visible = true;
            labelDScore.Visible = true;
            labelPScore.Visible = true;
            buttonStart.Visible = false;
        }

        // Gives the player another card in attempts to get to 21
        private void buttonHit_Click(object sender, EventArgs e)
        {
            if (picP3.Visible == false)
            {
                player1.hand[2] = cardFromDeck();   // deals the player object a randomized card for their hand array
                picP3.Image = player1.hand[2].image;  // puts the image of new card into the picP3 Picture Box
                picP3.Visible = true; // makes the Picture Box visible to the player and thus the new card as well
                labelPScore.Text = getScore(player1.hand).ToString(); // updates the players score label
            } else if (picP4.Visible == false)
            {
                player1.hand[3] = cardFromDeck();
                picP4.Image = player1.hand[3].image;
                picP4.Visible = true;
                labelPScore.Text = getScore(player1.hand).ToString();
            }
            else if (picP5.Visible == false)
            {
                player1.hand[4] = cardFromDeck();
                picP5.Image = player1.hand[4].image;
                picP5.Visible = true;
                buttonHit.Visible = false;
                labelPScore.Text = getScore(player1.hand).ToString();
                findWinner();
            }
            if (Convert.ToInt32(labelPScore.Text) > 21)  // player has busted
            {
                labelBust.Visible = true;
                findWinner();  // players turn is over and goes to the findWinner() method for dealers turn
            }
        }

        // Player wants to end turn
        private void buttonStay_Click(object sender, EventArgs e)
        {
            findWinner();
        }

        // Continue button restarts a new game after a winner is found and scores are updated
        private void buttonCont_Click(object sender, EventArgs e)
        {
            // clear out previous player and deal hands
            player1 = new Player();
            dealer = new Player();
            // hide unwanted items
            labelRead.Visible = false;
            buttonCont.Visible = false;
            labelBust.Visible = false;
            labelDBusts.Visible = false;
            picP3.Visible = false;
            picP4.Visible = false;
            picP5.Visible = false;
            picD3.Visible = false;
            picD4.Visible = false;
            picD5.Visible = false;
            // show needed buttons
            buttonStay.Visible = true;
            buttonHit.Visible = true;
            labelDScore.Text = "?";
            startDeal();  // start a new deal (start another round)
        }

        // This method uses a random number to pick a card from the array of cards "deck" and returns the card picked
        private Card cardFromDeck()
        {
            Random rand = new Random(DateTime.Now.Millisecond); // random generator
            int i = rand.Next(52);
            Card[] deck = new Card[] { ASpades, twoSpades,threeSpades,fourSpades,fiveSpades,sixSpades,sevenSpades, eightSpades,
                            nineSpades, tenSpades, jackSpades, queenSpades, kingSpades, AHearts, twoHearts, threeHearts, fourHearts,
                            fiveHearts, sixHearts, sevenHearts, eightHearts, nineHearts, tenHearts, jackHearts, queenHearts, kingHearts,
                            AClubs, twoClubs, threeClubs, fourClubs, fiveClubs, sixClubs, sevenClubs, eightClubs, nineClubs, tenClubs,
                            jackClubs, queenClubs, kingClubs, ADiamonds, twoDiamonds, threeDiamonds, fourDiamonds, fiveDiamonds, sixDiamonds,
                            sevenDiamonds, eightDiamonds, nineDiamonds, tenDiamonds, jackDiamonds, queenDiamonds, kingDiamonds};
            System.Threading.Thread.Sleep(13); // makes the program wait 13 milliseconds before repicking; in case of same card
            for (int k = 0; k < 5; k++) // for loop checks if deck[i] is in dealer or players hand already
            {
                if (dealer.hand[k] == deck[i] || player1.hand[k] == deck[i])
                {
                    cardFromDeck();
                }
            }
            System.Threading.Thread.Sleep(13); // makes the program wait 13 milliseconds before repicking; in case of another method call afterwards
            return deck[i];
        }

        // Deals the beginning cards at the start of game
        private void startDeal()
        {
            // dealer gets two cards 
            dealer.hand[0] = cardFromDeck();
            dealer.hand[1] = cardFromDeck();    
            // player gets two cards
            player1.hand[0] = cardFromDeck();
            player1.hand[1] = cardFromDeck();
            // updates images on picture box so user can see what cards where dealt
            picD1.Image = dealer.hand[0].backImage;  // upside down card for the dealer
            picD2.Image = dealer.hand[1].image;
            picP1.Image = player1.hand[0].image;
            picP2.Image = player1.hand[1].image;
            // update players score
            labelPScore.Text = getScore(player1.hand).ToString();
        }

        // finds the current score of player's or dealer's cards and returns the value
        private int getScore(Card[] array)
        {
            int value = 0;
            int aces = 0;
            // cycle through given array of cards to add values to score and count how many aces are inside
            for(int i = 0; i < array.Length; i++)
            {
                try
                {
                    value = array[i].cardVal + value; 
                    if (array[i].cardVal == 11)
                    {
                        aces++;
                    }
                }
                catch { }   // if null value for the rest of hand, discards null error and continues
            }
            while (aces > 0)   // if aces are inside, change the total score if appropriate
            {
                if (value > 21)
                {
                    value = value - 10;  // essentially turns 11 into 1 
                    aces--;
                }
                else
                {
                    aces--;  // no need to change the value of the ace (which is 11)
                }
            }
            return value;
        }

        // This method is called when player is done with their turn. The method handles the dealers turn and 
        // the calculation to find and annouce the winner as well as updating the winners score
        private void findWinner()
        {
            // hides unwanted buttons
            buttonHit.Visible = false;
            buttonStay.Visible = false;

            dealerPlays();  // dealer plays to beat player
            picD1.Image = dealer.hand[0].image; // uncover dealers hidden card
            labelDScore.Text = getScore(dealer.hand).ToString(); // display dealers final score

            // finds winner from comparing final scores
            int playerScore = Convert.ToInt32(labelPScore.Text);
            int dealerScore = Convert.ToInt32(labelDScore.Text);
            if (playerScore < 22 && playerScore > dealerScore && dealerScore < 22 || playerScore < 22 && picP5.Visible == true || dealerScore > 21 && playerScore < 22)
            {
                labelRead.Text = "You Won!";
                labelPWins.Text = (Convert.ToInt32(labelPWins.Text) + 1).ToString();
            } else
            {
                labelRead.Text = "Dealer Won.";
                labelDWins.Text = (Convert.ToInt32(labelDWins.Text) + 1).ToString(); 
            }

            // show needed buttons to continue with game
            buttonCont.Visible = true;
            labelRead.Visible = true;
        }
        
        // This method handles the dealers turn in its attempt to beat the player
        private void dealerPlays()
        {
            labelDScore.Text = getScore(dealer.hand).ToString(); // shows score for comparison purposes
            if (labelBust.Visible == false) // if player hasn't busted
            {
                if (picD3.Visible == false && getScore(dealer.hand) < getScore(player1.hand)) // pick another card if score is less than players
                {
                    dealer.hand[2] = cardFromDeck();  // takes another card
                    picD3.Image = dealer.hand[2].image;  // updates the image for the new card
                    picD3.Visible = true;  // shows the user the dealer's new card
                    labelDScore.Text = getScore(dealer.hand).ToString(); // updates dealer's score
                }
                if (picD4.Visible == false && getScore(dealer.hand) < getScore(player1.hand))
                {
                    dealer.hand[3] = cardFromDeck();
                    picD4.Image = dealer.hand[3].image;
                    picD4.Visible = true;
                    labelDScore.Text = getScore(dealer.hand).ToString();
                }
                if (picD5.Visible == false && getScore(dealer.hand) < getScore(player1.hand))
                {
                    dealer.hand[4] = cardFromDeck();
                    picD5.Image = dealer.hand[4].image;
                    picD5.Visible = true;
                    labelDScore.Text = getScore(dealer.hand).ToString();
                }
                if (Convert.ToInt32(labelDScore.Text) > 21)  // dealer busted
                {
                    labelDBusts.Visible = true;
                }
            }
        }

        
    }
}
