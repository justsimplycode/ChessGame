using ChessGame.Model;
using ChessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ChessPieceRepository
{
    public class Bishop : Piece
    {
        public Bishop(Color color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position target, Board board)
        {
            // Bishops move diagonally: the difference between rows and columns must be the same
            return Math.Abs(Position.Row - target.Row) == Math.Abs(Position.Col - target.Col);
        }
    }
}
