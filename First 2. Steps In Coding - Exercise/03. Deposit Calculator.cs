using System;

namespace _03.Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)   */
            double depositedAmount = double.Parse(Console.ReadLine());
            int depositAge = int.Parse(Console.ReadLine());
            double yearlyPercent = double.Parse(Console.ReadLine()) / 100;

            double sum = depositedAmount + depositAge * ((depositedAmount * yearlyPercent) / 12);

            Console.WriteLine(sum);
        }
    }
}
