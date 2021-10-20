using System;

namespace ErsterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Zahlensammlung.ProcessInteger(-3);
                Zahlensammlung.ProcessInteger(-2);
                Zahlensammlung.ProcessInteger(-1);
                Zahlensammlung.ProcessInteger(1);
                Zahlensammlung.ProcessInteger(2);
                Zahlensammlung.ProcessInteger(3);
                Zahlensammlung.PrintList();
                Zahlensammlung.ProcessInteger(3);
            }
            catch (DuplicateNumberException)
            {
                Console.WriteLine("Die eingegebene Zahl wurde bereits eingegeben");
            }
        }
    } 
}
