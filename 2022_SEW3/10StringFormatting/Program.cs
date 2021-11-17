using System;

namespace _10StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 1234;
            double d = 99.9;
            float f = 12.14f;
            string l = "liebe";

            Console.WriteLine("Der Artikel kostet {0:f2} Euro und ist in {1} Wochen lieferbar.", d, i);
            Console.WriteLine(string.Format("Hallo {0} Welt", l));
            Console.WriteLine(string.Format("8-stellige Artikenummer ist : {0:d8}", j));
        }
    }
}
