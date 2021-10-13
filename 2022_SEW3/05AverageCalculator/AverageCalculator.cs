using System;
using System.Collections.Generic;
using System.Text;

namespace _05AverageCalculator
{
    class AverageCalculator
    {
        public static double AveraeOfInput()
        {
            Console.WriteLine("Ich berechne den Mittelwert der eingegebene Zahlen. Beliebiges Zeichen für Ende!");
            // In einer Schleife den Benutzer Zahlen eingeben lassen. Diese Zahlen in einer Liste speichern. Nach Ende der Eingabe Berechnung des Mittelwertes.
            List<double> values = new List<double>();
            while (true)
            {
                Console.Write("Bitte eine Zahl eingeben: ");
                try
                {
                    double inputValue = double.Parse(Console.ReadLine());
                    values.Add(inputValue);
                }
                catch (Exception)
                {
                    // Ende der Eingabe --> Berechung des Mittelwertes
                    double sum = 0.0;
                    foreach (double element in values)
                    {
                        sum += element;
                    }
                    if (values.Count > 0)
                    {
                        return sum / values.Count;
                    }
                    else
                    {
                        return 0.0;
                    }
                }
            }
        }
    }
}
