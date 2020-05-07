using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace warGame
{
    class Player
    {

        public string name = "CPU";
        public Card currentCard = new Card();
        public int wins = 0, drawCount = 0;
        public Deck myDeck = new Deck();

        public void DrawOne()
        {
            currentCard = myDeck.CurrentlyInDeck[drawCount];
            drawCount++;
            if(drawCount == 52)
            {
                drawCount = 0;
            }
        }

        public void SetName()
        {
            while(name == "CPU" || name == "")
            {
                Write("Please Enter your Name: ");
                name = ReadLine();
                
                if(name == "CPU" || name == "")
                {
                    WriteLine("Invalid Name. Please enter a Correct Name.");
                }

                Clear();
            }
        }

    }
}
