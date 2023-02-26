using System;

namespace Section12_Chess.GameBoard
{
    public class BoardExceptions : Exception
    {
        public BoardExceptions(string message) : base(message)
        {
        }
    }
}
