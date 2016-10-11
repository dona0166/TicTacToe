using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicTacToe.Services;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    class GameWinnerServiceTests
    {
        IGameWinnerService _gameWinnerService;
        private char[,] _gameBoard;

        [SetUp]
        public void SetupUnitTests()
        {
            _gameWinnerService = new GameWinnerService();
            _gameBoard = new char[3, 3] { {' ',' ',' '},
                                             {' ', ' ',' '},
                                             {' ',' ',' '}};


        }

        [Test]
        public void NeitherPlayerHasThreeInARow()
        {

            IGameWinnerService gameWinnerService;
            gameWinnerService = new GameWinnerService();
            const char expected = ' ';
            var gameBoard = new char[3, 3] { {' ', ' ',' '},
                                             {' ', ' ',' '},
                                             {' ',' ',' '}};
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayerWithAllSpacesInTopRowIsWinner()
        {
            IGameWinnerService gameWinnerService;
            gameWinnerService = new GameWinnerService();
            const char expected = 'X';
            var gameBoard = new char[3, 3]
            { {expected, expected, expected},
              {' ', ' ', ' '},
              {' ', ' ', ' '} };
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(),
            actual.ToString());
        }

        [Test]
        public void PlayerWithAllSpacesInFirstColumnIsWinner()
        {
            const char expected = 'X';
            for (var columnIndex = 0; columnIndex < 3; columnIndex++)
            {
                _gameBoard[columnIndex, 0] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void PlayerWithThreeInARowDiagonallyDownAndToRightIsWinner()
        {
            const char expected = 'X';
            for (var cellIndex = 0; cellIndex < 3; cellIndex++)
            {
                _gameBoard[cellIndex, cellIndex] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }





    }
}
