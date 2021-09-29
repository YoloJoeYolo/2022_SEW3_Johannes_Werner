using System;
using System.IO;

namespace _02Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = File.ReadAllText(@"C:\dev\johannes.werner\2022_SEW_Johannes_Werner\2022_SEW3\02Exceptions\myFile.txt");   // @ bedeutet, dass \ nicht als Escape- Sequenz berachtet wird
                Console.WriteLine("Der Text in der Datei lautet:");
                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Die Datei gibts ja gar nicht!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Der Ordner zur Datei existiert nicht.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Der Zugriff auf die Datei wurde verweiert.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hoppla. Da is etwas anz komiches passiert");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
