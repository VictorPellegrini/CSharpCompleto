using Section12_Chess.ChessGame;
using Section12_Chess.GameBoard;
using System;

namespace Section12_Chess
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Guys!\nLet's play chess :)\n");

            try
            {
                ChessMatch chessMatch = new ChessMatch();

                while (!chessMatch.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(chessMatch.Board);

                    Console.Write("\nInsert the position of the piece to move (column and line): ");
                    Position piecePositionToMove = Screen.ReadPosition().ToPosition();

                    bool[,] possibleMovements = chessMatch.Board.GetPiece(piecePositionToMove).PossibleMovements();

                    Console.Clear();
                    Screen.PrintBoard(chessMatch.Board, possibleMovements);

                    Console.Write("\nInsert the destination position of this piece (column and line): ");
                    Position destinationPosition = Screen.ReadPosition().ToPosition();

                    chessMatch.movePiece(piecePositionToMove, destinationPosition);
                }
            }
            catch (BoardExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
