using System;
using System.Collections.Generic;

namespace _07LetterAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte einen Text eingeben: ");
            string text = Console.ReadLine();

            Dictionary<char, int> result = FrequencyAnalysis.generateAalysis(text);

            foreach(KeyValuePair<char,int> element in result)   // key: Buchstae value: Häufigkeit
            {
                Console.WriteLine(element.Key + ": " + element.Value);
            }
        }
    }
}
