using System;
using System.Collections.Generic;
using System.Text;

namespace _2AT._2_Haeufigkeitsanalyse
{
    class Frequency
    {
        Dictionary<char, int> mySpecialCharacter = new Dictionary<char, int>();

        public void analyseText(string text)
        {
            mySpecialCharacter = new Dictionary<char, int>();
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (char item in text)
            {
                char letter = item;
                if (abc.IndexOf(letter) == -1)
                {
                    if (mySpecialCharacter.ContainsKey(letter))
                    {
                        mySpecialCharacter[letter]++;
                    }
                    else
                    {
                        mySpecialCharacter[letter] = 1;
                    }
                }
            }
        }

        public void analyseTextOfFile(string pathToFile)
        {
            string text = System.IO.File.ReadAllText(pathToFile);
            analyseText(text);
        }

        public override string ToString()
        {
            string temp = "";
            foreach (KeyValuePair<char,int> item in mySpecialCharacter)
            {
                temp = temp + item.Key + " - " + item.Value.ToString() + "\n";
            }
            return temp;
        }

    }
}
