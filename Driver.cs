using M4Assignment;

class Driver
{
    static void welcomeMessage()
    {
        Console.WriteLine("Welcome to the Tic Tac Toe Game!");
    }
    static void Main(string[] args)
    {
        string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    }

    static void getPlayerXChoice(string[] board) {
        Game.printBoard(board);
        Console.WriteLine("Player X, enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        board[choice - 1] = "X";
    }
    static void getPlayerOChoice(string[] board) {
        Game.PrintBoard(board);
        Console.WriteLine("Player O, enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        board[choice - 1] = "O";
    }

    static bool checkForWin(string[] board) {

        if (Game.checkForWin(board) != "") {
            Console.WriteLine("The winner is Player " + game.checkForWin());
            return true;
        }
        return false;
    }

}   
