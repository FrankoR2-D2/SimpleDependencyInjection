using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleDependencyInjection
{
    public class GameManger
    {

        private IPlayer _player1;
        private IPlayer _player2;

        public GameManger(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public RoundResult PlayRound()
        {

            Choice player1 = _player1.GetChoice();
            Choice player2 = _player2.GetChoice();


            if (player1 == player2)
            {
                return RoundResult.Draw;
            }

            Console.WriteLine($"Player 1 picks {player1.ToString()} and player 2 picks {player2.ToString()}");
            if (player1 == Choice.Rock && player2 == Choice.Scissors ||
                    player1 == Choice.Paper && player2 == Choice.Rock ||
                        player1 == Choice.Scissors && player2 == Choice.Paper)
            {
                return RoundResult.Player1Win;
            }
            else
            {
                return RoundResult.Player2Win;
            }

        }

    }

    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }

    public enum RoundResult
    {
        Player1Win,
        Player2Win,
        Draw
    }
}