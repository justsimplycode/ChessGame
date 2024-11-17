using ChessGame.GameRepository;

namespace ChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGame game = new Game();
            game.Start();
        }
    }
}
