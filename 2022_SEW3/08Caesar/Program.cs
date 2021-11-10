using System;
using System.Text;

namespace _08Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen Sie eine statische Methode in der Klasse Caesar mit dem Namen
            // public string generateChiffre(string text, int key)
            // string generateCode(string chriffre, int key)    --> Aufruf der obrigen Methode mit neg. key
            // string test = "abc";
            // test[1] = 'x' --> funktioniert leider nicht, weil indexer nur ein getter hat

            // Möglichkeit 1
            //StringBuilder testBuilder = new StringBuilder(test);
            //testBuilder[1] = 'x';
            //test = testBuilder.ToString();

            // Möglichkeit 2
            //char[] testArray = test.ToCharArray();
            //testArray[2] = 'x';
            //test = testArray.ToString();

            Console.Write("Geben Sie etwas ein: ");
            string text = Console.ReadLine();
            Console.Write("Geben Sie einen Key (Zahl) ein: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(text);
            Console.WriteLine(Caesar.generateChiffre(text, key));
            Console.WriteLine(Caesar.generateCode(Caesar.generateChiffre(text, key), key));
        }
    }
}
