using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace warGame
{
    class GameFlow
    {
        static public void Start(Player hum, Player cpu)
        {
            Words.Begin();
            Create.TheirDecks(hum, cpu);
            Create.Name(hum);
        }

        static public void ShuffleDecks(Player hum, Player cpu)
        {
            hum.myDeck.Shuffle();
            cpu.myDeck.Shuffle();
        }

        static public void DrawCards(Player hum, Player cpu)
        {
            hum.DrawOne();
            cpu.DrawOne();
        }

        static public void Gameplay(Player hum, Player cpu, int round)
        {
            GameFlow.DrawCards(hum, cpu);
            Words.Template(hum, cpu, round);
            GameFlow.CheckWin(hum, cpu);
        }

        static public void Ending(Player hum, Player cpu)
        {
            string answer = "";
            bool correctForm = false;
            Words.LastWords(hum, cpu);
            while (!correctForm)
            {
                Write("Would you like to play again? Enter y for yes or n for no: ");
                answer = ReadLine();
                answer = answer.ToLower();

                if (answer != "y" && answer != "n")
                {
                    WriteLine("Thats not a valid option.");
                    WriteLine("Press enter to continue.");
                    ReadLine();
                    Clear();
                    Words.LastWords(hum, cpu);
                }

                if (answer == "y" || answer == "n")
                {
                    correctForm = true;
                }
            }

            if (answer == "y")
            {
                PlayingAgain(hum, cpu);
                Clear();
            }

            else if (answer == "n")
            {
                WriteLine("Thanks for Playing!");
                WriteLine();
                WriteLine("Press enter to exit.");
                Environment.Exit(0);
            }
        }

        static public void PlayingAgain(Player hum, Player cpu)
        {
            ShuffleDecks(hum, cpu);
            hum.wins = 0;
            cpu.wins = 0;
        }

        static public void CheckWin(Player hum, Player cpu)
        {
            WriteLine("");
            if ((int)hum.currentCard.face > (int)cpu.currentCard.face)
            {
                hum.wins++;
                WriteLine();
                WriteLine("{0} Wins This Round!", hum.name);
                WriteLine();
                WriteLine("Press enter to keep going.");
                ReadLine();
                Clear();
            }

            else if ((int)hum.currentCard.face < (int)cpu.currentCard.face)
            {
                cpu.wins++;
                WriteLine();
                WriteLine("CPU wins this round.");
                WriteLine();
                WriteLine("Press enter to keep going.");
                ReadLine();
                Clear();
            }

            else
            {
                WriteLine();
                WriteLine("Its a Draw!");
                WriteLine();
                WriteLine("Press enter to keep going.");
                ReadLine();
                Clear();
            }
        }

    }
}
