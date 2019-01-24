using System;
using Tic_Tac_Toe.Tools;

namespace Tic_Tac_Toe.Game_Engine
{
    public class WinnerChecker
    {
       

        public bool IsWinner(Board playground)
        {

            if (CheckRows(playground))
                return true;
            else if (CheckColumns(playground))
                return true;
            else if (CheckFirstCross(playground))
                return true;
            else if (CheckSecondCross(playground))
                return true;
            else
                return false;



        }

        public bool CheckSecondCross(Board playground)
        {
            CellTypes match = playground.board[2, 0];
            int counter = 0;
            int j = 0;
            if (!(match == CellTypes.Empty))
            {
                for (int i = 2; i >= 0; i--)
                {


                    if (playground.board[j, i] == match)
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

        public bool CheckFirstCross(Board playground)
        {
            CellTypes match = playground.board[0, 0];
            int counter = 0;
            if (!(match == CellTypes.Empty))
            {
                for (int i = 0; i < 3; i++)
                {
                    if (playground.board[i, i] == match)
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


        

        public bool CheckColumns(Board playground)
        {
            for (int i = 0; i < 3; i++)
            {
                int counter = 0;
                CellTypes match = playground.board[0, i];

                if (!(match == CellTypes.Empty))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (playground.board[j, i] == match)
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

        public bool CheckRows(Board playground)
        {

            for (int i = 0; i < 3; i++)
            {
                int counter = 0;
                CellTypes match = playground.board[i, 0];

                if (!(match == CellTypes.Empty))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (playground.board[i, j] == match)
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