namespace C_Basics.ExceptionHandlingDemo
{

    // Step 1: Define a custom exception class
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

    internal class BankAccEH
    {

        // Step 2: Create a class that uses the custom exception

        private decimal balance;

        public BankAccEH(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                // Throw custom exception when withdrawal is invalid
                throw new InsufficientFundsException(
                    $"Attempted to withdraw {amount}, but only {balance} is available."
                );
            }

            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {balance}");
        }

        public decimal GetBalance()
        {
            return balance;
        }


        // Step 3: Handle the custom exception in Calling function 

        public static void CallCustomExceptionDemo()
        {
            BankAccEH account = new BankAccEH(500);

            try
            {
                account.Withdraw(700); // This will trigger the custom exception
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Final Balance: {account.GetBalance()}");
            }
        }
    }


}
