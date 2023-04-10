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

                    Console.Write("\nInsert the position of the piece to move: ");
                    Position PiecePositionToMove = Screen.ReadPosition().ToPosition();

                    Console.Write("\nInsert the destination position of this piece: ");
                    Position DestinationPosition = Screen.ReadPosition().ToPosition();

                    chessMatch.movePiece(PiecePositionToMove, DestinationPosition);
                }
            }
            catch (BoardExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
