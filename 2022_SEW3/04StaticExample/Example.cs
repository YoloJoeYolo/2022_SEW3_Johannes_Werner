using System;
using System.Collections.Generic;
using System.Text;

namespace _04StaticExample
{
    class Example
    {
        private int myHighScore = 0;
        private static int mylowestScore = 0;

        public void doSomething()
        {
            Console.WriteLine("Ich bin eine nichtstatische Methode");
            this.myHighScore = 100;
        }
        public static void doSomethingElse()
        {
            Console.WriteLine("Ich bin eine statische Methode");
            Example.mylowestScore = -100;
        }
    }
}
