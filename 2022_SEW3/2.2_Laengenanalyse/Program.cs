using System;
using System.Collections.Generic;
using System.IO;

namespace _2._2_Laengenanalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Remove(path.IndexOf("2.2_Laengenanalyse") + 18) + "\\Beispieltext.txt";

            LengthCount lengthCount = new LengthCount();
            lengthCount.analyseWordsOfFile(path);
            Console.WriteLine(lengthCount.ToString());
        }
    }
}
