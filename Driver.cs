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

    static void getPlayerAChoice(str[] board) {
        Game game = new Game(board);
        game.printBoard();
        Console.WriteLine("Player A, enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        board[choice - 1] = "X";
    }
    static void getPlayerBChoice(string[] board) {
        Game game = new Game(board);
        game.printBoard();
        Console.WriteLine("Player B, enter your choice: ");
        int choice = int.Parse(Console.ReadLinge());
        board[choice - 1] = "O";
    }

    static bool checkForWin(string[] board) {
        Game game = new Game(board);
        if game.checkForWin() != "" {
            Console.WriteLine(game.checkForWin());
            return true;
        }
        return false;
}