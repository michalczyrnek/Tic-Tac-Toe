
using NUnit.Framework;
using System.Reflection;
using Tic_Tac_Toe.Game_Engine;
using Tic_Tac_Toe.Tools;

namespace TicTacToeTests
{
    public class WinnerCheckerTest
    {
        private Board board;
        private WinnerChecker winnerchecker;

        [SetUp]
        public void Setup()
        {
            board = new Board();
            winnerchecker = new WinnerChecker();

        }

        [Test]
        public void IsCheckRowsGiveTrueForFirst()
        {

            //given
            board.board[0, 0] = (CellTypes.O);
            board.board[0, 1]= CellTypes.O;
            board.board[0, 2] = CellTypes.O;


            //when
            bool result =  winnerchecker.CheckRows(board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckRowsGiveTrueForSecond()
        {

            //given
            board.board[1, 0] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[1, 2] = CellTypes.O;


            //when
            bool result = winnerchecker.CheckRows(board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckRowsGiveTrueForThird()
        {

            //given
            board.board[2, 0] = (CellTypes.O);
            board.board[2, 1] = CellTypes.O;
            board.board[2, 2] = CellTypes.O;


            //when
            bool result = winnerchecker.CheckRows(board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckColumnGiveTrueForFirst()
        {

            //given
            board.board[0, 0] = (CellTypes.O);
            board.board[1, 0] = CellTypes.O;
            board.board[2, 0] = CellTypes.O;


            //when
            bool result = winnerchecker.CheckColumns(board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckColumnGiveTrueForSecond()
        {

            //given
            board.board[0, 1] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[2, 1] = CellTypes.O;


            //when
            bool result = winnerchecker.CheckColumns(board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckColumnGiveTrueForThird()
        {

            //given
            board.board[0, 2] = (CellTypes.O);
            board.board[1, 2] = CellTypes.O;
            board.board[2, 2] = CellTypes.O;


            //when
            bool result = winnerchecker.CheckColumns(board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsChecFirstCrossGiveTrue()
        {

            //given
            board.board[0, 0] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[2, 2] = CellTypes.O;


            //when
            bool result = winnerchecker.CheckFirstCross(board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsChecSecondCrossGiveTrue()
        {

            //given
            board.board[0, 2] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[2, 0] = CellTypes.O;


            //when
            bool result = winnerchecker.CheckSecondCross(board);

            //then
            Assert.IsTrue(result);
        }


    }
}
