using System;
using System.Collections.Generic;
using System.Text;

namespace Test202
{
    class NummberToWord
    {
        Dictionary<int, string> nummberAndWord = new Dictionary<int, string>();
        Dictionary<int, string> fourthDigit = new Dictionary<int, string>{{ 1, "Eintausend" }, { 2, "Zweitausend" }, { 3, "Dreitausend" }, { 4, "Viertausend" }, { 5, "Fünftausend" }, { 6, "Sechstausend" }, { 7, "Siebentausend" }, { 8, "Achttausend" }, { 9, "Neuntausend" }, };
        Dictionary<int, string> thirdDigit = new Dictionary<int, string> { { 1, "Einhundert" }, { 2, "Zweihundert" }, { 3, "Dreihundert" }, { 4, "Vierhundert" }, { 5, "Fünfhundert" }, { 6, "Sechshundert" }, { 7, "Siebenhundert" }, { 8, "Achthundert" }, { 9, "Neunhundert" }, };
        Dictionary<int, string> secondDigit = new Dictionary<int, string> { { 1, "Zehn" }, { 2, "Zwanzig" }, { 3, "Dreißig" }, { 4, "Vierzig" }, { 5, "Fünfzig" }, { 6, "Sechzig" }, { 7, "Siebzig" }, { 8, "Achtzig" }, { 9, "Neunzig" }, };
        

        public string NummberToWordMethode(int nummber)
        {
            if (nummberAndWord.ContainsKey(nummber))
            {
                return nummberAndWord[nummber];
            }
            else
            {
                string temp = nummber.ToString();
                string word = "";
                switch (temp.Length)
                {
                    case 1:
                        return word;
                    case 2:
                        return word;
                    case 3:
                        return word;
                    case 4:
                        return word;
                    default:
                        return "Fehler";
                }
            }
        }
    }
}
