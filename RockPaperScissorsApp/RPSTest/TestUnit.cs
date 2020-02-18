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
        public void Player2()
        {
            //Arrange
            output = string.Empty;
            var weaponchoice = (Weapon)(new Random()).Next(0, 3);
            Player player2 = new Player(weaponchoice.ToString());

            //Act
            output = player2.Weapon.ToString();
            //Assert
            Assert.AreEqual(weaponchoice.ToString(), output);
        }
        [Test]
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
        public void RockvsRandom()
        {
            //Arrange
            output = string.Empty;
            Player player1 = new Player("Rock");
            var weaponchoice = (Weapon)(new Random()).Next(0, 3);
            Player player2 = new Player(weaponchoice.ToString());
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
    }
}
