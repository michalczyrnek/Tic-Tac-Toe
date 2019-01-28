using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.End_Game_Conditions
{
    public class CheckSecondDiagonally : IGameEndCondition
    {
        public bool CheckCellsStatus(CellTypes[,] board)
        {
            CellTypes match = board[2, 0];
            int counter = 0;
            int j = 0;
            if (!(match == CellTypes.Empty))
            {
                for (int i = 2; i >= 0; i--)
                {


                    if (board[j, i] == match)
                    {
                        counter++;
                        j++;

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
