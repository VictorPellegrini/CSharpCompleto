using System;

namespace ExercícioDeFixacao60
{
    class UserStory
    {
        static void Main(string[] args)
        {
            Conta usuario = new Conta();

            Console.WriteLine("Informe:");
            Console.WriteLine(" - Número da conta:");
            var contaIdInserido = int.Parse(Console.ReadLine());

            Console.WriteLine(" - Nome do titular da conta:");
            var nome = Console.ReadLine();

            Console.WriteLine(" - Haverá depósito inicial? (s/n)");
            char option = char.Parse(Console.ReadLine());

            if (option == 's')
            {
                Console.WriteLine(" - Depósito inicial:");
                double valorInicial = double.Parse(Console.ReadLine());
                usuario = new Conta(contaIdInserido, nome, valorInicial);
            }
            else
                usuario = new Conta(contaIdInserido, nome);
                

            //deposito
            usuario.Depositar();
            usuario.DadosAtualizados(usuario);

            //saque            
            usuario.Sacar();
            usuario.DadosAtualizados(usuario);
        }        
    }
}
