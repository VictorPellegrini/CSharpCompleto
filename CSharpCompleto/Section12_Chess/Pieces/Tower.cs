using Section12_Chess.GameBoard;

namespace Section12_Chess.Pieces
{
    public class Tower : Piece
    {
        public Tower(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
