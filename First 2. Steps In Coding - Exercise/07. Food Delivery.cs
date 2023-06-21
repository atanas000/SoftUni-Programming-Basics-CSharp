using System;

namespace _07.Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChickenMenu = int.Parse(Console.ReadLine());
            int numFishMenu = int.Parse(Console.ReadLine());
            int numVegMenu = int.Parse(Console.ReadLine());

            double sum = (numChickenMenu * 10.35) + (numFishMenu * 12.40) + (numVegMenu * 8.15);
            double desertSum = 0.2 * sum;

            double total = sum + desertSum + 2.50;

            Console.WriteLine(total);
        }
    }
}
