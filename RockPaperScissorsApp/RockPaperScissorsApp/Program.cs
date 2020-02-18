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
            for (int i = 1; i < 101; i++)
            {
                var weaponchoice = (Weapon)(new Random()).Next(0, 3);
                Player player2 = new Player(weaponchoice.ToString());
                GameWinner= RPSGame.GameRules(player1, player2);
                Console.WriteLine("Game #"+ i);
                Console.WriteLine("Player 1 choose: " + player1.Weapon);
                Console.WriteLine("Player 2 choose: " + player2.Weapon);
                Console.WriteLine("winner is: " + GameWinner);
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
    }
}
