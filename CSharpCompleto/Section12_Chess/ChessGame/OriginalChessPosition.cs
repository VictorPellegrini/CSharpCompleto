using Section12_Chess.GameBoard;

namespace Section12_Chess.ChessGame
{
    public class OriginalChessPosition
    {
        public int Row { get; set; }
        public char Column { get; set; }

        public OriginalChessPosition(char column, int row)
        {
            Column = column;
            Row = row;
        }

        public Position ToPosition()
        {
            return new Position(8 - Row, Column - 'a');
        }

        public override string ToString()
        {
            return "" + Column + Row;
        }
    }
}
