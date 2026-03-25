using System.ComponentModel.Design;

namespace C_Basics.Assignment
{
    internal class AssignmentExercises
    {

        public static void GetSwapUsingThirdVariable()
        {
            int a = 10, b = 20, temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap: a = " + a + ", b = " + b);
        }



        public static void GetSwapUsingWithoutThirdVariable()
        {
            int a = 10, b = 20;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swap: a = " + a + ", b = " + b);
        }


        public static void GetPrimeNumber()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (n <= 1) isPrime = false;
            else if(n == 2) isPrime = true;
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;

                    }
                }
            }
            Console.WriteLine(isPrime ? "Prime Number" : "Not Prime");
        }

        public static void GetPalindromeNumber()
        {

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int original = n, reverse = 0;
            while (n > 0)
            {
                reverse = reverse * 10 + n % 10;
                n /= 10;
            }
            Console.WriteLine(original == reverse ? "Palindrome" : "Not Palindrome");
        }

        public static void GetReverseNumber()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;
            while (num > 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine($"Reversed number = {reversed}");
            Console.ReadKey();
        }

        public static void GetArmstrongNumberThreedigit()
        {

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int original = n, sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit * digit;
                n /= 10;
            }
            Console.WriteLine(sum == original ? "Armstrong Number" : "Not Armstrong");
        }


        public static void GetFahrenheitToCelsius()
        {
            Console.Write("Enter Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + c);

        }

        public static void GetFibonacciSeriesRecursive()
        {
            Console.Write("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                Console.Write(Fibonacci(i) + " ");
        }

        static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }


        public static void GetVowelCountInString()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine().ToLower(); int count = 0;
            foreach (char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
                Console.WriteLine($"Total number of vowels = {count}");
                Console.ReadKey();
            }
        }

        public static void GetMissingNumber()
        {
            Console.Write("Enter value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n - 1];
            Console.WriteLine($"Enter {n - 1} numbers (one missing from 1 to {n}):");
            for (int i = 0; i < n - 1; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;
            foreach (int x in arr) actualSum += x;
            int missing = expectedSum - actualSum;
            Console.WriteLine($"Missing number is: {missing}");
            Console.ReadKey();
        }
    }
}
