using Section11155_Exceptions.Entities;
using Section11155_Exceptions.Entities.Exceptions;
using System;
using System.Globalization;
using System.Threading;

namespace Section11155_Exceptions
{
    class UserStory155
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("****** Enter account data ******");
                Console.Write("\r\nNumber: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            catch(DomainException exception)
            {
                Console.WriteLine("\r\nHouston, we have a problem: " + exception.Message);

                Thread.Sleep(2000);
                Console.Write("\nRestarting");
                for(int i = 0; i < 6; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Main();
            }
        }
    }
}
