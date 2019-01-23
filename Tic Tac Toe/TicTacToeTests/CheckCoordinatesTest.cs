using NUnit.Framework;
using Tic_Tac_Toe.Tools;

namespace TicTacToeTests
{
    public class CheckCoordinatesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectCoordinatesFormal()
        {
            //given
            string[] input = new string[] { "1", "1" };

            //when
            bool result = new CheckCoordinates().FormalCorrectness(input);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void WrongFirstNumber()
        {
            //given
            string[] input = new string[] { "4", "1" };

            //when
            bool result = new CheckCoordinates().FormalCorrectness(input);
            //then
            Assert.IsFalse(result);
        }

        [Test]
        public void WrongOneNumber()
        {
            //given
            string[] input = new string[] { "1", "4" };

            //when
            bool result = new CheckCoordinates().FormalCorrectness(input);

            //then
            Assert.IsFalse(result);
        }

        [Test]
        public void DiffrentCharsInInput()
        {
            //given
            string[] input = new string[] { "1snnkhskd", "#@$$" };

            //when
            bool result = new CheckCoordinates().FormalCorrectness(input);

            //then
            Assert.IsFalse(result);
        }

        [Test]
        public void CellIsFreeAndNumbercorrect()
        {
            //given
            string[] input = new string[] { "1", "1" };
            Board board = new Board();
            board.board[0, 0] = CellTypes.Empty;

            //when
            bool result = new CheckCoordinates().Check(input, board.board);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void CellIsoccupiedAndNumbercorrect()
        {
            //given
            string[] input = new string[] { "1", "1" };
            Board board = new Board();
            board.board[0, 0] = CellTypes.X;

            //when
            bool result = new CheckCoordinates().Check(input, board.board);

            //then
            Assert.IsFalse(result);
        }




    }
}