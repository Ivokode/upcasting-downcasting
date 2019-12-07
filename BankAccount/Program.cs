using System;
using BankAccount.Entities;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //upcasting

            Account acc1 = bacc;
            Account acc2 = new Account(1003, "Bob", 500.0);
            Account acc3 = new SavingsAccount(1004, "Mike", 500.0, 0.08);

            acc2.Withdraw(5.00);
            acc3.Withdraw(5.00);

            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);


        }
    }
}
