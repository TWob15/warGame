using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace warGame
{
    class Create
    {
        public static void Name(Player a)
        {
            a.SetName();
        }

        public static void TheirDecks(Player hum, Player cpu)
        {
            hum.myDeck.GenerateDeck();
            cpu.myDeck.GenerateDeck();

            hum.myDeck.Shuffle();
            cpu.myDeck.Shuffle();
        }

    }
}
