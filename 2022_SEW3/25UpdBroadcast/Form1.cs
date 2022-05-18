using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25UpdBroadcast
{
    public partial class Form1 : Form
    {
        private int port = 8888;
        private UdpClient udpClient;

        public Form1()
        {
            InitializeComponent();
            IPEndPoint receiveAdr = new IPEndPoint(IPAddress.Any, port);    // IP: 0.0.0.0
            udpClient = new UdpClient(receiveAdr);
            this.ReceiveAsync();
        }

        private async void ReceiveAsync()   // async bedeutet, dass die Methode im Hintergrund ausgeführt wird
        {
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                this.txt_Log.Text += Encoding.UTF8.GetString(result.Buffer) + Environment.NewLine;
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] message = Encoding.UTF8.GetBytes(this.txt_Message.Text);
                IPEndPoint broadCastIP = new IPEndPoint(IPAddress.Broadcast, this.port);
                udpClient.Send(message, message.Length, broadCastIP);
            }
            catch (SocketException ex)
            {
                this.txt_Log.Text += ex.Message + Environment.NewLine; 
            }
        }
    }
}
