using System;

namespace _07.Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numProjects = int.Parse(Console.ReadLine());

            double hoursNeeded = numProjects * 3;

            Console.WriteLine($"The architect {name} will need {hoursNeeded} hours to complete {numProjects} project/s.");
        }
    }
}
