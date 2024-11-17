using ChessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    public class Move
    {
        public Position Source { get; }
        public Position Target { get; }
        public IPiece MovingPiece { get; }
        public IPiece CapturedPiece { get; private set; }


        public Move(Position source, Position target, Board board)
        {
            Source = source;
            Target = target;
            MovingPiece = board.GetPieceAt(Source);
            CapturedPiece = board.GetPieceAt(Target);
        }

        public bool Execute(Board board)
        {
            if (MovingPiece == null)
            {
                Console.WriteLine("No piece at the source position.");
                return false;
            }

            if (!MovingPiece.IsValidMove(Target, board))
            {
                Console.WriteLine("Invalid move.");
                return false;
            }

            board.PlacePiece(MovingPiece, Target);
            board.RemovePiece(Source);

            if (CapturedPiece != null)
                Console.WriteLine($"{CapturedPiece.GetType().Name} captured!");

            //setting the position of the piece after moving
            MovingPiece.MakeMove(Target);
            return true;
        }
    }
}
