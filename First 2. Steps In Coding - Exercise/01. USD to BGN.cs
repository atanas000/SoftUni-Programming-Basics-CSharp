using System;

namespace Exercises___First_Steps_in_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double bgn = usd * 1.79549;

            Console.WriteLine(bgn);
        }
    }
}
