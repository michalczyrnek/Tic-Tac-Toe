using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.End_Game_Conditions;
using Tic_Tac_Toe.Game_Engine;

namespace Tic_Tac_Toe.End_Game
{
    public static class EndGameCheckerFactory
    {
        public static EndGameChecker CreateStandardGameWinConditions()
        {
            EndGameChecker checker = new EndGameChecker();
            checker.AddEndGameCondition(new CheckRows());
            checker.AddEndGameCondition(new CheckColumns());
            checker.AddEndGameCondition(new CheckFirstDiagonally());
            checker.AddEndGameCondition(new CheckSecondDiagonally());

            return checker;


        }

        public static EndGameChecker CreateNoOneWinEnding()
        {
            EndGameChecker checker = new EndGameChecker();
            checker.AddEndGameCondition(new CheckIsBoardFull());
            return checker;

        }


    }
}
