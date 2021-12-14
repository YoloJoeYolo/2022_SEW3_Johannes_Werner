using System;
using System.Collections.Generic;
using System.Text;

namespace Test201
{
    class Vocabulary
    {
        Dictionary<string, string> words = new Dictionary<string, string>();

        public void AddWord(string germanWord, string englishWord)
        {
            if (words.ContainsKey(germanWord))
            {
                Console.WriteLine("Das Wort wurde bereits hinzugefügt!");
            }
            else
            {
                words.Add(germanWord, englishWord);
                Console.WriteLine("Das Wort wurde hinzugefügt!");
            }
        }

        public void Train(int nummberOfWords)
        {
            if (words.Count == 0)
            {
                Console.WriteLine("Es sind keine Einträge vorhanden...");
            }
            else
            {
                Random rand = new Random();
                List<int> exercisedWords = new List<int>();
                List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
                foreach (KeyValuePair<string, string> item in words)
                {
                    keyValuePairs.Add(item);
                }
                for (int i = 0; i < keyValuePairs.Count && i < nummberOfWords; i++)
                {
                    int temp = rand.Next(keyValuePairs.Count);
                    while (exercisedWords.Contains(temp))
                    {
                        temp = rand.Next(keyValuePairs.Count);
                    }
                    exercisedWords.Add(temp);
                    if (rand.Next(2) == 0)
                    {
                        Console.WriteLine("Das Wort \"{0}\" wird  in Englich wie geschrieben?: ", keyValuePairs[temp].Key);
                        string input = Console.ReadLine();
                        if (input == keyValuePairs[temp].Value)
                        {
                            Console.WriteLine("Richtig!");
                        }
                        else
                        {
                            Console.WriteLine("Probiere es noch einmal: ");
                            input = Console.ReadLine();
                            if (input == keyValuePairs[temp].Value)
                            {
                                Console.WriteLine("Richtig!");
                            }
                            else
                            {
                                Console.WriteLine("Schade ;(\n" +
                                                  "Die Lösung wäre {0}", keyValuePairs[temp].Value);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das Wort \"{0}\" wird in Deutsch wie geschrieben?: ", keyValuePairs[temp].Value);
                        string input = Console.ReadLine();
                        if (input == keyValuePairs[temp].Key)
                        {
                            Console.WriteLine("Richtig!");
                        }
                        else
                        {
                            Console.WriteLine("Probiere es noch einmal: ");
                            input = Console.ReadLine();
                            if (input == keyValuePairs[temp].Key)
                            {
                                Console.WriteLine("Richtig!");
                            }
                            else
                            {
                                Console.WriteLine("Schade ;(\n" +
                                                  "Die Lösung wäre {0}", keyValuePairs[temp].Key);
                            }
                        }
                    }
                }
            }
        }

        public void AllVocabulary()
        {
            if (words.Count == 0)
            {
                Console.WriteLine("Es sind keine Einträge vorhanden...");
            }
            else
            {
                Console.WriteLine("Alle Einträge:");
                foreach (KeyValuePair<string, string> item in words)
                {
                    Console.WriteLine("   - {0:######}| {1:######}", item.Key, item.Value);
                }
            }
        }

        public void SaveVocabulary(string filePath)
        {
            if (words.Count == 0)
            {
                Console.WriteLine("Es sind keine Einträge vorhanden...");
            }
            else
            {
                string text = "";
                foreach (KeyValuePair<string, string> item in words)
                {
                    text = text + item.Key + "|" + item.Value + "\n";
                }
                System.IO.File.WriteAllText(filePath, text);
                Console.WriteLine("Die Wörder Liste wurde gespeichert");
            }
        }

        public void LoadVocabulary(string filePath)
        {
            List<string> lines = new List<string>(System.IO.File.ReadAllLines(filePath));
            foreach (string line in lines)
            {
                line.Trim();
                string[] temp = line.Split('|');
                AddWord(temp[0], temp[1]);
            }
            Console.WriteLine("Die Wörder Liste wurde geladen");
        }
    }
}
