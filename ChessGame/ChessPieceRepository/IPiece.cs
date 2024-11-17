using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Model;

namespace ChessGame.Repository
{
    public interface IPiece
    {
        public Color Color { get; set; }
        public Position Position { get; set; }

        public bool IsValidMove(Position target, Board board);

        public void MakeMove(Position target);
    }
}
