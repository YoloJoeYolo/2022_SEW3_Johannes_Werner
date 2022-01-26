using System;
using System.Collections.Generic;
using System.Text;

namespace _2AT._1_Hervorhebung
{
    class ConvertString
    {
        static public string convert(string text, string schluesselwort, char zeichen)
        {
            int indexOfZeichen = 0;
            List<char> newText = new List<char>();
            foreach (char item in text)
            {
                newText.Add(item);
            }

            while (true)
            {
                indexOfZeichen = string.Join("", newText).IndexOf(schluesselwort, indexOfZeichen + 2);
                if (indexOfZeichen != -1)
                {
                    newText.Insert(indexOfZeichen , zeichen);
                    newText.Insert(indexOfZeichen + 1 + schluesselwort.Length, zeichen);
                }
                else
                {
                    break;
                }
            }
            return string.Join("", newText);
        }
    }
}
