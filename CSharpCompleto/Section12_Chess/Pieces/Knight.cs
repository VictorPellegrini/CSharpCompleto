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
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position position = new Position(0, 0);

            //N Right
            position.SetValues(Position.Row - 2, Position.Column + 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //E Up
            position.SetValues(Position.Row - 1, Position.Column + 2);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //E Down 
            position.SetValues(Position.Row + 1, Position.Column + 2);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //S Right
            position.SetValues(Position.Row + 2, Position.Column + 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //S Left
            position.SetValues(Position.Row + 2, Position.Column - 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //W Down
            position.SetValues(Position.Row + 1, Position.Column - 2);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //W Up
            position.SetValues(Position.Row - 1, Position.Column - 2);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            //N Left
            position.SetValues(Position.Row - 2, Position.Column - 1);
            if (Board.ValidatePosition(position) && canMoveOn(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            return matrix;
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
