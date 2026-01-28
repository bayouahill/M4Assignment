using System;
using System.Collections.Generic;
using System.Text;

/* 
 * Receive the “board” array from the driver class 
 * Contain a method that prints the board based on the information passed to it 
 * Contain a method that receives the game board array as input and returns if there is a winner and who it was
*/

namespace M4Assignment
{
    internal class Game
    {

        public string PrintBoard(string[] board)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" " + board[0] + " | " + board[1] + " | " + board[2]);
            sb.AppendLine("---+---+---");
            sb.AppendLine(" " + board[3] + " | " + board[4] + " | " + board[5]);
            sb.AppendLine("---+---+---");
            sb.AppendLine(" " + board[6] + " | " + board[7] + " | " + board[8]);
            return sb.ToString();
        }

    }
}
