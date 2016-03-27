using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoGUI
{
    public partial class SerialMonitor : Form
    { 
        public SerialMonitor()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            consoleTXT.AppendText("Ta RPM einai : "  + "\n");
        }

        private void SerialMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        //  Form1 main = new Form1(); 
        public void SendToArduino(string test)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errow while sending to arduino!", "Error");
            }
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
