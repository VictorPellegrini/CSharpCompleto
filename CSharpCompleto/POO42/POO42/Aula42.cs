using System;

namespace POO42
{
    class Aula42
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto;

            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade:");
            p1.Quantidade = int.Parse(Console.ReadLine());
        }
    }
}
