using System;
using Tic_Tac_Toe.Game_Engine;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PlayGame();
            Console.ReadKey();
        }
    }
}
