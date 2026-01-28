using M4Assignment;

class Driver
{
    static void welcomeMessage()
    {
        Console.WriteLine("Welcome to the Tic Tac Toe Game!");
    }
    static void Main(string[] args)
    {
        int[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    }

    static void getPlayerAChoice(int[] board) {
        Console.WriteLine("Player A, enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        board[choice - 1] = "X";
    }

    static void getPlayerBChoice(int[] board) {
        Console.WriteLine("Player B, enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        board[choice - 1] = "O";
    }

    static void checkForWin(int[] board) {

    Game game = new Game(board);




}