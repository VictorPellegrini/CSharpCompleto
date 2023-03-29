namespace Section12_Chess.GameBoard
{
    public class Board
    {
        private Piece[,] pieces;
        public int lines { get; set; }
        public int columns { get; set; }

        public Board(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }

        public Piece GetPiece(int line, int column)
        {
            return pieces[line, column];
        }

        public Piece GetPiece(Position position)
        {
            return pieces[position.Row, position.Column];
        }

        public void PutPiece(Piece piece, Position position)
        {
            if (CheckIfPositionHasPiece(position))
            {
                throw new BoardExceptions("A piece already exists in this position");
            }

            pieces[position.Row, position.Column] = piece;
            piece.position = position;
        }

        public bool PositionValidate(Position position)
        {
            if (position.Row < 0 || position.Column < 0 || position.Row > lines || position.Column > columns)
            {
                throw new BoardExceptions("Invalid position");
            }
            return true;
        }

        public bool CheckIfPositionHasPiece(Position position)
        {
            PositionValidate(position);
            return GetPiece(position) != null;
        }
    }
}
