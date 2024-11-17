using ChessGame.Model;
using ChessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ChessPieceRepository
{
    public class Queen : Piece
    {
        public Queen(Color color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position target, Board board)
        {
            // Queens move horizontally, vertically, or diagonally
            return Position.Row == target.Row || Position.Col == target.Col ||
                   Math.Abs(Position.Row - target.Row) == Math.Abs(Position.Col - target.Col);
        }
    }
}
