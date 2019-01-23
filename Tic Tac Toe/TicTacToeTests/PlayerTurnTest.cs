using Moq;
using NUnit.Framework;
using Tic_Tac_Toe.Game_Engine;
using Tic_Tac_Toe.Tools;

namespace TicTacToeTests
{
   public class PlayerTurnTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChangeToX()
        {
            //given
            
            PlayerTurn pt = new PlayerTurn();
            string input =  "1,1" ;
            Board board = new Board();

            //when

            bool result = pt.MakeMove(board.board,input, "X");

            //then
            Assert.AreEqual(CellTypes.X, board.board[0, 0]);
            Assert.IsTrue(result);

        }

        [Test]
        public void ChangeToO()
        {
            //given

            PlayerTurn pt = new PlayerTurn();
            string input = "1,1";
            Board board = new Board();

            //when

            bool result = pt.MakeMove(board.board, input, "O");

            //then
            Assert.AreEqual(CellTypes.O, board.board[0, 0]);
            Assert.IsTrue(result);

        }

        [Test]
        public void FalseWhenWrongCoordinates()
        {
            //given

            PlayerTurn pt = new PlayerTurn();
            string input = "aaaa,1";
            Board board = new Board();

            //when

            bool result = pt.MakeMove(board.board, input, "O");

            //then
            
            Assert.IsFalse(result);

        }







    }
}
