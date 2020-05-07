using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace warGame
{
    class Words
    {
        public static void Begin()
        {
            WriteLine("Hello! Welcome to the Game of War!");
            WriteLine();
            WriteLine("The rules are simple. It's you vs a CPU.");
            WriteLine();
            WriteLine("You each pull 1 card from your decks and see which is highest.");
            WriteLine();
            WriteLine("Your card will be the one under your name, while the other is the CPUs.");
            WriteLine();
            WriteLine("The one with the most points at the end wins all the glory!");
            WriteLine();
            WriteLine("Understand?");
            WriteLine();
            WriteLine("Press enter if you're ready for the battle.");
            ReadLine();
            Clear();
        }

        public static void Template(Player hum, Player cpu, int round)
        {
            int distance = 17; //distance between the 2 names
            Write("{0} wins = {1}", hum.name, hum.wins);
            Write("          R{0}", round);
            distance -= hum.name.Length;
            while (distance > 0)
            {
                Write(" ");
                distance--;
            }
            Write("{0} wins = {1}", cpu.name, cpu.wins);
            WriteLine();
            WriteLine();
            hum.currentCard.PrintCard();
            Write("     vs     ");
            cpu.currentCard.PrintCard();
        }

        public static void LastWords(Player hum, Player cpu)
        {
            WriteLine("Thats all the Cards!");
            WriteLine();
            WriteLine("The Final score: {0} = {1} and {2} = {3}", hum.name, hum.wins, cpu.name, cpu.wins);
            WriteLine();

            if (hum.wins > cpu.wins)
            {
                WriteLine("{0} has bested the CPU in this Game of War! Congratulations!", hum.name);
                WriteLine();
            }

            else if (cpu.wins > hum.wins)
            {
                WriteLine("The CPU has bested {0} in a Game of War! Sorry...", hum.name);
                WriteLine();
            }

            else
            {
                WriteLine("Its a draw. Better luck next time.");
                WriteLine();
            }
        }
    }
}
