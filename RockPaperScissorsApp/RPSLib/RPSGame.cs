using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLib
{
    public class RPSGame
    {
        //Setting up the basic game rule to decide who's the winner 
        //only for Player 1 = Rock Player 2 = Random
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
                player2.Winnings++;
            }
            else
            {
                winner = "Player 1";
                player1.Winnings++;
            }
            return winner;
        }

        public static string RandomWeapon()
        {
            string[] weapon = { "Rock", "Paper", "Scissors" };
            Random rnd = new Random();
            int rndWeaponIndex = rnd.Next(weapon.Length);
            return weapon[rndWeaponIndex];
        }
    }

    //Setting up the Player class
    public class Player
    {
        public Player(string weapon)
        {
            Weapon = weapon;
        }
        //Constructor
        public Player()
        {
            
        }
        // Player attributes
        public string Weapon { get; set; }
        public int Winnings { get; set; }
    }


}
