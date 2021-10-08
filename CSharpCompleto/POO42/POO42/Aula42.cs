using System;

namespace POO42
{
    class Aula42
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados atualizados: " + p1);

            Console.WriteLine("Digite quantos produtos serão adicionados:");
            int adicionado = int.Parse(Console.ReadLine());

            p1.AddProduto(adicionado);
            Console.WriteLine("Dados atualizados: " + p1);

            Console.WriteLine("Digite quantos produtos serão removidos:");
            int removido = int.Parse(Console.ReadLine());

            p1.RemoveProduto(removido);
            Console.WriteLine("Dados atualizados: " + p1);
        }
    }
}
