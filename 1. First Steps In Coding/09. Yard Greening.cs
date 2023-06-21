using System;

namespace _09.Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMForGreening = double.Parse(Console.ReadLine());

            double sum = sqMForGreening * 7.61;
            double discount = 0.18 * sum;

            Console.WriteLine("The final price is: {0} lv.", sum - discount);
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
