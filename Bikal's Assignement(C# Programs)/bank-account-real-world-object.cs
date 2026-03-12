using System;

class BankAccount
{
    public string accountHolder;
    public double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Display()
    {
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: " + balance);
    }
}       
class Program
{
 static void Main()
 {
 BankAccount acc = new BankAccount();

 acc.accountHolder = "Ram";
 acc.balance = 5000;

 acc.Deposit(2000);

 acc.Display();
 }
}