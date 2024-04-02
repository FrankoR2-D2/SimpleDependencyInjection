using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDependencyInjection
{
    public class ComputerPlayer : IPlayer
    {
        private Random _random = new Random();

        public Choice GetChoice()
        {
            Choice player2 = (Choice)_random.Next(0, 3);
            return player2;

        }
    }
}
