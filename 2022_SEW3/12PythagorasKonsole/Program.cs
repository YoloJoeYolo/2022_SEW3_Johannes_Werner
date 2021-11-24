using System;
using _11Pythagoras;

namespace _12PythagorasKonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double hypo = Pythagoras.calculateHypothenuse(3.0, 4.0);
            Console.WriteLine("Die Hyperthenuse in einem rechtwinkeligem Dreieck mit den Kathetenlängen 3 und 4 beträgt: {0:f2}", hypo);

            // ein paar weitere Berechnungen mit einer formatierten Ausgabe

            double areaKK = Pythagoras.calculateAreaKK(3.0, 4.0);
            Console.WriteLine("Die Fläche in einem rechtwinkeligem Dreieck mit den Kathetenlängen 3 und 4 beträgt: {0:f2}", areaKK);

            double Circumstance = Pythagoras.calculateCircumstance(1.0, 2.0, 10.0);
            Console.WriteLine("Der Umfang in einem rechtwinkeligem Dreieck mit den Seitenlängen 1, 2, 10 beträgt: {0:f2}", Circumstance);
            // Dieses Bsp. sollte nicht funktionieren
        }
    }
}
