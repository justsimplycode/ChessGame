using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Repository;

namespace ChessGame.Model
{
    public class Player
    {
        public Color Color { get; set; }

        public List<IPiece> Pieces { get; set; }

        public Player(Color color)
        {
            Color = color;
            Pieces = new List<IPiece>();
        }
    }

    public enum Color
    {
        White = 1,
        Black = 2
    }
}
