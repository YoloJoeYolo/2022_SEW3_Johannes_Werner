using System;
using System.Collections.Generic;

namespace Test206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoSomeThing("mama", "mneamna"));
            Console.WriteLine(DoSomeThing("papa", "aapq"));
            Console.WriteLine(DoSomeThing("aabaacbaacbb", "bbaabaaccaaa"));
        }

        static bool DoSomeThing(string word, string cubes)
        {
            List<char> cubesAsChars = new List<char>();
            foreach (char item in cubes)
            {
                cubesAsChars.Add(item);
            }
            foreach (char item in word)
            {
                if (cubesAsChars.Contains(item))
                {
                    cubesAsChars.Remove(item);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
