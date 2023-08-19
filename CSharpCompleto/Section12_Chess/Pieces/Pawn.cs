using Section12_Chess.GameBoard;

namespace Section12_Chess.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Board board, Color color) : base(board, color)
        {
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position destinyPosition = new Position(0, 0);

            if (Color == Color.White)
            {
                //N first movement
                destinyPosition.SetValues(Position.Row - 2, Position.Column);
                if (IsFirstMovementEnable(destinyPosition))
                {
                    matrix[destinyPosition.Row, destinyPosition.Column] = true;
                }

                //N
                destinyPosition.SetValues(Position.Row - 1, Position.Column);
                if (Board.ValidatePosition(destinyPosition) && IsFreePosition(destinyPosition))
                {
                    matrix[destinyPosition.Row, destinyPosition.Column] = true;
                }

                //NE
                destinyPosition.SetValues(Position.Row - 1, Position.Column + 1);
                if (Board.ValidatePosition(destinyPosition) && IsAnEnemy(destinyPosition))
                {
                    matrix[destinyPosition.Row, destinyPosition.Column] = true;
                }

                //NW
                destinyPosition.SetValues(Position.Row - 1, Position.Column - 1);
                if (Board.ValidatePosition(destinyPosition) && IsAnEnemy(destinyPosition))
                {
                    matrix[destinyPosition.Row, destinyPosition.Column] = true;
                }
            }
            else
            {
                //S first movement
                destinyPosition.SetValues(Position.Row + 2, Position.Column);
                if (IsFirstMovementEnable(destinyPosition))
                {
                    matrix[destinyPosition.Row, destinyPosition.Column] = true;
                }

                //S
                destinyPosition.SetValues(Position.Row + 1, Position.Column);
                if (Board.ValidatePosition(destinyPosition) && IsFreePosition(destinyPosition))
                {
                    matrix[destinyPosition.Row, destinyPosition.Column] = true;
                }

                //SE
                destinyPosition.SetValues(Position.Row + 1, Position.Column + 1);
                if (Board.ValidatePosition(destinyPosition) && IsAnEnemy(destinyPosition))
                {
                    matrix[destinyPosition.Row, destinyPosition.Column] = true;
                }

                //SW
                destinyPosition.SetValues(Position.Row + 1, Position.Column - 1);
                if (Board.ValidatePosition(destinyPosition) && IsAnEnemy(destinyPosition))
                {
                    matrix[destinyPosition.Row, destinyPosition.Column] = true;
                }
            }

            return matrix;
        }

        public override string ToString()
        {
            return "P";
        }

        private bool IsFirstMovementEnable(Position destinyPosition)
        {
            var shortDestinyPosition = new Position(0,0);

            if (Color == Color.White)
            {
                shortDestinyPosition.SetValues(destinyPosition.Row + 1, destinyPosition.Column);
            }
            else
            {
                shortDestinyPosition.SetValues(destinyPosition.Row - 1, destinyPosition.Column);
            }

            return AmountOfMoves == 0 && Board.ValidatePosition(destinyPosition) && IsFreePosition(destinyPosition) && IsFreePosition(shortDestinyPosition);
        }

        private bool IsAnEnemy(Position pos)
        {
            Piece piece = Board.GetPiece(pos);
            return piece != null && piece.Color != Color;
        }

        private bool IsFreePosition(Position pos)
        {
            return Board.GetPiece(pos) == null;
        }
    }
}
