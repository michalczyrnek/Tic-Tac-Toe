using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.Game_Engine
{
    public class PlayerTurn
    {
        public bool MakeMove(CellTypes[,] board, string input ,string symbol)
        {
            bool coordinatesCorrectness=false;

           
            string[] temp = input.Split(',');
            if( new CheckCoordinates().Check(temp))
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

                coordinatesCorrectness = true;


            }
            return coordinatesCorrectness;

        }
    }
}
