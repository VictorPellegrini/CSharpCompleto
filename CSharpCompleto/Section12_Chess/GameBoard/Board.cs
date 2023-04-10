namespace Section12_Chess.GameBoard
{
    public class Board
    {
        private Piece[,] Pieces;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Board(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            Pieces = new Piece[rows, columns];
        }

        public Piece GetPiece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece GetPiece(Position position)
        {
            return Pieces[position.Row, position.Column];
        }

        public void PutPiece(Piece piece, Position position)
        {
            if (CheckIfPositionHasPiece(position))
            {
                throw new BoardExceptions("A piece already exists in this position");
            }

            Pieces[position.Row, position.Column] = piece;
            piece.Position = position;
        }

        public Piece RemovePiece(Position position)
        {
            if (GetPiece(position) == null)
            {
                return null;
            }            

            Piece pieceToRemove =  GetPiece(position);
            pieceToRemove.Position = null;
            Pieces[position.Row, position.Column] = null;

            return pieceToRemove;
        }

        public bool PositionValidate(Position position)
        {
            if (position.Row < 0 || position.Column < 0 || position.Row > Rows || position.Column > Columns)
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
