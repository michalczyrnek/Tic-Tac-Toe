using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.End_Game;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.Game_Engine
{
    class Game
    {

        public void PlayGame()
        {
            Board playground = new Board();
            EndGameChecker isWinner = new EndGameCheckerFactory().CreateStandardGameWinConditions();
            EndGameChecker isNoOneWins = new EndGameCheckerFactory().CreateNoOneWinEnding();

            
            
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

                if (isWinner.IsGameEnd(playground.board))
                {
                    Console.WriteLine("Player One Win");
                    playground.DrawBoard();
                    break;
                }

                if (isNoOneWins.IsGameEnd(playground.board))
                {
                    Console.WriteLine("No one wins");
                    playground.DrawBoard();
                    break;
                }

                
                do
                {
                    Console.WriteLine("Player Two turn");
                    Console.WriteLine();
                    playerTwoTurn = new PlayerTurn().Turn(playground, "X");
                  
                } while (playerTwoTurn == false);

                if (isWinner.IsGameEnd(playground.board))
                {
                    Console.WriteLine("Player Two Win");
                    playground.DrawBoard();
                    break;
                }



            } while (true);
        }

    }
}
