using System;
using Tic_Tac_Toe.End_Game_Conditions;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.Game_Engine
{
    public class WinnerChecker
    {
       

        public bool IsWinner(CellTypes[,] board)
        {
          
            if (FindWinner(new CheckRows(), board))
            {
                return true;
            }
            if (FindWinner(new CheckColumns(), board))
            {
                return true;
            }
            if (FindWinner(new CheckFirstDiagonally(),board))
            {
                return true;
            }
            if (FindWinner(new CheckSecondDiagonally(), board))
            {
                return true;
            }
            return false;

        }


        public bool FindWinner(IGameEndChecker checker, CellTypes[,] board)
        {
            if (checker.CheckCellStatus(board))
            {
                return true;

            }
            else
                return false;
        }
    }
}