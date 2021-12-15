using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2_Laengenanalyse
{
    class LengthCount
    {
        Dictionary<int, int> myWordLength = new Dictionary<int, int>();

        public void analyseWords(string text)
        {
            myWordLength = new Dictionary<int, int>();
            string[] parts = text.Split(" ");
            foreach (string item in parts)
            {
                if (myWordLength.ContainsKey(item.Length))
                {
                    myWordLength[item.Length] = myWordLength[item.Length] + 1;
                }
                else
                {
                    myWordLength.Add(item.Length, 1);
                }
            }
            Console.WriteLine("Der Text wurde analysiert!");
        }

        public void analyseWordsOfFile(string pathToFile)
        {
            string text;
            // open, read and save content of word file
            try
            {
                 text = System.IO.File.ReadAllText(pathToFile);
            }
            catch (System.IO.DirectoryNotFoundException)    // if the file can't be found, the user will be informed
            {
                Console.WriteLine("Die Datei wurde nicht gefunden!");
                return;
            }
            analyseWords(text);
        }

        public override string ToString()
        {
            string text = "Wortlänge - Vorkommen(Häufigkeit)\n";
            foreach (KeyValuePair<int, int> item in myWordLength)
            {
                text = text +item.Key + " - " + item.Value +"\n";
            }
            return text;
        }
    }
}
