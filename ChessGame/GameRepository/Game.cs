using ChessGame.ChessPieceRepository;
using ChessGame.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.GameRepository
{
    public class Game : IGame
    {
        private Board board;
        private Player player1;
        private Player player2;
        private Player currentPlayer;

        public Game()
        {
            board = new Board();
            player1 = new Player(Color.White);
            player2 = new Player(Color.Black);
            currentPlayer = player1;

            InitializePieces();
        }

        private void InitializePieces()
        {
            // Initialize pawns
            for (int col = 0; col < 8; col++)
            {
                board.PlacePiece(new Pawn(Color.White, new Position(1, col)), new Position(1, col));
                board.PlacePiece(new Pawn(Color.Black, new Position(6, col)), new Position(6, col));
            }

            // Initialize rooks
            board.PlacePiece(new Rook(Color.White, new Position(0, 0)), new Position(0, 0));
            board.PlacePiece(new Rook(Color.White, new Position(0, 7)), new Position(0, 7));
            board.PlacePiece(new Rook(Color.Black, new Position(7, 0)), new Position(7, 0));
            board.PlacePiece(new Rook(Color.Black, new Position(7, 7)), new Position(7, 7));

            // Initialize knights
            board.PlacePiece(new Knight(Color.White, new Position(0, 1)), new Position(0, 1));
            board.PlacePiece(new Knight(Color.White, new Position(0, 6)), new Position(0, 6));
            board.PlacePiece(new Knight(Color.Black, new Position(7, 1)), new Position(7, 1));
            board.PlacePiece(new Knight(Color.Black, new Position(7, 6)), new Position(7, 6));

            // Initialize bishops
            board.PlacePiece(new Bishop(Color.White, new Position(0, 2)), new Position(0, 2));
            board.PlacePiece(new Bishop(Color.White, new Position(0, 5)), new Position(0, 5));
            board.PlacePiece(new Bishop(Color.Black, new Position(7, 2)), new Position(7, 2));
            board.PlacePiece(new Bishop(Color.Black, new Position(7, 5)), new Position(7, 5));

            // Initialize queens
            board.PlacePiece(new Queen(Color.White, new Position(0, 3)), new Position(0, 3));
            board.PlacePiece(new Queen(Color.Black, new Position(7, 3)), new Position(7, 3));

            // Initialize kings
            board.PlacePiece(new King(Color.White, new Position(0, 4)), new Position(0, 4));
            board.PlacePiece(new King(Color.Black, new Position(7, 4)), new Position(7, 4));
        }


        public void Start()
        {
            Console.WriteLine("Starting the game...");
            while (true)
            {
                board.DisplayBoard();
                Console.WriteLine($"{currentPlayer.Color}'s turn.");

                Console.Write("Enter source position (row col): ");
                var source = ParsePosition(Console.ReadLine());

                Console.Write("Enter target position (row col): ");
                var target = ParsePosition(Console.ReadLine());

                Move move = new Move(source, target, board);
                if (move.Execute(board))
                    SwitchTurn();
                else
                    Console.WriteLine("Move failed.");
            }
        }

        private Position ParsePosition(string input)
        {
            var parts = input.Split(' ');
            return new Position(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        private void SwitchTurn()
        {
            currentPlayer = currentPlayer == player1 ? player2 : player1;
        }
    }
}
