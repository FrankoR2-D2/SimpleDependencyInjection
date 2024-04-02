
using SimpleDependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDependencyInjection
{
    class HumanPlayer : IPlayer
    {

        public Choice GetChoice()
        {
            //Player 1 (human)
            Choice player1;

            do
            {
                Console.Write("Enter Choice (Rock, Paper, Scissors): ");
                string? input = Console.ReadLine().ToUpper();

                if ((input == "R"))
                {
                    player1 = Choice.Rock;
                    break;
                }
                else if (input == "P")
                {
                    player1 = Choice.Paper;
                    break;
                }
                else if (input == "S")
                {
                    player1 = Choice.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Please try again.");
                }

            } while (true);

            return player1;
        }   

    }
}
