﻿using Section12_Chess.ChessGame;
using Section12_Chess.GameBoard;
using System;

namespace Section12_Chess
{
    public static class Screen
    {
        public static void PrintChessMatch(ChessMatch chessMatch)
        {
            PrintBoard(chessMatch.Board);
            PrintCapturedPieces(chessMatch);

            if (chessMatch.Finished)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n -- CHECKMATE! --");
                Console.WriteLine("Winner: " + chessMatch.CurrentPlayer);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n\nRound: " + chessMatch.Round + ". - " + chessMatch.CurrentPlayer + " player's turn.");

            if (chessMatch.Check)
            {
                ConsoleColor consoleColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n -- CHECK! --");
                Console.ForegroundColor = consoleColor;
            }

            Console.Write("\nInsert the position of the piece to move (column and line): ");
        }

        public static void PrintBoard(Board board, bool[,] piecePossibleMovements)
        {
            ConsoleColor originalBackgroundColor = Console.BackgroundColor;
            ConsoleColor possibleMovementsBackgroundColor = ConsoleColor.DarkGray;

            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if (piecePossibleMovements[i, j])
                    {
                        Console.BackgroundColor = possibleMovementsBackgroundColor;
                    }
                    else
                    {
                        Console.BackgroundColor = originalBackgroundColor;
                    }
                    PrintPiece(board.GetPiece(i, j));
                    Console.BackgroundColor = originalBackgroundColor;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = originalBackgroundColor;
        }

        public static OriginalChessPosition ReadPosition()
        {
            string chessMove = Console.ReadLine();

            char column = chessMove[0];
            int.TryParse(chessMove[1] + "", out int row);

            return new OriginalChessPosition(column, row);
        }

        private static void PrintCapturedPieces(ChessMatch chessMatch)
        {
            Console.WriteLine("\nCaptured pieces:");

            Console.Write("Whites -> ");
            PrintCapturedPieces(chessMatch, Color.White);

            Console.Write("\nBlacks -> ");
            ConsoleColor consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCapturedPieces(chessMatch, Color.Black);
            Console.ForegroundColor = consoleColor;
        }

        private static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    PrintPiece(board.GetPiece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        private static void PrintCapturedPieces(ChessMatch chessMatch, Color color)
        {
            var pieces = chessMatch.GetCapturedPieces(color);

            foreach (var piece in pieces)
            {
                Console.Write(piece.ToString() + " ");
            }
        }

        private static void PrintPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (piece.Color == Color.White)
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
                Console.Write(" ");
            }
        }
    }
}
