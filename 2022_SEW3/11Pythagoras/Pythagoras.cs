using System;

namespace _11Pythagoras
{
    public class Pythagoras
    {
        public static double calculateHypothenuse(double cathete1, double cathete2)
        {
            return Math.Sqrt(Math.Pow(cathete1, 2) + Math.Pow(cathete2, 2));
        }

        public static double calculateCathetus(double cathete1, double hypotenuse)
        {
            return Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(cathete1, 2));
        }

        public static double calculateAreaKK(double cathete1, double cathete2)
        {
            return (cathete1 * cathete2) / 2;
        }

        public static double calculateAreaKH(double cathete1, double hypotenuse)
        {
            return (cathete1 * Pythagoras.calculateCathetus(cathete1, hypotenuse)) / 2;
        }

        public static double calculateCircumstanceKK(double cathete1, double cathete2)
        {
            return cathete1 + cathete2 + Pythagoras.calculateHypothenuse(cathete1, cathete2);
        }

        public static double calculateCircumstanceKH(double cathete1, double hypotenuse)
        {
            return cathete1 + Pythagoras.calculateCathetus(cathete1, hypotenuse) + hypotenuse;
        }

        public static double calculateCircumstance(double cathete1, double cathete2, double hypotenuse)
        {
            return cathete1 + cathete2 + hypotenuse;
        }
    }
}
