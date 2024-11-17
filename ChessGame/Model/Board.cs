using ChessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    public class Board
    {
        private IPiece[,] grid = new IPiece[8, 8];

        public void PlacePiece(IPiece piece, Position position)
        {
            grid[position.Row, position.Col] = piece;
            piece.Position = position;
        }

        public void RemovePiece(Position position)
        {
            grid[position.Row, position.Col] = null;
        }

        public IPiece GetPieceAt(Position position)
        {
            return grid[position.Row, position.Col];
        }

        public void DisplayBoard()
        {
            Console.WriteLine("Displaying board...");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (grid[row, col] == null)
                        Console.Write(". ");
                    else
                        Console.Write(grid[row, col].GetType().Name[0] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
