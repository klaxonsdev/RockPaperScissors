using System;
using RPSLib;

namespace RockPaperScissorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player player1 = new Player("Rock");
            Player player2 = new Player();
            string GameWinner = string.Empty;
            for (int i = 1; i < 101; i++)
            {
                player2.Weapon = (RPSGame.RandomWeapon());
                GameWinner= RPSGame.GameRules(player1, player2);
                Console.WriteLine("Game #"+ i);
                Console.WriteLine("Player 1 choose: " + player1.Weapon);
                Console.WriteLine("Player 2 choose: " + player2.Weapon);
                Console.WriteLine("winner is: " + GameWinner);
                Console.WriteLine();
            }
            Console.WriteLine("Player 1 Wins: " + player1.Winnings + " times\n"
                + "Player 2 Wins: " + player2.Winnings + " times");
            Console.ReadKey(); 
        }
    }
}
