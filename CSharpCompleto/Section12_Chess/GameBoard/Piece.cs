namespace Section12_Chess.GameBoard
{
    public class Piece
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

        public void AddMoves()
        {
            AmountOfMoves++;
        }
    }
}
