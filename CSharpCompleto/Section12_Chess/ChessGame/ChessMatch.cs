using Section12_Chess.GameBoard;
using Section12_Chess.Pieces;

namespace Section12_Chess.ChessGame
{
    public class ChessMatch
    {
        public Board Board { get; private set; }
        private int Round;
        private Color CurrentPlayer;
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            Round = 1;
            CurrentPlayer = Color.white;
            Finished = false;
            PutPieces();
        }

        public void movePiece(Position currentPosition, Position nextPosition)
        {
            Piece piece = Board.RemovePiece(currentPosition);
            piece.AddMoves();
            Piece capturedPiece = Board.RemovePiece(nextPosition);
            Board.PutPiece(piece, nextPosition);
        }

        private void PutPieces()
        {
            Board.PutPiece(new Tower(Board, Color.black), new OriginalChessPosition('a', 8).ToPosition());
            Board.PutPiece(new Tower(Board, Color.black), new OriginalChessPosition('h', 8).ToPosition());
            Board.PutPiece(new Knight(Board, Color.black), new OriginalChessPosition('b', 8).ToPosition());
            Board.PutPiece(new Knight(Board, Color.black), new OriginalChessPosition('g', 8).ToPosition());
            Board.PutPiece(new Bishop(Board, Color.black), new OriginalChessPosition('c', 8).ToPosition());
            Board.PutPiece(new Bishop(Board, Color.black), new OriginalChessPosition('f', 8).ToPosition());
            Board.PutPiece(new Queen(Board, Color.black), new OriginalChessPosition('d', 8).ToPosition());
            Board.PutPiece(new King(Board, Color.black), new OriginalChessPosition('e', 8).ToPosition());

            Board.PutPiece(new Tower(Board, Color.white), new OriginalChessPosition('a', 1).ToPosition());
            Board.PutPiece(new Tower(Board, Color.white), new OriginalChessPosition('h', 1).ToPosition());
            Board.PutPiece(new Knight(Board, Color.white), new OriginalChessPosition('b', 1).ToPosition());
            Board.PutPiece(new Knight(Board, Color.white), new OriginalChessPosition('g', 1).ToPosition());
            Board.PutPiece(new Bishop(Board, Color.white), new OriginalChessPosition('c', 1).ToPosition());
            Board.PutPiece(new Bishop(Board, Color.white), new OriginalChessPosition('f', 1).ToPosition());
            Board.PutPiece(new Queen(Board, Color.white), new OriginalChessPosition('e', 1).ToPosition());
            Board.PutPiece(new King(Board, Color.white), new OriginalChessPosition('d', 1).ToPosition());
        }
    }
}
