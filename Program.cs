using System;

namespace M4Assignment
{
    class Driver
    {
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Game!");
        }

        static void Main(string[] args)
        {
            WelcomeMessage();
            string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            while (true)
            {
                GetPlayerXChoice(board);
                if (CheckForWin(board))
                {
                    break;
                }

                GetPlayerOChoice(board);
                if (CheckForWin(board))
                {
                    break;
                }
            }

            Console.WriteLine("Game over!");
        }

        static void GetPlayerXChoice(string[] board)
        {
            Console.WriteLine(Game.PrintBoard(board));
            Console.WriteLine("Player X, enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            board[choice - 1] = "X";
        }

        static void GetPlayerOChoice(string[] board)
        {
            Console.WriteLine(Game.PrintBoard(board));
            Console.WriteLine("Player O, enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            board[choice - 1] = "O";
        }

        static bool CheckForWin(string[] board)
        {
            string winner = Game.CheckWinner(board);
            if (!string.IsNullOrEmpty(winner))
            {
                Console.WriteLine("The winner is Player " + winner);
                return true;
            }

            return false;
        }
    }
}









