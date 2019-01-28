using System;
using System.Collections.Generic;
using Tic_Tac_Toe.End_Game_Conditions;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.Game_Engine
{
    public class EndGameChecker
    {
        private List<IGameEndCondition> EndGameConditions = new List<IGameEndCondition>();

        public bool IsGameEnd(CellTypes[,] board)
        {
          
           foreach (var item in EndGameConditions)
            {

                if (item.CheckCellsStatus(board))
                {
                    return true;
                }
               
            }
            return false;

        }


        public void AddEndGameCondition(IGameEndCondition checker)
        {
            EndGameConditions.Add(checker);
        }
    }
}