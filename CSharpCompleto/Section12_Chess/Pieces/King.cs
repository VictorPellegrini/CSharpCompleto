using Section12_Chess.GameBoard;

namespace Section12_Chess.Pieces
{
    public class King : Piece
    {
        public King(Board board, Color color) : base(board, color)
        {
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position position = new Position(0, 0);

            //N
            position.SetValues(Position.Row - 1, Position.Column);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //NE
            position.SetValues(Position.Row - 1, Position.Column + 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //E
            position.SetValues(Position.Row, Position.Column + 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //SE
            position.SetValues(Position.Row + 1, Position.Column + 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //S
            position.SetValues(Position.Row + 1, Position.Column);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //SW
            position.SetValues(Position.Row + 1, Position.Column - 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //W
            position.SetValues(Position.Row, Position.Column - 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //NW
            position.SetValues(Position.Row - 1, Position.Column - 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            return matrix;
        }

        public override string ToString()
        {
            return "K";
        }

        private bool canMoveOn(Position position)
        {
            Piece piece = Board.GetPiece(position);
            return piece == null || piece.Color != this.Color;
        }
    }
}
