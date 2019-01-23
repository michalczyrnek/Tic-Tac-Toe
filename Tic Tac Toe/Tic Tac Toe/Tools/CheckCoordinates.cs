using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe.Tools
{
    public class CheckCoordinates
    {
         public bool Check(string[] temp)
        {
            bool result = false;

            if (temp[0]=="1"|| temp[0] == "2" || temp[0] == "3")
            {
                if (temp[1] == "1" || temp[1] == "2" || temp[1] == "3")
                {
                     result = true;
                }

            }
            return result;

        }
    }
}
