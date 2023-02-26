using Section12_Chess.GameBoard;

namespace Section12_Chess.Pieces
{
    public class King : Piece
    {
        public King(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
