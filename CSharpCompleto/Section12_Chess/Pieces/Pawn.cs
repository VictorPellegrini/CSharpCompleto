using Section12_Chess.GameBoard;
using System;

namespace Section12_Chess.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Board board, Color color) : base(board, color)
        {
        }

        public override bool[,] PossibleMovements()
        {
            throw new NotImplementedException();
        }
    }
}
