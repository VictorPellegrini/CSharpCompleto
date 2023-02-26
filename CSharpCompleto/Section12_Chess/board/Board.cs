namespace Section12_Chess.board
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
    }
}
