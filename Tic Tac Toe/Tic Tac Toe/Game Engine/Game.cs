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
            WinnerChecker iswinner = new WinnerChecker();

            
            
            do
            {
                bool playerOneTurn = false;
                bool playerTwoTurn = false;

                
                
                do
                {
                    Console.WriteLine("Player One turn");
                    Console.WriteLine();
                    playerOneTurn = new PlayerTurn().Turn(playground, "O");
                   
                } while (playerOneTurn == false);

                if (iswinner.IsWinner(playground))
                {
                    Console.WriteLine("Player One Win");
                    playground.DrawBoard();
                    break;
                }

                
                do
                {
                    Console.WriteLine("Player Two turn");
                    Console.WriteLine();
                    playerTwoTurn = new PlayerTurn().Turn(playground, "X");
                  
                } while (playerTwoTurn == false);

                if (iswinner.IsWinner(playground))
                {
                    Console.WriteLine("Player Two Win");
                    playground.DrawBoard();
                    break;
                }



            } while (true);
        }

    }
}
