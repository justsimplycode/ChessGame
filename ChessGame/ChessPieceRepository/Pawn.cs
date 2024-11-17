using ChessGame.Model;
using ChessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ChessPieceRepository
{
    public class Pawn : Piece
    {
        public Pawn(Color color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position target, Board board)
        {
            bool isWithinBound = target.IsWithinBounds();

            int direction = Color == Color.White ? 1 : -1;
            bool isValidMove = Position.Row + direction == target.Row && Position.Col == target.Col;

            return (isWithinBound && isValidMove);
        }

        public void DoubleMove() => Console.WriteLine("Double Move.");

        public void Promotion() => Console.WriteLine("Pawn promoted.");

        public void EnPassant() => Console.WriteLine("En Passant executed.");
    }
}
