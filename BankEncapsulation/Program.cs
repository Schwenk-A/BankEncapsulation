using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
                var bankAccount = new BankAccount();
            bankAccount.Deposit(5);
            Console.WriteLine(bankAccount.GetBalance());
            bankAccount.Deposit(3);
            Console.WriteLine(bankAccount.GetBalance());

        }
    }
}
