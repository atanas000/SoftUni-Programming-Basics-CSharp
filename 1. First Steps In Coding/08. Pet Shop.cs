using System;

namespace _08.Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDogFood = int.Parse(Console.ReadLine());
            int numCatFood = int.Parse(Console.ReadLine());

            double sumDogFood = numDogFood * 2.50;
            double sumCatFood = numCatFood * 4;

            Console.WriteLine($"{sumCatFood + sumDogFood} lv.");
        }
    }
}
