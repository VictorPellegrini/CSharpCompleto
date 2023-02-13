namespace Section12_Chess.board
{
    public class Board
    {
        private Piece[,] pieces;
        public int linhas { get; set; }
        public int colunas { get; set; }

        public Board(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pieces = new Piece[linhas, colunas];
        }
    }
}
