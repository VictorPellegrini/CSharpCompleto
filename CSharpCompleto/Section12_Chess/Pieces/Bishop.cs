using Section12_Chess.GameBoard;

namespace Section12_Chess.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
