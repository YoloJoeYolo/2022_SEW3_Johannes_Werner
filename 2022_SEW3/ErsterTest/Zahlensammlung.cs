using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterTest
{
    static class Zahlensammlung
    {
        static List<int> uniqueNumbers = new List<int>();
        static public void ProcessInteger(int number)
        {
            foreach(int element in uniqueNumbers)
            {
                if (element == number)
                {
                    throw new DuplicateNumberException();
                }
            }
            uniqueNumbers.Add(number);
        }

        static public void PrintList()
        {
            string temp = "";
            foreach (int element in uniqueNumbers)
            {
                temp = temp + element.ToString() + "; ";
            }
            Console.WriteLine(temp);
        }
    }
}
