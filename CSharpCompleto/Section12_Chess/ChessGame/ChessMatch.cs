using Section12_Chess.GameBoard;
using Section12_Chess.Pieces;
using System.Collections.Generic;
using System.Linq;

namespace Section12_Chess.ChessGame
{
    public class ChessMatch
    {
        public Board Board { get; private set; }
        public Color CurrentPlayer { get; private set; }
        public int Round { get; private set; }
        public bool Finished { get; private set; }
        private HashSet<Piece> _pieces;
        private static HashSet<Piece> _capturedPieces;

        public ChessMatch()
        {
            Board = new Board(8, 8);
            Round = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            _pieces = new HashSet<Piece>();
            _capturedPieces = new HashSet<Piece>();
            PutPieces();
        }

        public void PerformsTheMove(Position origin, Position destinty)
        {
            MovePiece(origin, destinty);
            Round++;
            ChangePlayer();
        }

        public void ValidateOriginPosition(Position origin)
        {
            var selectedPiece = Board.GetPiece(origin);

            if (selectedPiece == null)
            {
                throw new BoardExceptions("You don't have a piece in that position.");
            }

            if (CurrentPlayer != selectedPiece.Color)
            {
                throw new BoardExceptions("This piece isn't yours");
            }

            if (!selectedPiece.CheckIfPieceIsBlocked())
            {
                throw new BoardExceptions("This piece can't move");
            }
        }

        public void ValidateDestinyPosition(Position origin, Position destiny)
        {
            var selectedPiece = Board.GetPiece(origin);

            if (!selectedPiece.PossibleMovements()[destiny.Row, destiny.Column])
            {
                throw new BoardExceptions("Invalid destiny position. Try again.");
            }
        }

        public void PutNewPiece(Piece piece, char column, int row)
        {
            Board.PutPiece(piece, new OriginalChessPosition(column, row).ToPosition());
            _pieces.Add(piece);
        }

        public IList<Piece> GetCapturedPieces(Color color)
            => _capturedPieces.Where(x => x.Color == color).ToList();

        private void MovePiece(Position origin, Position destiny)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.AddMoves();
            Piece capturedPiece = Board.RemovePiece(destiny);
            Board.PutPiece(piece, destiny);

            if (capturedPiece != null)
            {
                _capturedPieces.Add(capturedPiece);
            }
        }

        private void ChangePlayer()
        {
            if (CurrentPlayer == Color.White)
            {
                CurrentPlayer = Color.Black;
                return;
            }
            CurrentPlayer = Color.White;
        }

        private void PutPieces()
        {
            PutNewPiece(new Tower(Board, Color.Black), 'a', 8);
            PutNewPiece(new Tower(Board, Color.Black), 'h', 8);
            PutNewPiece(new Knight(Board, Color.Black),'b', 8);
            PutNewPiece(new Knight(Board, Color.Black),'g', 8);
            PutNewPiece(new Bishop(Board, Color.Black),'c', 8);
            PutNewPiece(new Bishop(Board, Color.Black),'f', 8);
            PutNewPiece(new Queen(Board, Color.Black), 'd', 8);
            PutNewPiece(new King(Board, Color.Black), 'e', 8);

            PutNewPiece(new Tower(Board, Color.White), 'a', 1);
            PutNewPiece(new Tower(Board, Color.White), 'h', 1);
            PutNewPiece(new Knight(Board, Color.White),'b', 1);
            PutNewPiece(new Knight(Board, Color.White),'g', 1);
            PutNewPiece(new Bishop(Board, Color.White),'c', 1);
            PutNewPiece(new Bishop(Board, Color.White),'f', 1);
            PutNewPiece(new Queen(Board, Color.White), 'e', 1);
            PutNewPiece(new King(Board, Color.White), 'd', 1);
        }
    }
}
