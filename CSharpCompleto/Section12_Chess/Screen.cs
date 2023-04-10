using Section12_Chess.ChessGame;
using Section12_Chess.GameBoard;
using System;

namespace Section12_Chess
{
    public static class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.GetPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(board.GetPiece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.white)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor consoleColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = consoleColor;
            }
        }

        public static OriginalChessPosition ReadPosition()
        {
            string chessMove = Console.ReadLine();
            char column = chessMove[0];
            int row = int.Parse(chessMove[1]+"");

            return new OriginalChessPosition(column, row);
        }
    }
}
