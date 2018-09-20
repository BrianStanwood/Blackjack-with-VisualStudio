/* Created by Brian Stanwood for ITCS 3112
 * This class creates cards that have a front and back image as well as the 
 * associated value in Blackjack for that card.
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalApp
{
    class Card
    {
        public System.Drawing.Image image { get; set; }
        public System.Drawing.Image backImage { get; set; }
        public int cardVal { get; set; }
        
        
        public Card(System.Drawing.Image pic, int num, System.Drawing.Image back)
        {
            image = pic;
            backImage = back;
            cardVal = num;
        }
    }
}
