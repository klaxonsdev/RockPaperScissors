using NUnit.Framework;
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
            RPSLib.Player player1 = new RPSLib.Player("Rock");

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
            var weaponchoice = (RPSLib.Weapon)(new Random()).Next(0, 3);
            RPSLib.Player player2 = new RPSLib.Player(weaponchoice.ToString());

            //Act
            output = player2.Weapon.ToString();
            //Assert
            Assert.AreEqual(weaponchoice.ToString(), output);
        }
        [Test]
        public void WhoWin()
        {
            //Arrange
            output = string.Empty;
            

            //Act
            output = player2.Weapon.ToString();
            //Assert
            Assert.AreEqual(weaponchoice.ToString(), output);
        }

    }
}
