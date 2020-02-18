using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLib
{
    public class RPSGame
    {

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
