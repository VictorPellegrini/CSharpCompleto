using Section10146_Abstracao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Section10146_Abstracao
{
    public class UserStory146
    {
        static void Main()
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> payersList = new List<TaxPayer>(n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\r\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                if (type != 'i' && type != 'c')
                {
                    Console.WriteLine("\r\nOpção incorreta. Tente novamente.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Main();
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expense = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payersList.Add(new IndividualTaxPayer(name, income, expense));
                }
                else if (type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    payersList.Add(new LegalTaxPayer(name, income, employees));
                }
            }

            Console.WriteLine("\r\n****** TAXES PAID ******");

            double totalTaxes = 0;
            foreach (TaxPayer payer in payersList)
            {
                Console.WriteLine(payer);
                totalTaxes += payer.TotalTax();
            }

            Console.WriteLine("\r\n****** TOTAL TAXES ******");
            Console.WriteLine("$ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}