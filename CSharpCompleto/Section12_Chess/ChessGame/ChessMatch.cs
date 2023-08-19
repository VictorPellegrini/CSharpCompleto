using Section12_Chess.GameBoard;
using Section12_Chess.Pieces;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace Section12_Chess.ChessGame
{
    public class ChessMatch
    {
        public Board Board { get; private set; }
        public Color CurrentPlayer { get; private set; }
        public int Round { get; private set; }
        public bool Finished { get; private set; }
        public bool Check { get; private set; }
        private HashSet<Piece> _pieces;
        private static HashSet<Piece> _capturedPieces;

        public ChessMatch()
        {
            Board = new Board(8, 8);
            Round = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            Check = false;
            _pieces = new HashSet<Piece>();
            _capturedPieces = new HashSet<Piece>();
            PutPieces();
        }

        public void PerformsTheMove(Position origin, Position destiny)
        {
            Piece pecaCapturada = MovePiece(origin, destiny);

            if (IsKingInCheck(CurrentPlayer))
            {
                UndoTheMove(origin, destiny, pecaCapturada);
                throw new BoardExceptions("You can not put your King in check position!");
            }

            if (IsKingInCheck(GetAgainstPlayer(CurrentPlayer)))
            {
                Check = true;
            }
            else
            {
                Check = false;
            }

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
            => _capturedPieces.Where(piece => piece.Color == color).ToList();

        public IList<Piece> GetSurvivingPieces(Color color)
            => _pieces.Where(piece => piece.Color == color).ToList();

        public bool IsKingInCheck(Color color)
        {
            Piece king = GetKing(color);
            
            if (king == null)
            {
                throw new BoardExceptions("The King " + color + " is already dead!");
            }

            var enemyPieces = GetSurvivingPieces(GetAgainstPlayer(color));

            foreach (Piece piece in enemyPieces)
            {
                bool[,] possibleMovements = piece.PossibleMovements();
                if (possibleMovements[king.Position.Row, king.Position.Column])
                {
                    return true;
                }
            }
            return false;
        }

        private static Color GetAgainstPlayer(Color color)
            => color == Color.White ? Color.Black : Color.White;

        private Piece GetKing(Color color)
            => GetSurvivingPieces(color).First(piece => piece is King);

        private Piece MovePiece(Position origin, Position destiny)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.AddMovement();
            Piece capturedPiece = Board.RemovePiece(destiny);

            if (capturedPiece != null)
            {
                _capturedPieces.Add(capturedPiece);
                _pieces.Remove(capturedPiece);
            }

            Board.PutPiece(piece, destiny);

            return capturedPiece;
        }

        private void UndoTheMove(Position origin, Position destiny, Piece capturedPiece)
        {
            Piece currentPiece = Board.RemovePiece(destiny);
            currentPiece.RemoveMovement();
            if (capturedPiece != null)
            {
                Board.PutPiece(capturedPiece, destiny);
                _capturedPieces.Remove(capturedPiece);
                _pieces.Add(capturedPiece);
            }
            Board.PutPiece(currentPiece, origin);
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
            //PutNewPiece(new Knight(Board, Color.Black),'b', 8);
            //PutNewPiece(new Knight(Board, Color.Black),'g', 8);
            //PutNewPiece(new Bishop(Board, Color.Black),'c', 8);
            //PutNewPiece(new Bishop(Board, Color.Black),'f', 8);
            //PutNewPiece(new Queen(Board, Color.Black), 'd', 8);
            PutNewPiece(new King(Board, Color.Black), 'e', 8);

            PutNewPiece(new Tower(Board, Color.White), 'a', 1);
            PutNewPiece(new Tower(Board, Color.White), 'h', 1);
            //PutNewPiece(new Knight(Board, Color.White),'b', 1);
            //PutNewPiece(new Knight(Board, Color.White),'g', 1);
            //PutNewPiece(new Bishop(Board, Color.White),'c', 1);
            //PutNewPiece(new Bishop(Board, Color.White),'f', 1);
            //PutNewPiece(new Queen(Board, Color.White), 'e', 1);
            PutNewPiece(new King(Board, Color.White), 'd', 1);
        }
    }
}
