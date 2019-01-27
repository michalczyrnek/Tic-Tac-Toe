using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.End_Game_Conditions
{
    public class CheckFirstDiagonally : IGameEndChecker
    {

        public bool CheckCellStatus(CellTypes[,] board)
        {
            CellTypes match = board[0, 0];
            int counter = 0;
            if (!(match == CellTypes.Empty))
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, i] == match)
                    {
                        counter++;
                    }

                    else
                        break;
                }
            }
            if (counter == 3)
                return true;

            else return false;
        }
    }

}
