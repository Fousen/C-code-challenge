using System;

namespace Assesment
{
    internal class Clearance_sale
    {
        static void Main(string[] args)
        {
            int day1_total, day2_total, day3_total;

            Console.WriteLine("Enter the name of the product : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the product on SALE (yes/no): ");
            string on_sale = Console.ReadLine();
            Console.WriteLine("Enter number of product sold in day 1 ");
            int day1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 2 ");
            int day2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 3 ");
            int day3 = int.Parse(Console.ReadLine());

            Console.WriteLine(name);

            if(on_sale == "yes")
            {
                Console.WriteLine($"Day 1 sales total : {(0.93 * price * day1)} " +
                    $"\nDay 2 sales total : {(0.93 * 0.93 * price * day2)} " +
                    $"\nDay 3 sales total : {(0.93 * 0.93 * 0.93 * price * day3)}");
            }
            else
            {             
                Console.WriteLine($"Day 1 sales total : {price * day1} " +
                    $"\nDay 2 sales total : {price * day2} " +
                    $"\nDay 3 sales total : {price * day3}");

            }

        }
    }
}