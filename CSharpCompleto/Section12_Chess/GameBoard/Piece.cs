namespace Section12_Chess.GameBoard
{
    public class Piece
    {
        public Position position { get; set; }
        public Board board { get; protected set; }
        public Color color { get; protected set; }
        public int amountOfMoves { get; protected set; }

        public Piece(Board board, Color color)
        {
            this.position = null;
            this.board = board;
            this.color = color;
            amountOfMoves = 0;
        }
    }
}
