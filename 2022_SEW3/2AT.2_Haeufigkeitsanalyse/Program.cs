using System;
using System.IO;

namespace _2AT._2_Haeufigkeitsanalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            Frequency frequency = new Frequency();

            frequency.analyseTextOfFile("C:\\dev\\johannes.werner\\2022_SEW_Johannes_Werner\\2022_SEW3\\2AT.2_Haeufigkeitsanalyse\\Beispieltext2.txt");
            Console.WriteLine(frequency.ToString());
        }
    }
}
