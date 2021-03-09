using AccountExceptions.Entities;
using AccountExceptions.Entities.Exceptions;
using System;

namespace AccountExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {


                Console.WriteLine("Enter account data");

                Console.Write("\nNumber: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdraw);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);

                Console.WriteLine($"New balance: {account}");
            }
            catch (DomainExceptions ex)
            {

                Console.WriteLine($"Withdraw error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();

        }
    }
}
