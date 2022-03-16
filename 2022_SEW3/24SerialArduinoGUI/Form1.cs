using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _22SerialArduino;

namespace _24SerialArduinoGUI
{
    public partial class Form1 : Form
    {
        ArduinoSerialPortCommunication arduino1 = new ArduinoSerialPortCommunication("COM5");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LED_ON_Click(object sender, EventArgs e)
        {
            arduino1.write("e");
            btn_LED_ON.Enabled = false;
            btn_LED_OFF.Enabled = true;
            btn_LED_OFF.Focus();
        }

        private void btn_LED_OFF_Click(object sender, EventArgs e)
        {
            arduino1.write("a");
            btn_LED_ON.Enabled = true;
            btn_LED_OFF.Enabled = false;
            btn_LED_ON.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
