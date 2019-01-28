using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.End_Game_Conditions
{
    public class CheckIsBoardFull : IGameEndCondition
    {
        public bool CheckCellsStatus(CellTypes[,] board)
        {
            foreach (var item in board)
            {
                if ( item == CellTypes.Empty)
                {
                    return false;
                }


            }
            return true;
        }
    }
}
