
using NUnit.Framework;
using Tic_Tac_Toe.End_Game_Conditions;
using Tic_Tac_Toe.Game_Engine;
using Tic_Tac_Toe.Tools;

namespace TicTacToeTests
{
    public class EndGameCheckerTest
    {
        private Board board;
        private EndGameChecker endGameChecker;

        [SetUp]
        public void Setup()
        {
            board = new Board();
            endGameChecker = new EndGameChecker();

        }

        [Test]
        public void IsCheckRowsGiveTrueForFirstRow()
        {

            //given
            board.board[0, 0] = (CellTypes.O);
            board.board[0, 1] = CellTypes.O;
            board.board[0, 2] = CellTypes.O;
            endGameChecker.AddEndGameCondition(new CheckRows());


            //when
            bool result = endGameChecker.IsGameEnd(board.board);

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
            endGameChecker.AddEndGameCondition(new CheckRows());


            //when
            bool result = endGameChecker.IsGameEnd(board.board);
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
            endGameChecker.AddEndGameCondition(new CheckRows());


            //when
            bool result = endGameChecker.IsGameEnd(board.board);

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
            endGameChecker.AddEndGameCondition(new CheckColumns());


            //when
            bool result = endGameChecker.IsGameEnd(board.board);

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
            endGameChecker.AddEndGameCondition(new CheckColumns());

            //when
            bool result = endGameChecker.IsGameEnd(board.board);

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
            endGameChecker.AddEndGameCondition(new CheckColumns());

            //when
            bool result = endGameChecker.IsGameEnd(board.board);


            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckFirstDiagonallyGiveTrue()
        {

            //given
            board.board[0, 0] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[2, 2] = CellTypes.O;
            endGameChecker.AddEndGameCondition(new CheckFirstDiagonally());

            //when
            bool result = endGameChecker.IsGameEnd(board.board);


            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCheckSecondDiagonallyGiveTrue()
        {

            //given
            board.board[0, 2] = (CellTypes.O);
            board.board[1, 1] = CellTypes.O;
            board.board[2, 0] = CellTypes.O;
            endGameChecker.AddEndGameCondition(new CheckSecondDiagonally());

            //when
            bool result = endGameChecker.IsGameEnd(board.board);



            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void BoardFull()
        {
            //given
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.board[i, j] = CellTypes.O;

                }

            }

            endGameChecker.AddEndGameCondition(new CheckIsBoardFull());

            //when
            bool result = endGameChecker.IsGameEnd(board.board);

            //then
            Assert.IsTrue(result);

        }

        [Test]
        public void BoardHasFreeCells()
        {



            endGameChecker.AddEndGameCondition(new CheckIsBoardFull());

            //when
            bool result = endGameChecker.IsGameEnd(board.board);

            //then
            Assert.IsFalse(result);


        }
    }
}
