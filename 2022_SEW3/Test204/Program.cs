using System;

namespace Test204
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AFunktion("train1234"));
            Console.WriteLine(AFunktion("train123456"));
            Console.WriteLine(AFunktion("1234567"));
            Console.WriteLine(AFunktion("abcdefg"));
        }

        static string AFunktion(string word)
        {
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string oneToTen = "0123456789";

            string chars = "";
            string numbers = "";

            string result = "";

            foreach (char item in word)
            {
                if (abc.Contains(item))
                {
                    chars += item;
                }
                else if (oneToTen.Contains(item))
                {
                    numbers += item;
                }
            }

            if (chars.Length > numbers.Length && chars.Length == numbers.Length + 1)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    result += chars[i];
                    if (i == numbers.Length)
                    {
                        break;
                    }
                    result += numbers[i];
                }
                return result;
            }
            else if (chars.Length == numbers.Length)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += chars[i];
                    result += numbers[i];
                }
                return result;
            }
            else if (chars.Length < numbers.Length && chars.Length == numbers.Length - 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                    if (i == chars.Length)
                    {
                        break;
                    }
                    result += chars[i];
                }
                return result;
            }
            else
            {
                return "Funktioniert nicht";
            }
        }
    }
}
