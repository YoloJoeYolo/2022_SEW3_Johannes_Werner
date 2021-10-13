using System;
using System.Collections.Generic;

namespace _06Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            myDict.Add(12, "Markus Leonhardsberger");
            myDict.Add(13, "Tobias Nagel");
            myDict.Add(14, "Jakob Prem");
            myDict.Add(15, "Stefan Schwödiauer");
            myDict.Add(16, "Elias Seeböck");

            Console.WriteLine(myDict[14]);  //Zugriff auf den Wert, der unter dem Schlüssel 14 gespeichert ist

            Random rand = new Random();
            int nr = rand.Next(12, 17);
            Console.WriteLine("Zur Stundenwiederholung " + myDict[nr]);

            Dictionary<string, string> germanEnglish = new Dictionary<string, string>();
            germanEnglish.Add("Haus", "house");
            germanEnglish.Add("Küche", "kitchen");
            germanEnglish.Add("Dach", "roof");

            Console.Write("Deutsch-Englisch ÜBersetzer! Bitte ein Wort eingeben: ");
            string input = Console.ReadLine();
            if (germanEnglish.ContainsKey(input))
            {
                Console.WriteLine("Deutsch: " + input + " Englisch: " + germanEnglish[input]);
            }
            else
            {
                Console.WriteLine("Übersetzung leider nicht gefunden");

                Console.WriteLine("Alle Einträge des Dictionaries");
                // Iterieren über alle Elemente --> alle Werte "besuchen"
                foreach (KeyValuePair<string, string> element in germanEnglish)
                {
                    Console.WriteLine("Deutsch: " + element.Key + "Englisch: " + element.Value);
                }
            }

    }
    }
}
