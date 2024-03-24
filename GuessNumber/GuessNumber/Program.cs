using GuessNumber;
using GuessNumber.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        IGameSettings gameSettings = new GameSettings();
        IGame game = new Game(gameSettings);
        game.PlayGame();
    }
}