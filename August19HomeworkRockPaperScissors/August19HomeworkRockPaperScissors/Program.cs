using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August19HomeworkRockPaperScissors
{

    interface IPlayer
    {
        int NumberOfWins { get; set; }
        string Act();
    }

    class PlayerRock : IPlayer, IPlayerRock
    {
        public int NumberOfWins { get; set; }
        public string Act()
        {
            return "Rock";
        }
    }
    class PlayerScissors : IPlayer, IPlayerScissors
    {
        public int NumberOfWins { get; set; }
        public string Act()
        {
            return "Scissors";
        }
    }
    class PlayerPaper : IPlayer, IPlayerPaper
    {
        public int NumberOfWins { get; set; }
        public string Act()
        {
            return "Paper";
        }
    }
    class Game
    {
       static IPlayer Fight(IPlayer player1, IPlayer player2)
        {
            if (player1.Act() == "Rock" && player2.Act() == "Paper")
            {
                player2.NumberOfWins++;
                return player2;
            }
            if (player1.Act() == "Rock" && player2.Act() == "Scissors")
            {
                player1.NumberOfWins++;
                return player1;
            }
            player1.NumberOfWins++;
            return player1;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            var rdmnumber = random.Next(3);
            var playerRock = new PlayerRock();
            var playerPaper = new PlayerPaper();
            var playerScissors = new PlayerScissors();
            for (var i = 0; i <= 99; i++)
            {
                 rdmnumber = random.Next(3);

                if (rdmnumber == 0)
                {
                    Fight(playerRock, playerPaper);
                }
               else if (rdmnumber == 1)
                {
                    Fight(playerRock, playerScissors);
                }
                else if (rdmnumber == 2)
                {
                    Fight(playerScissors, playerPaper);
                }
            }
            Console.WriteLine(playerRock.NumberOfWins +  " Rock");
            Console.WriteLine(playerPaper.NumberOfWins + " Paper"); ;
            Console.WriteLine(playerScissors.NumberOfWins + " Scissors");
            Console.ReadLine();
        }
        
    }
}



