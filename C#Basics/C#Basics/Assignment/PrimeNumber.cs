namespace C_Basics.Assignment
{
    internal class PrimeNumber
    {
        public static void CheckPrime()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            bool isPrime = true;
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number.");
            }
        }


        public static void CheckListStartsWithAUsingLamda()
        {

            List<string> names = ["Alice", "Bob", "Anna", "Charlie", "David"];
            var namesStartingWithA = names.Where(name => name.StartsWith("A"));
            Console.WriteLine("Names starting with 'A':");
            foreach (var name in namesStartingWithA)
            {
                Console.WriteLine(name);

            }

        }

        public static void CheckStringStartsWithAUsingLamda()
        {
            Console.Write("Enter a name: ");
            var input = (Console.ReadLine() ?? string.Empty).Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No name entered.");
                return;
            }

            // Case-insensitive check whether the entered single name starts with 'A'
            bool startsWithA = input.StartsWith("A", StringComparison.OrdinalIgnoreCase);

            if (startsWithA)
            {
                Console.WriteLine($"{input} starts with 'A'.");
            }
            else
            {
                Console.WriteLine($"{input} does not start with 'A'.");
            }
        }


    }
}


