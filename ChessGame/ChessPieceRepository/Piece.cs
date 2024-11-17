using ChessGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Repository
{
    public abstract class Piece : IPiece
    {
        public Color Color {  get; set; }
        public Position Position {  get; set; }


        protected Piece(Color color, Position position)
        {
            Color = color;
            Position = position;
        }


        public abstract bool IsValidMove(Position target, Board board);

        public virtual void MakeMove(Position target)
        {
            Position = target;
        }
    }
}
