using System;

namespace _09.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;

            double volumeInCm = length * width * height;
            double litres = volumeInCm / 1000;

            double total = litres - (litres * percent);
            Console.WriteLine(total);
        }
    }
}
