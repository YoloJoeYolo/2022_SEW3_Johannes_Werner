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
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPortDataReceived);
            // wir melden us zum Event "Daten empfangen" an. Wenn Daten empfangen wurden, wird die angemeldete Methode aufgerufen.
        }

        private void serialPortDataReceived(object sender, SerialDataReceivedEventArgs ea)  
        {
            // diese Methode soll nur vom EventHandler aufgeruden werden 
            Console.WriteLine(serialPort.ReadExisting());
        }

        public void write(string value)
        {
            // zuerst Kommunikationskanal öffnen
            try
            {
                this.serialPort.Open();
                this.serialPort.Write(value);
            }
            catch
            {
                // aktuell noch keine Fehlerbehandlung 
            }
            finally
            {
                this.serialPort.Close();
            }
        }
    }
}
