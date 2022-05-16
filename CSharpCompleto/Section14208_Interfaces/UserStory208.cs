using Section14208_Interfaces.Entities;
using Section14208_Interfaces.Services;
using System;


namespace Section14208_Interfaces
{
    public class UserStory208
    {
        static void Main()
        {
            Console.WriteLine("***** Enter contract data *****");
            Console.Write("\nNumber: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Total value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract contract = new(number, date, value);

            PayPalService payPalService = new();
            var contractService = new ContractService(payPalService);

            contractService.ProcessContract(contract, numberInstallments);            

            Console.WriteLine("\n***** Installments *****");

            foreach(var installment in contract.Installment)
            {
                Console.WriteLine(installment.DueDate + " - " + installment.Amount);
            }
        }
    }
}