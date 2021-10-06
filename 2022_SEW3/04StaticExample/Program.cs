using System;

namespace _04StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Example.doSomethingElse();  // kein Objekt, Aufruf einer statischen Methode
            Example myObject = new Example();
            myObject.doSomething();     // Erzeugung eines Objekts und Aufruf der Methode
        }
    }
}
