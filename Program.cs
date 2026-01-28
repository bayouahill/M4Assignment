using namespace M4Assignment;

void main() {
    Driver.welcomeMessage();
    string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    while (!Driver.checkForWin(board)) {
        Driver.getPlayerXChoice(board);
        Driver.getPlayerOChoice(board);
    }
    Console.WriteLine("Game over!");
}