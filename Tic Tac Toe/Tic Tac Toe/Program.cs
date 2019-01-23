using System;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.DrawBoard();
            Console.ReadKey();
        }
    }
}
