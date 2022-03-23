using System;
using System.IO.Ports;

namespace _22SerialArduino
{
    public class ArduinoSerialPortCommunication
    {
        private SerialPort serialPort;

        public ArduinoSerialPortCommunication(string port)  // port: z.B: "COM3"
        {
            serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            this.serialPort.Open(); // bleibt solange offen, solange unser Programm läuft
            //serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPortDataReceived);
            
        }

        public void addSerialDataReceiveEventHandler(SerialDataReceivedEventHandler handler)
        {
            serialPort.DataReceived += handler;
            // wir melden us zum Event "Daten empfangen" an. Wenn Daten empfangen wurden, wird die angemeldete Methode aufgerufen.
        }

        //private void serialPortDataReceived(object sender, SerialDataReceivedEventArgs ea)  
        // diese Methode soll nur vom EventHandler aufgeruden werden 
        //    Console.Write(serialPort.ReadExisting());
        //}

        public void write(string value)
        {
            // zuerst Kommunikationskanal öffnen
            try
            {
                this.serialPort.Write(value);
            }
            catch
            {
                // aktuell noch keine Fehlerbehandlung 
            }
        }
    }
}
