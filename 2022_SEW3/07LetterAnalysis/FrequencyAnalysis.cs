using System;
using System.Collections.Generic;
using System.Text;

namespace _07LetterAnalysis
{
     class FrequencyAnalysis
    {
        public static Dictionary<char, int> generateAalysis(string text)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            for(int i = 0; i < text.Length; i++)
            {
                char letter = text[i];  // char --> Datentyp für 1 Buchstaben
                if (frequency.ContainsKey(letter))
                {
                    frequency[letter]++;
                }
                else
                {
                    frequency[letter] = 1;
                }
            }
            return frequency;
        }
    }
}
