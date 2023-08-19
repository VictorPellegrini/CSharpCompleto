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
            Console.ReadLine();

            try
            {
                ChessMatch chessMatch = new ChessMatch();

                while (!chessMatch.Finished)
                {
                    try
                    {
                        Console.Clear();
                        Screen.PrintChessMatch(chessMatch);
                        
                        Position origin = Screen.ReadPosition().ToPosition();

                        chessMatch.ValidateOriginPosition(origin);

                        bool[,] possibleMovements = chessMatch.Board.GetPiece(origin).PossibleMovements();

                        Console.Clear();
                        Screen.PrintBoard(chessMatch.Board, possibleMovements);

                        Console.Write("\nInsert the destination position of this piece (column and line): ");
                        Position destiny = Screen.ReadPosition().ToPosition();

                        chessMatch.ValidateDestinyPosition(origin, destiny);

                        chessMatch.PerformsTheMove(origin, destiny);
                    }
                    catch (BoardExceptions ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (BoardExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
