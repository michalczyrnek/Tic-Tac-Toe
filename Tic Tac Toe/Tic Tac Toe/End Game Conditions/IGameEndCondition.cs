using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.End_Game_Conditions
{
    public interface IGameEndCondition
    {

         bool CheckCellsStatus(CellTypes[,] board);

    }
}
