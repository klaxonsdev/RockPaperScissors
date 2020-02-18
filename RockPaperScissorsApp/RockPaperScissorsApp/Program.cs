using System;
using RPSLib;

namespace RockPaperScissorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player player1 = new Player("Rock");
            string GameWinner = string.Empty;
            int player1winnings = 0;
            int player2winnings = 0;
            for (int i = 1; i < 101; i++)
            {
                Player player2 = new Player(RPSGame.RandomWeapon());
                GameWinner= RPSGame.GameRules(player1, player2);
                Console.WriteLine("Game #"+ i);
                Console.WriteLine("Player 1 choose: " + player1.Weapon);
                Console.WriteLine("Player 2 choose: " + player2.Weapon);
                Console.WriteLine("winner is: " + GameWinner);
                Console.WriteLine();
                if (GameWinner=="Player 1")
                {
                    player1winnings++;
                }
                if (GameWinner=="Player 2")
                {
                    player2winnings++;
                }
            }
            Console.WriteLine("Player 1 Wins: " + player1winnings + " times\n"
                + "Player 2 Wins: " + player2winnings + " times");
            Console.ReadKey(); 
        }
    }
}
