using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededNailon = int.Parse(Console.ReadLine());
            int neededPaint = int.Parse(Console.ReadLine());
            int neededRazreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sum = (neededNailon + 2) * 1.50 + (neededPaint + (0.10 * neededPaint)) * 14.50 + neededRazreditel * 5 + 0.40;

            double payWorkers1Hour = 0.3 * sum;

            Console.WriteLine(sum + (hours * payWorkers1Hour));
        }
    }
}
