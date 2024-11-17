using ChessGame.Model;
using ChessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ChessPieceRepository
{
    public class Rook : Piece
    {
        public Rook(Color color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position target, Board board)
        {
            bool isWithinBound = target.IsWithinBounds();
            bool isValidMove = Position.Row == target.Row || Position.Col == target.Col;

            return (isWithinBound && isValidMove);
        }

        public void Castling() => Console.WriteLine("Castle.");
    }
}
