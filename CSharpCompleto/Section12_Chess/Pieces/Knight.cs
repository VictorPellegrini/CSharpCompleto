using Section12_Chess.GameBoard;

namespace Section12_Chess.Pieces
{
    public class Knight : Piece
    {
        public Knight(Board board, Color color) : base(board, color)
        {
        }

        public override bool[,] PossibleMovements()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
