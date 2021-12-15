using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1_Sonderzeichen
{
    static class ConvertString
    {
        static public string convert(string text)
        {
            text = text.ToLower();
            List<char> result = new List<char>();
            foreach (char element in text)
            {
                if (element == 'ä' || element == 'ü' || element == 'ö')
                {
                    switch (element)
                    {
                        case 'ä':
                            result.Add('a');
                            break;
                        case 'ü':
                            result.Add('u');
                            break;
                        case 'ö':
                            result.Add('o');
                            break;
                    }
                    result.Add('e');
                }
                else
                {
                    result.Add(element);     
                }
            }
            return String.Join("", result);
        }
    }
}
