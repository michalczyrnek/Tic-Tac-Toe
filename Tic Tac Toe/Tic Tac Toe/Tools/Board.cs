using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe.Tools
{
    public class Board
    {

        public CellTypes[,] board = new CellTypes[3, 3]; 
        
        public Board()
        {

            for (int i = 0; i <3; i++)
            {
                for (int j=0; j < 3; j++)
                {
                    board[i, j] = CellTypes.Empty;
                }
            }
        }

        public void DrawBoard()
        {
            string cellstatus;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");

                for (int j = 0; j < 3; j++)
                {
                    cellstatus = DrawCellStatus(i, j);
                    Console.Write("[{0}]", cellstatus);
                }
                Console.Write(" |");
                Console.WriteLine();
            }


        }

        private string DrawCellStatus(int column, int row)
        {
            string result=" ";

            if (board[column, row] == CellTypes.Empty)
            {
                result = " ";
            }
            else if (board[column, row] == CellTypes.X)
            {
                result = "X";

            }
            else
            {
                result = "O";
            }


            return result;

        }


    }
}
