using AccountExceptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountExceptions.Entities
{
    class Account
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
            if (amount > Balance && amount < WithdrawLimit)
            {
                throw new DomainExceptions($"Not enough balance");
            }

            if (amount > WithdrawLimit && amount < Balance)
            {
                throw new DomainExceptions($"The amount exceeds withdraw limit");
            }
            if (amount > WithdrawLimit && amount > Balance)
            {
                throw new DomainExceptions($"The amount exceeds withdraw limit and exceed the balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"{Balance.ToString("C")}";
        }
    }
}
