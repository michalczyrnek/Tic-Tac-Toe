using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.Game_Engine
{
    class Game
    {

        public void PlayGame()
        {
            Board playground = new Board();
            playground.DrawBoard();

            bool Winner = false;
            
            do
            {
                bool playerOneTurn = false;
                bool playerTwoTurn = false;

                Console.WriteLine("Player One turn");
                do
                {
                    playerOneTurn = new PlayerTurn().Turn(playground.board, "O");
                } while (playerOneTurn == false);

                Console.WriteLine("Player Two turn");
                do
                {
                    playerOneTurn = new PlayerTurn().Turn(playground.board, "X");
                } while (playerTwoTurn == false);





            } while (Winner == false);
        }

    }
}
