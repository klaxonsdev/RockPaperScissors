﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLib
{
    public class RPSGame
    {
        //Setting up the basic game rule to decide who's the winner 
        //
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

    //Setting up the Player classe 
    public class Player
    {
        public Player(string weapon)
        {
            Weapon = weapon;
        }
        public string Weapon { get; }
    }

    //Weapon Choice for player 2
    public enum Weapon {Rock, Paper, Scissors}

}
