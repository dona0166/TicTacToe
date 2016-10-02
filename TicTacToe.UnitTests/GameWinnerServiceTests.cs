using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    class GameWinnerServiceTests
    {
        [Test]
        public void NeitherPlayerHasThreeInARow()
        {
            const char expected = ' ';
            var gameBoard = new char[3, 3] { {' ', ' ',' '},
                                             {' ', ' ',' '},
                                             {' ',' ',' '}};
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected, actual);
        }
    }
}
