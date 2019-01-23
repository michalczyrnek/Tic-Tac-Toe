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
        public void CorrectCoordinates()
        {
            //given
            string[] input = new string[] { "1", "1" };

            //when
            bool result = new CheckCoordinates().Check(input);

            //then
            Assert.IsTrue(result);
        }

        [Test]
        public void WrongFirstNumber()
        {
            //given
            string[] input = new string[] { "4", "1" };

            //when
            bool result = new CheckCoordinates().Check(input);

            //then
            Assert.IsFalse(result);
        }

        [Test]
        public void WrongOneNumber()
        {
            //given
            string[] input = new string[] { "1", "4" };

            //when
            bool result = new CheckCoordinates().Check(input);

            //then
            Assert.IsFalse(result);
        }

        [Test]
        public void DiffrentCharsInInput()
        {
            //given
            string[] input = new string[] { "1snnkhskd", "#@$$" };

            //when
            bool result = new CheckCoordinates().Check(input);

            //then
            Assert.IsFalse(result);
        }


    }
}