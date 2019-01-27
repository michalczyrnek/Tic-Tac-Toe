using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.End_Game_Conditions
{
    public class CheckColumns : IGameEndChecker
    {
        public bool CheckCellStatus(CellTypes[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                int counter = 0;
                CellTypes match = board[0, i];

                if (!(match == CellTypes.Empty))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[j, i] == match)
                        {
                            counter++;
                            continue;
                        }
                        else
                            break;

                    }
                }

                if (counter == 3)
                    return true;

            }
            return false;
        }
    }
}
