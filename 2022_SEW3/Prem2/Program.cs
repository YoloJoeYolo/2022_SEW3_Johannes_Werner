using System;

namespace Prem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1 = Beispielklasse.generateRandomString(10);
            string var2 = Beispielklasse.generateRandomString(20);
            string var3 = Beispielklasse.generateRandomString(100);
            Console.WriteLine("{0}\n{1}\n{2}", var1, var2, var3);

            try
            {
                string var4 = Beispielklasse.generateRandomString(-1);
            }
            catch (System.ArgumentOutOfRangeException)
            {

                Console.WriteLine("Es dürfen keine negativen Argumente mitgegeben werden!");
            }

            Console.WriteLine("x in\nText 1:{0}\nText 2:{1}\nText 3:{2}", Beispielklasse.countChar(var1,'x'), Beispielklasse.countChar(var2, 'x'), Beispielklasse.countChar(var3, 'x'));
        }

    }
}
