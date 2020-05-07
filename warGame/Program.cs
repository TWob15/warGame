using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace warGame
{
    class Program
    {
        public static bool isPlaying = true;
        public static Player human = new Player();
        public static Player cpu = new Player();
        public static int round = 1;
        static void Main(string[] args)
        {
            GameFlow.Start(human, cpu);
            while (isPlaying)
            {
                for (int i = 0; i < 52; i++)
                {
                    GameFlow.Gameplay(human, cpu, round);
                    round++;
                }

                round = 1;
                GameFlow.Ending(human, cpu);
            }

            ReadKey();
        }
    }
}
