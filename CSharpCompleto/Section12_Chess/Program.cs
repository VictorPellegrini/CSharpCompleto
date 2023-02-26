using Section12_Chess.GameBoard;
using Section12_Chess.Pieces;
using System;

namespace Section12_Chess
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Guys!\n");

            try
            {
                var board = new Board(8, 8);

                board.PutPiece(new King(board, Color.black), new Position(0, 4));
                board.PutPiece(new Queen(board, Color.black), new Position(0, 3));

                Screen.PrintBoard(board);
            }
            catch (BoardExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
