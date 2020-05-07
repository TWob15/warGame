using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace warGame
{
    class Deck
    {
        public List<Card> CurrentlyInDeck;

        public void GenerateDeck()
        {
            CurrentlyInDeck = new List<Card>();
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>().ToList();
            var faces = Enum.GetValues(typeof(Face)).Cast<Face>().ToList();
            foreach (var suit in suits)
            {
                foreach (var face in faces)
                {
                    CurrentlyInDeck.Add(new Card(face, suit));
                }

            }
        }

        private static readonly Random rand = new Random();

        public void Shuffle()
        {
            Card holder = new Card();
            int random;

            for (int i = 0; i < 52; i++)
            {
                random = rand.Next(0, 51);
                holder = CurrentlyInDeck[i];
                CurrentlyInDeck[i] = CurrentlyInDeck[random];
                CurrentlyInDeck[random] = holder;
            }
        }

        public void PrintDeck()
        {
            foreach (var card in CurrentlyInDeck)
            {
                card.PrintCard();
            }
        }
    }
}
