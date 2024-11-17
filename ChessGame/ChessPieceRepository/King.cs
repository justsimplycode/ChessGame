using ChessGame.Model;
using ChessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ChessPieceRepository
{
    public class King : Piece
    {
        public King(Color color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position target, Board board)
        {
            // Kings move one square in any direction (horizontal, vertical, diagonal)
            int rowDiff = Math.Abs(Position.Row - target.Row);
            int colDiff = Math.Abs(Position.Col - target.Col);

            return rowDiff <= 1 && colDiff <= 1;
        }

        public void Castling() => Console.WriteLine("Castle.");
    }
}
