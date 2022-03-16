using _22SerialArduino;
using System;

namespace _23SerialArduinoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ArduinoSerialPortCommunication arduino1 = new ArduinoSerialPortCommunication("COM5");   // Konsolenbefehl: mode (Listet  alle Ports auf)
            while (true)
            {
                Console.Write("Bitte 'e' oder 'a' eingeben, um LED ein oder auszuschalten: ");
                string input = Console.ReadLine();
                if (input == "e" || input == "a")
                {
                    arduino1.write(input);
                }
                else
                {
                    Console.WriteLine("Ungültiger Befehl. Nur 'e' und 'a' eingeben.");
                }
            }
        }
    }
}
