using System;
using System.Collections.Generic;

namespace Prem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ID = new Dictionary<string, int>();
            ID.Add("Jakob Prem", 1);
            ID.Add("Thomas Riegler", 100);
            foreach (KeyValuePair<string, int> item in ID)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
