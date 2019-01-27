
using Moq;
using NUnit.Framework;
using System.Reflection;
using Tic_Tac_Toe.End_Game_Conditions;
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
        public void IsCheckRowsGiveTrueForFirstRow()
        {

            //given
            board.board[0, 0] = (CellTypes.O);
            board.board[0, 1]= CellTypes.O;
            board.board[0, 2] = CellTypes.O;


            //when
            bool result = winnerchecker.FindWinner(new CheckRows(), board.board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckRowsGiveTrueForSecondRow()
        {

            //given
            board.board[1, 0] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[1, 2] = CellTypes.O;


            //when
            bool result = winnerchecker.FindWinner(new CheckRows(), board.board);

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
            bool result = winnerchecker.FindWinner(new CheckRows(), board.board);

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
            bool result = winnerchecker.FindWinner(new CheckColumns(), board.board);

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
            bool result = winnerchecker.FindWinner(new CheckColumns(), board.board);

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
            bool result = winnerchecker.FindWinner(new CheckColumns(), board.board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckFirstCrossGiveTrue()
        {

            //given
            board.board[0, 0] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[2, 2] = CellTypes.O;


            //when
            bool result = winnerchecker.FindWinner(new CheckFirstDiagonally(), board.board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckSecondCrossGiveTrue()
        {

            //given
            board.board[0, 2] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[2, 0] = CellTypes.O;


            //when
            bool result = winnerchecker.FindWinner(new CheckSecondDiagonally(), board.board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsFindWinnerReturnFalse()
        {

            //given
            Mock<IGameEndChecker> checker = new Mock<IGameEndChecker>();
            checker.Setup(i => i.CheckCellStatus(board.board)).Returns(false);

            //when
            bool result = winnerchecker.FindWinner(checker.Object, board.board);

            //then
            Assert.IsFalse(result);


        }
        [Test]
        public void IsWinnerTrue()
        {
            //given
            board.board[0, 2] = (CellTypes.O);
            board.board[1, 2] = CellTypes.O;
            board.board[2, 2] = CellTypes.O;

            //when
            bool result = winnerchecker.IsWinner(board.board);

            //then
            Assert.IsTrue(result);



        }
        public void IsWinnerFalse()
        {
          
            //when
            bool result = winnerchecker.IsWinner(board.board);

            //then
            Assert.IsFalse(result);



        }

    }
}
