using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioDeFixacao60
{
    public class Conta
    {
        public int ContaId { get; private set; }
        public string Titular { get; private set; }        
        public double Saldo { get; private set; }

        public Conta()
        {

        }

        public Conta(int contaIdInserido, string nome, double valorInicial)
        {
            ContaId = contaIdInserido;
            Titular = nome;
            Saldo = valorInicial;
            Console.WriteLine("\r\nDados da conta:");
            Console.WriteLine("Conta: " + ContaId + ", Titular: " + Titular + ", Saldo: $" + Saldo + ".");
        }

        public Conta(int contaIdInserido, string nome)
        {
            ContaId = contaIdInserido;
            Titular = nome;            
            Console.WriteLine("\r\nDados da conta:");
            Console.WriteLine("Conta: " + ContaId + ", Titular: " + Titular + ", Saldo: $ 0,00.");
        }

        public void Depositar()
        {
            Console.WriteLine("\r\nDigite um valor para deposito:");
            double deposito = double.Parse(Console.ReadLine());
            Saldo = Saldo + deposito;
        }

        public void Sacar()
        {
            Console.WriteLine("\r\nDigite um valor para saque:");
            double saque = double.Parse(Console.ReadLine());
            Saldo = Saldo - (saque + 5);
        }

        public void DadosAtualizados(Conta usuario)
        {
            Console.WriteLine("\r\nDados da conta atualizados:");
            Console.WriteLine("Conta: " + usuario.ContaId + ", Titular: " + usuario.Titular + ", Saldo: $" + usuario.Saldo + ".");
        }
    }
}
