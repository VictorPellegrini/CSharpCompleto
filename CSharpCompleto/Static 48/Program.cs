﻿using System;

namespace Static_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a atual cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você quer comprar?");
            int quantidade = int.Parse(Console.ReadLine());

            double valor = ConversorDeMoeda.valorDevido(quantidade, cotacao);

            Console.WriteLine("O custo atual de " + quantidade + " dólares é R$" + valor);
        }
    }
}