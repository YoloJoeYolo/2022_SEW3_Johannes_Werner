using System;

namespace _03TractorAndImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            Tractor jd = new Tractor("John Deere 5080R", 3775, 6600);
            Implement culivator = new Implement("Regent Terrakant", 550);
            Implement bogballe = new Implement("Bogballe M60", 6000);

            try
            {
                Console.WriteLine(jd);
                jd.MyImplement = culivator;
                Console.WriteLine(jd);
                jd.MyImplement = null;
                Console.WriteLine(jd);
                jd.MyImplement = bogballe;
            }
            catch (ImplementTooHeavyException)
            {
                Console.WriteLine("Dieses Gerrät ist eindeutig zu schwer!");
            }
        }
    }
}
