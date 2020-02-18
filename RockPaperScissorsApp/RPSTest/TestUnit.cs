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
            Player player1 = new RPSLib.Player("Rock");

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
            RPSLib.Player player1 = new RPSLib.Player("Rock");
            RPSLib.Player player2 = new RPSLib.Player("Rock");
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
            RPSLib.Player player1 = new RPSLib.Player("Rock");
            RPSLib.Player player2 = new RPSLib.Player("Paper");
            //Act
            output = RPSGame.GameRules(player1, player2);
            //Assert
            Assert.AreEqual("Player 2", output);
        }
    }
}
