using System;

namespace ExercícioDeFixacao60
{
    public class ContaBancaria
    {
        public int ContaId { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int contaId, string titular)
        {
            ContaId = contaId;
            Titular = titular;
            Console.WriteLine("\r\nDados da conta:");
            Console.WriteLine("Conta: " + ContaId + ", Titular: " + Titular + ", Saldo: $ 0,00.");
        }

        public ContaBancaria(int contaId, string titular, double valorInicial) : this(contaId, titular)
        {
            Saldo = valorInicial;
            Console.WriteLine("\r\nDados da conta:");
            Console.WriteLine("Conta: " + ContaId + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2") + ".");
        }

        public override string ToString()
        {
            return "\r\nDados da conta atualizados: \r\nConta: " + ContaId + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2") + ".";
        }

        public void Depositar()
        {
            Console.Write("\r\nDigite um valor para deposito:");
            double deposito = double.Parse(Console.ReadLine());
            Saldo = Saldo + deposito;
        }

        public void Sacar()
        {
            Console.Write("\r\nDigite um valor para saque:");
            double saque = double.Parse(Console.ReadLine());
            Saldo = Saldo - (saque + 5);
        }
    }
}
