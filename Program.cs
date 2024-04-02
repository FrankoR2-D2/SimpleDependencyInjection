
using SimpleDependencyInjection;
using static SimpleDependencyInjection.GameManger;

class Program
{
    static void Main(string[] args)
    {
        GameManger game = new GameManger(new HumanPlayer(), new ComputerPlayer());

        do
        {
            RoundResult result = game.PlayRound();

            if (result == RoundResult.Player1Win)
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if (result == RoundResult.Player2Win)
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        } while (Console.ReadLine().ToUpper() == "Y");
    }
}