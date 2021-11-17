using System;

namespace _09InversionChiffre
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen Sie eine Klasse Inversion Chiffre und implementieren Sie folgende Verschlüsselung
            // z.B.
            // Eingabe:          Machen       Sie        es  gut!
            // Ergebnis: nehcaM eiS se !tug

            Console.Write("Geben Sie den Pfad einer Datei an: ");
            string path = Console.ReadLine();
            string[] text = System.IO.File.ReadAllLines(path);
            string endtext = InversionChiffre.InversionChiffreMethode(text);
            System.IO.File.WriteAllText(path, endtext);
        }
    }
}
