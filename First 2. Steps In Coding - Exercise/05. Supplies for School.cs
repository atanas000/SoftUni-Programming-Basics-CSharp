using System;

namespace _05.Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPen = int.Parse(Console.ReadLine());
            int numMarkers = int.Parse(Console.ReadLine());
            int litresLiquid = int.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine()) / 100;

            double sumWithoutDiscount = (numPen * 5.80) + (numMarkers * 7.20) + (litresLiquid * 1.20);
            double discount = sumWithoutDiscount * discountPercent;
            double total = sumWithoutDiscount - discount;

            Console.WriteLine(total);
        }
    }
}
