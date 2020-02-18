using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLib
{
    public class RPSGame
    {
        public static string GameRules(Player player1,Player player2)
        {
            string winner = string.Empty;
            if (player1.Weapon==player2.Weapon)
            {
                winner = "Draw";
            }
            else if (player2.Weapon=="Paper")
            {
                winner = "Player 2";
            }
            else
            {
                winner = "Player 1";
            }
            return winner;
        }
    }

    public class Player
    {
        public Player(string weapon)
        {
            Weapon = weapon;
        }
        public string Weapon { get; }
    }

    public enum Weapon {Rock, Paper, Scissors}

}
