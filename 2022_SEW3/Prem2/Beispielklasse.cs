using System;
using System.Collections.Generic;
using System.Text;

namespace Prem2
{    public class Beispielklasse
    {
        private static Random rand = new Random();
        public static string generateRandomString(int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                char c = Convert.ToChar(Beispielklasse.rand.Next(97, 123));
                builder.Append(c);
            }
            return builder.ToString();
        }

        public static int countChar(string s, char c)
        {
            int occurrence = 0;
            int currentIndex = 0;
            while (s.IndexOf(c, currentIndex) > 0)
            {
                occurrence++;
                currentIndex = s.IndexOf(c, currentIndex) + 1;
            }
            return occurrence;
        }
    }

}
