using System;

namespace C_Basics.Class.Static
{
    public static class BankUtility
    {
        public static double ConvertUsdToNpr(double usd)
        {
            double rate = 133.5; // current conversion rate
            return usd * rate;
        }

        public static double CalculateInterest(double balance, double rate)
        {
            return (balance * rate) / 100;
        }

        // Small demo method to show usage of the static utility
        public static void ShowDemo()
        {
            double nprAmount = ConvertUsdToNpr(100);
            Console.WriteLine("100 USD in NPR = " + nprAmount);

            double interest = CalculateInterest(5000, 7);
            Console.WriteLine("Interest = " + interest);
        }
    }
}
