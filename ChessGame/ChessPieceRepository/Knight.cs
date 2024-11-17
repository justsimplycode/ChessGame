using ChessGame.Model;
using ChessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.ChessPieceRepository
{
    public class Knight : Piece
    {
        public Knight(Color color, Position position) : base(color, position) { }

        public override bool IsValidMove(Position target, Board board)
        {
            int rowDiff = Math.Abs(Position.Row - target.Row);
            int colDiff = Math.Abs(Position.Col - target.Col);

            // Knights move in an "L" shape: 2 squares in one direction, 1 square in the other
            return (rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2);
        }
    }
}
