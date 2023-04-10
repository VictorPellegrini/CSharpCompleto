using Section12_Chess.ChessGame;
using Section12_Chess.GameBoard;
using Section12_Chess.Pieces;
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

                Screen.PrintBoard(chessMatch.Board);
            }
            catch (BoardExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
