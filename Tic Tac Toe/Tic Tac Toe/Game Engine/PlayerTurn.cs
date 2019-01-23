using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.Game_Engine
{
    public class PlayerTurn
    {

        public bool Turn (Board board, string symbol)
        {
            board.DrawBoard();
            Console.WriteLine();
            bool coordinatesCorrectness = false;
            Console.WriteLine("Give me coordinates (1-3 for row and 1-3 for column, for example 1,1)");
            string coordinates = Console.ReadLine();
            coordinatesCorrectness = MakeMove(board.board, coordinates, symbol);
            Console.Clear();
            return coordinatesCorrectness;
        }

        public bool MakeMove(CellTypes[,] board, string input ,string symbol)
        {
           
            string[] temp = input.Split(',');
            if( new CheckCoordinates().Check(temp,board))
            {

                int coordOne = Int32.Parse(temp[0])-1;
                int coordTwo = Int32.Parse(temp[1])-1;

                if (symbol == "X")
                {
                    board[coordOne, coordTwo] = CellTypes.X;
                }
                else
                {
                    board[coordOne, coordTwo] = CellTypes.O;
                }

               return  true;


            }

            else
            {
                Console.WriteLine("Wrong coordinates");
                Console.ReadKey();
                return false;
            }
            

        }

        
    }
}
