using System;

namespace _08.Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlyTax = int.Parse(Console.ReadLine());

            double priceSneakers = yearlyTax - (0.4 * yearlyTax);
            double priceSuit = priceSneakers - (0.2 * priceSneakers);
            double priceBall = 0.25 * priceSuit;
            double priceAccessories = 0.2 * priceBall;

            double expenses = yearlyTax + priceSneakers + priceSuit + priceBall + priceAccessories;
            Console.WriteLine(expenses);
        }
    }
}
