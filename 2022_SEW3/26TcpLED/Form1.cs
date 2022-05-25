using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26TcpLED
{
    public partial class Form1 : Form
    {
        private TcpClient tcpClient;
        private StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            string ip = this.txt_IP.Text;
            if (!string.IsNullOrEmpty(ip))
            {
                try
                {
                    IPAddress address = IPAddress.Parse(ip);
                    int port = (int)this.nud_Port.Value;

                    IPEndPoint iPEndPoint = new IPEndPoint(address, port);
                    this.tcpClient = new TcpClient();
                    this.tcpClient.Connect(iPEndPoint);

                    this.writer = new StreamWriter(this.tcpClient.GetStream()); // wir verbinden den StreamWriter mit den TCP Client
                    this.btn_Connect.Enabled = false;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Bitte eine gültige IP angeben!" + ex.StackTrace);
                }
            }
        }

        private void btn_LED_On_Click(object sender, EventArgs e)
        {
            try
            {
                this.writer.Write("on\n");  //write benutzt möglicherweise ein Buffer
                this.writer.Flush();    // sendet alles was aktuell im Buffer ist
            }
            catch (Exception ex)   // wir fangen ALLE Exceptions --> uns ist bewusst, dass das nicht schön ist
            {
                MessageBox.Show("Uuuups, irgend etwas ist schief gegangen." + ex.StackTrace);
            }
        }

        private void btn_LED_Off_Click(object sender, EventArgs e)
        {
        }
    }
}
