using System;
using System.Collections.Generic;
using System.Text;

namespace _08Caesar
{
    static class Caesar
    {
         static string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789^!\"§$%&/()=?²³{[]}\\`´+*~#',.-;:_<>| ";

        static public string generateChiffre(string text, int key)
        {
            StringBuilder textWIP = new StringBuilder(text);
            int temp;
            for (int i = 0; i < text.Length; i++)
            {
                temp = abc.IndexOf(text[i]);
                while (temp + key >= abc.Length)
                {
                    temp = temp - abc.Length;
                }
                while (temp + key < 0)
                {
                    temp = temp + abc.Length;
                }
                textWIP[i] = abc[temp + key];
            }
            return textWIP.ToString();
        }

        static public string generateCode(string chriffre, int key)
        {
            return generateChiffre(chriffre, -key);
        }

        /*
        // Versuch mit ASCII-Table --> wir haben festestellt, dass dies keine gute Idee ist. Wir kommen in den Bereich mit den Steuerzeichen
        // z.B.: Zeilen umbruch, Tabulator
        static public string generateChiffre(string text, int key)
        {
            string result = "";
            foreach (char c in text)
            {
                int newAcii = c + key;  // wir berachten den char al int und zählen einfach den Schlüssel dazu;
                newAcii = newAcii % 128;    // wir berechen den Rest bei Division durch 128, damit wir in der ASCII Tabelle bleiben
                result += (char)newAcii;    // Umwandlung des ACII-Werts in einen char
            }
            return result;
        }  
        */

        static public string generateChiffre2(string text, int key)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789^!\"§$%&/()=?²³{[]}\\`´+*~#',.-;:_<>| ";
            string result = "";
            while (key < 0) // wir können zum key jederzeit die Länge des Alphabets hinurechnen, ohne an der Verschlüsselung etwas
            {               // zu veräder, das Vielfache vom Schlüssel liefert das gleiche Resultat
                key += alphabet.Length;
            }
            foreach (char c in text)
            {
                if (alphabet.Contains(c))
                {
                    int indexOfChar = alphabet.IndexOf(c);
                    int newIndex = (indexOfChar + key) % alphabet.Length;   // damit wir nicht über das Ebde ddes strings hinauskommen
                    result += alphabet[newIndex];
                }
                else
                {
                    result += c;    // Nichtvorhandene Zeichen werden einfach übernommen
                }
                
            }
            return result;
        }
    }
}
