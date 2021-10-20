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

            // geschachtelte Dictionary --> Key: string, Value: List<string>
            Dictionary<string, List<string>> telefonbuch = new Dictionary<string, List<string>>();

            // neuen Eintrag hinzufügen
            telefonbuch["Thomas Riegler"] = new List<string>();     // neue Liste für den Wert erstellen
            telefonbuch["Thomas Riegler"].Add("0664/...");
            telefonbuch["Thomas Riegler"].Add("0680/...");
            List<string> myNumbers = telefonbuch["Thomas Riegler"]; // Liste mit meinen Telefonnummern

            // Eintrag im Telefonbuch suchen
            if (telefonbuch.ContainsKey("Tobias Nagel"))
            {
                List<string> number = telefonbuch["Tobias Nagel"];
            }

            // alle Nummern eines Eintrages ausgeben
            if(telefonbuch.ContainsKey("Thomas Riegler"))
            {
                foreach(string number in telefonbuch["Thomas Riegler"])
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
