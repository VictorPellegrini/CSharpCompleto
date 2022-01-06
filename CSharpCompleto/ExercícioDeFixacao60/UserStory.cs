using System;

namespace ExercícioDeFixacao60
{
    class UserStory
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta;

            Console.WriteLine("Informe:");
            Console.Write(" - Número da conta: ");
            var contaIdInserido = int.Parse(Console.ReadLine());

            Console.Write(" - Nome do titular da conta: ");
            var nome = Console.ReadLine();

            Console.Write("\r\n - Haverá depósito inicial (s/n)? ");
            char option = char.Parse(Console.ReadLine());

            if (option == 's' || option == 'S')
            {
                Console.Write(" - Depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine());
                Conta = new ContaBancaria(contaIdInserido, nome, valorInicial);
            }
            else
                Conta = new ContaBancaria(contaIdInserido, nome);
                

            //deposito
            Conta.Depositar();
            Console.WriteLine(Conta);

            //saque            
            Conta.Sacar();
            Console.WriteLine(Conta);
        }        
    }
}
