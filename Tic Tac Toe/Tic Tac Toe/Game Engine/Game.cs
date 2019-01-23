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
           

            bool Winner = false;
            
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

                
                do
                {
                    Console.WriteLine("Player Two turn");
                    Console.WriteLine();
                    playerTwoTurn = new PlayerTurn().Turn(playground, "X");
                  
                } while (playerTwoTurn == false);

               



            } while (Winner == false);
        }

    }
}
