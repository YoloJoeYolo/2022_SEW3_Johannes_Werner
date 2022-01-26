using System;

namespace _2AT._1_Hervorhebung
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Schlechte Programmierer sorgen sich um den Code. Gute Programmierer sorgen sich um Datenstrukturen und ihre Beziehungen.";
            Console.WriteLine(ConvertString.convert(text, "Programmierer", '#'));
        }
    }
}
