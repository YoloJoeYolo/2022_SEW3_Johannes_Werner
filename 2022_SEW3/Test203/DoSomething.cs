using System;
using System.Collections.Generic;
using System.Text;

namespace Test203
{
    static class DoSomething
    {
        static string abc = "abcdefghijklmnopqrstuvwxyz";

        static public string DoSomethingMethode(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i+=2)
            {
                result += text[i];
                int temp = abc.IndexOf(text[i]) + int.Parse(text[i + 1].ToString());
                if (temp > 26)
                {
                    temp -= 26;
                }
                result += abc[temp];
            }
            return result;
        }
    }
}
