using System;
using System.Collections.Generic;
using System.Text;

namespace _09InversionChiffre
{
    static class InversionChiffre
    {
        static public string InversionChiffreMethode(string[] text)
        {
            string temp = "";
            Dictionary<int, string[]> parts = new Dictionary<int, string[]>();
            for (int i = 0; i < text.Length; i++)
            {
                parts[i] = text[i].Split(" ");
            }

            for (int i = 0; i < parts.Count; i++)
            {
                for (int j = 0; j < parts[i].Length; j++)
                {
                    if (!(string.IsNullOrWhiteSpace(parts[i][j])))
                    {
                        char[] tempChar = parts[i][j].ToCharArray();
                        Array.Reverse(tempChar);
                        temp += new string(tempChar);
                    }
                }
                temp += "\n";
            }
            return temp;
        }
    }
}
