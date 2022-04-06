namespace Section0442_POO
{
    class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AddProduto(int adicionado)
        {
            Quantidade = Quantidade + adicionado;
        }

        public void RemoveProduto(int removido)
        {
            Quantidade = Quantidade - removido;            
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ". Valor unitário: R$"
                + Preco.ToString("F2")
                + ". Quantidade: "
                + Quantidade
                + " unidades. Valor total em estoque: R$"
                + ValorEmEstoque().ToString("F2");
        }
    }
}
