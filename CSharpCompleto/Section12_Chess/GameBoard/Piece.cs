namespace Section12_Chess.GameBoard
{
    public abstract class Piece
    {
        public Position Position { get; set; }
        public Board Board { get; protected set; }
        public Color Color { get; protected set; }
        public int AmountOfMoves { get; protected set; }

        public Piece(Board board, Color color)
        {
            this.Position = null;
            this.Board = board;
            this.Color = color;
            AmountOfMoves = 0;
        }

        public void RemoveMovement()
        {
            AmountOfMoves--;
        }

        public void AddMovement()
        {
            AmountOfMoves++;
        }

        public bool CheckIfPieceIsBlocked()
        {
            bool[,] mat = PossibleMovements();

            for (int i = 0; i < Board.Rows; i++)
            {
                for (int j = 0; j < Board.Columns; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ValidateDestinyPosition(Position destinyPosition)
        {
            return PossibleMovements()[destinyPosition.Row, destinyPosition.Column];
        }

        public abstract bool[,] PossibleMovements();

    }
}
