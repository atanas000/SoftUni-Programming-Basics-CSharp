using System;

namespace _04.Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPagesInCurrentBook = int.Parse(Console.ReadLine());
            int numPagesForOneHour = int.Parse(Console.ReadLine());
            int numDaysToReadBook = int.Parse(Console.ReadLine());

            double pagesForHour = numPagesInCurrentBook / numPagesForOneHour;
            double pagesForDay = pagesForHour / numDaysToReadBook;

            Console.WriteLine(pagesForDay);
        }
    }
}
