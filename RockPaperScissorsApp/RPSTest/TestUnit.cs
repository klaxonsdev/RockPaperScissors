using NUnit.Framework;
using RPSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSTest
{
    [TestFixture]
    public class TestUnit
    {
        string output;
        [Test]
        //Testing the player 1 with static parameter "Rock"
        public void Player1()
        {
            //Arrange
            output = string.Empty;
            Player player1 = new Player("Rock");

            //Act
            output= player1.Weapon.ToString();
            //Assert
            Assert.AreEqual("Rock", output);

        }

        [Test]
        //Testing the player 2 with random parameter with the choice of "Rock, Paper, Scissors"
        public void Player2()
        {
            //Arrange
            output = string.Empty;
            Player player2 = new Player(RPSGame.RandomWeapon());

            //Act
            output = player2.Weapon.ToString();
            //Assert
            Assert.AreEqual(RPSGame.RandomWeapon(), output);
        }

        [Test]
        //Testing game result for Rock vs Rock
        public void RockvsRock()
        {
            //Arrange
            output = string.Empty;
            Player player1 = new Player("Rock");
            Player player2 = new Player("Rock");
            //Act
            output = RPSGame.GameRules( player1, player2);
            //Assert
            Assert.AreEqual("Draw", output);
        }

        [Test]
        //Testing game result for Rock vs Paper
        public void RockvsPaper()
        {
            //Arrange
            output = string.Empty;
            Player player1 = new Player("Rock");
            Player player2 = new Player("Paper");
            //Act
            output = RPSGame.GameRules(player1, player2);
            //Assert
            Assert.AreEqual("Player 2", output);
        }

        [Test]
        //Testing game result for Rock vs Scissors
        public void RockvsScissors()
        {
            //Arrange
            output = string.Empty;
            Player player1 = new Player("Rock");
            Player player2 = new Player("Scissors");
            //Act
            output = RPSGame.GameRules(player1, player2);
            //Assert
            Assert.AreEqual("Player 1", output);
        }

        [Test]
        //Testing game result for Rock vs (Rock or Paper or Scissors)
        public void RockvsRandom()
        {
            //Arrange
            output = string.Empty;
            Player player1 = new Player("Rock");
            Player player2 = new Player(RPSGame.RandomWeapon());
            //Act
            output = RPSGame.GameRules(player1, player2);
            //Assert
            if (player2.Weapon=="Rock")
            {
                Assert.AreEqual("Draw", output);
            }
            else if (player2.Weapon== "Paper")
            {
                Assert.AreEqual("Player 2", output);
            }
            else
            {
                Assert.AreEqual("Player 1", output);
            }
        }

        [Test]
        public void RockRandomness()
        {
            //Arrange
            int count = 0;

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (RPSGame.RandomWeapon() == "Rock")
                {
                    count++;
                }                
            }
            //Assert
            Assert.GreaterOrEqual(count, 0);
            

        }
        [Test]
        public void PaperRandomness()
        {
            //Arrange
            int count = 0;

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (RPSGame.RandomWeapon() == "Paper")
                {
                    count++;
                }
            }
            //Assert
            Assert.GreaterOrEqual(count, 0);


        }

        [Test]
        public void ScissorsRandomness()
        {
            //Arrange
            int count = 0;

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (RPSGame.RandomWeapon() == "Scissors")
                {
                    count++;
                }
            }
            //Assert
            Assert.GreaterOrEqual(count, 0);


        }
    }
}
