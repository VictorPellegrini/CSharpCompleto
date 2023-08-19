using Section12_Chess.GameBoard;

namespace Section12_Chess.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Board board, Color color) : base(board, color)
        {
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position pos = new(0, 0);

            //NE
            pos.SetValues(Position.Row - 1, Position.Column + 1);
            while (Board.ValidatePosition(pos) && canMoveOn(pos))
            {
                matrix[pos.Row, pos.Column] = true;

                if (Board.GetPiece(pos) != null && Board.GetPiece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(Position.Row - 1, Position.Column + 1);
            }

            //SE
            pos.SetValues(Position.Row + 1, Position.Column + 1);
            while (Board.ValidatePosition(pos) && canMoveOn(pos))
            {
                matrix[pos.Row, pos.Column] = true;

                if (Board.GetPiece(pos) != null && Board.GetPiece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(Position.Row + 1, Position.Column + 1);
            }

            //SW
            pos.SetValues(Position.Row + 1, Position.Column - 1);
            while (Board.ValidatePosition(pos) && canMoveOn(pos))
            {
                matrix[pos.Row, pos.Column] = true;

                if (Board.GetPiece(pos) != null && Board.GetPiece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(Position.Row + 1, Position.Column - 1);
            }

            //NW
            pos.SetValues(Position.Row - 1, Position.Column - 1);
            while (Board.ValidatePosition(pos) && canMoveOn(pos))
            {
                matrix[pos.Row, pos.Column] = true;

                if (Board.GetPiece(pos) != null && Board.GetPiece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Row - 1, pos.Column - 1);
            }

            return matrix;
        }

        public override string ToString()
        {
            return "B";
        }        
    }
}
