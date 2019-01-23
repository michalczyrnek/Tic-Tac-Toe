using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe.Tools
{
    public class CheckCoordinates
    {
         public bool Check(string[] temp, CellTypes[,] board)
        {
            if (FormalCorrectness(temp) && IsCellFree(temp,board))
            {
                return true;
            }
            else return false;


        }

        public bool FormalCorrectness (string[] temp)
        {
           

            if (temp[0] == "1" || temp[0] == "2" || temp[0] == "3")
            {
                if (temp[1] == "1" || temp[1] == "2" || temp[1] == "3")
                {
                    return true;
                }

            }
            return false;

        }

        public bool IsCellFree (string[] temp, CellTypes[,] board)
        {
            int coordOne = Int32.Parse(temp[0]) - 1;
            int coordTwo = Int32.Parse(temp[1]) - 1;

            if (board[coordOne, coordTwo] == CellTypes.Empty)
            {
                return true;
            }

            else return false;
        }

    }
}
