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
            return string.Empty;
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
