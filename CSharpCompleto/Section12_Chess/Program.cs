using Section12_Chess.board;
using System;

namespace Section12_Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Guys!\n");

            var board = new Board(8, 8);

            Screen.printBoard(board);
        }
    }
}
