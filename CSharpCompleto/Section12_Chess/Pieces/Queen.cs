using Section12_Chess.GameBoard;

namespace Section12_Chess.Pieces
{
    public class Queen : Piece
    {
        public Queen(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
