using System;
using System.Collections.Generic;
using System.Text;
using Tic_Tac_Toe.End_Game_Conditions;
using Tic_Tac_Toe.Game_Engine;

namespace Tic_Tac_Toe.End_Game
{
    public class EndGameCheckerFactory
    {
        public EndGameChecker CreateStandardGameWinConditions()
        {
            EndGameChecker checker = new EndGameChecker();
            checker.AddEndGameCondition(new CheckRows());
            checker.AddEndGameCondition(new CheckColumns());
            checker.AddEndGameCondition(new CheckFirstDiagonally());
            checker.AddEndGameCondition(new CheckSecondDiagonally());

            return checker;


        }

        public EndGameChecker CreateNoOneWinEnding()
        {
            EndGameChecker checker = new EndGameChecker();
            checker.AddEndGameCondition(new CheckIsBoardFull());
            return checker;

        }


    }
}
