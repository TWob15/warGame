using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace warGame
{
    public enum Suit { Hearts, Diamonds, Spades, Clubs }
    public enum Face { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
    class Card
    {
        public Card()
        {
        }

        public Card(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public Suit suit { get; set; }
        public Face face { get; set; }

        public void PrintCard()
        {
            Write("{0} of {1}", face, suit);
        }

    }
}
