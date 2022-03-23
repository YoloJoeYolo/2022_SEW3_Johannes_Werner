using _22SerialArduino;
using System;
using System.IO.Ports;

namespace _23SerialArduinoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ArduinoSerialPortCommunication arduino1 = new ArduinoSerialPortCommunication("COM5");   // Konsolenbefehl: mode (Listet  alle Ports auf)
            arduino1.addSerialDataReceiveEventHandler(new SerialDataReceivedEventHandler(serialPortDataReveived));
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

        private static void serialPortDataReveived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            Console.Write(serialPort.ReadExisting());
        }
    }
}
