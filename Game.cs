using System;
using System.Collections.Generic;
using System.Text;

/* 
 * Receive the “board” array from the driver class 
 * Contain a method that prints the board based on the information passed to it 
 * Contain a method that receives the game board array as input and returns if there is a winner and who it was
*/

using M4Assignment;

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

        public string CheckWinner(string[] board)
        {

            int[][] winLines =
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 }
            };

            foreach (int[] line in winLines)
            {
                string a = board[line[0]];
                string b = board[line[1]];
                string c = board[line[2]];
                if (a == "X" || a == "O" && a == b && b == c)
                {
                    return a;
                }
            }

            return "";
        }
    }
