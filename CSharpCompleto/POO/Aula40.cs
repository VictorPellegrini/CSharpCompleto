using System;

namespace POO40
{
    class Aula40
    {
        /*
        1. Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
        velha.

        2. Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
        médio dos funcionários.
        */

        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            //dados p1
            Console.WriteLine("Informe o nome da primeira pessoa:");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do(a) " + p1.Nome + ":");
            p1.Idade = int.Parse(Console.ReadLine());

            //dados p2
            Console.WriteLine("Informe o nome da segunda pessoa:");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do(a) " + p2.Nome + ":");
            p2.Idade = int.Parse(Console.ReadLine());

            //idade
            if (p1.Idade > p2.Idade)
                Console.WriteLine("O(a) " + p1.Nome + " é mais velho(a).");

            else Console.WriteLine("O(a) " + p2.Nome + " é mais velho(a).");

            //salario
            Console.WriteLine("Informe o salário do(a) " + p1.Nome + ":");
            p1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salário do(a) " + p2.Nome + ":");
            p2.Salario = double.Parse(Console.ReadLine());

            double media = (p1.Salario + p2.Salario) / 2.0;
            Console.WriteLine("A média dos salários é " + media.ToString("F2"));
        }
    }
}
