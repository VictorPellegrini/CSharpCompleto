namespace POO42
{
    class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public double Valor_Em_Estoque()
        {
            return Preco * Quantidade;
        }

        public int Add_Produto()
        {
            Quantidade = Quantidade + Adicionado;
            return Quantidade;
        }

        public int Remove_Produto()
        {
            Quantidade = Quantidade - Removido;
            return Quantidade;
        }
    }
}
