using System;

namespace Test205
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoSomeThing("abcdefg", "ace"));
            Console.WriteLine(DoSomeThing("abcdefg", "aec"));
            Console.WriteLine(DoSomeThing("abcdefg", "atg"));
        }

        static bool DoSomeThing(string text, string sequenz)
        {
            int temp = 0;
            for (int i = 0; i < sequenz.Length; i++)
            {
                if (text.IndexOf(sequenz[i], temp) == -1)
                {
                    return false;
                }
                temp = text.IndexOf(sequenz[i], temp);
            }
            return true;
        }
    }
}
