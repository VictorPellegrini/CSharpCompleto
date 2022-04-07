using Section11155_Exceptions.Entities.Exceptions;
using System;
using System.Globalization;

namespace Section11155_Exceptions.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if(Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
            Console.WriteLine("New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}