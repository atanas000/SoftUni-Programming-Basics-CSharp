using System;

namespace _02.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double grad = rad * (180 / Math.PI);
            Console.WriteLine(grad);
        }
    }
}
