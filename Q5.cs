using System;

namespace Assesment
{
    internal class Pay_calculation
    {
        public static double GetGrossPay(int hours)
        {
            double grosspay;
            if (hours <= 56) grosspay = 80 * hours;
            else grosspay = (80 * 1.5 * (hours - 56)) + (80*56);
            return grosspay;
        }
        public static double CalculateTax(double grosspay)
        {
            double tax = (2 * grosspay) / 100;
            return tax;
        }
        public static double CalculateNetPay(int hours)
        {
            double grosspay = GetGrossPay(hours);
            double tax = CalculateTax(grosspay);
            double netpay = grosspay - tax;
            return netpay;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of hours worked: ");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("The calculated Net Pay is $" + CalculateNetPay(hours));
        }
    }
}
