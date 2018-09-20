/* Created by Brian Stanwood for ITCS 3112
 * This class creates players which player and dealer are the players created
 * for this program. Each player has a hand of 5 cards max at any given time
 * so they are given a Card array with 5 slots.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp
{
    class Player
    {
        public Card[] hand = new Card[5]; 

        public Player()
        {
    
        }
    }
}
