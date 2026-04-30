using System;

namespace C_Basics.Oop.Abstraction
{
    // Abstract class representing a Bank Account
    // Abstract classes cannot be instantiated and can contain both abstract and non-abstract members
    // Abstract methods are declared without an implementation and must be implemented by derived classes

    //Abstract class helps in defining a common interface for a group of related classes while allowing each class to provide its own implementation of the abstract methods.
    //It promotes code reusability and enforces a contract for derived classes to follow.

    abstract class BankAccount
    {
        // Abstract methods (must be implemented by derived classes)
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract decimal GetBalance();

        // Non-abstract method (common functionality for all accounts)
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to XYZ Bank! Your transactions are secure.");
        }
    }

    // Concrete class implementing the abstract methods
    class SavingsAccount : BankAccount
    {
        private decimal balance;

        public override void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public override decimal GetBalance()
        {
            return balance;
        }




        // Another concrete account type with different withdrawal rules
        class CheckingAccount : BankAccount
        {
            private decimal balance;
            private decimal overdraftLimit = -500m; // allow small overdraft

            public override void Deposit(decimal amount)
            {
                balance += amount;
                Console.WriteLine($"Checking: Deposited: {amount}, New Balance: {balance}");
            }

            public override void Withdraw(decimal amount)
            {
                if (balance - amount >= overdraftLimit)
                {
                    balance -= amount;
                    Console.WriteLine($"Checking: Withdrawn: {amount}, Remaining Balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Checking: Overdraft limit exceeded!");
                }
            }

            public override decimal GetBalance()
            {
                return balance;
            }
        }


        public static void CallBankAccountDemo()
        {
            // Demonstrate abstraction: use BankAccount reference for different concrete accounts
            BankAccount savings = new SavingsAccount();
            BankAccount checking = new CheckingAccount();

            Console.WriteLine("-- Savings Account Demo --");
            savings.PrintWelcomeMessage();
            savings.Deposit(1000);
            savings.Withdraw(400);
            Console.WriteLine($"Savings Final Balance: {savings.GetBalance()}\n");

            Console.WriteLine("-- Checking Account Demo --");
            checking.PrintWelcomeMessage();
            checking.Deposit(500);
            checking.Withdraw(900); // may go into overdraft depending on rules
            Console.WriteLine($"Checking Final Balance: {checking.GetBalance()}\n");

            Console.WriteLine("Note: Both accounts are used through the BankAccount type,\nso callers don't need to know the concrete implementation details.");
        }
    }

}
