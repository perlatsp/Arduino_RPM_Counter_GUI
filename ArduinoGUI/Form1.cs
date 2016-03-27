using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace ArduinoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(SerialPort s)
        {
           serial = s;
        }
 #region Dilwsi metavlitwn
        public SerialPort serial = new SerialPort();
        public string portname;
        public int speed;
        public int counter = 0; 
        public PlotWindow ploti  = new PlotWindow();
        public SerialMonitor serialMonitor = new SerialMonitor();
#endregion
        //-----------------------------------------------------------------------------------

#region When form loads
        private void Form1_Load(object sender, EventArgs e)
        { 
           string[] PortsAvailable = SerialPort.GetPortNames();
           int[] bauds = new int[] { 300, 1200, 2400, 4800, 9600 };
           PortNamesCMB.Items.AddRange(PortsAvailable); 
           foreach( int baud in bauds)
            {
                BaudRatesCMB.Items.Add(baud);
            } 
        }
#endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serial.IsOpen)
            {
                try
                {
                    serial.PortName = Convert.ToString(PortNamesCMB.SelectedItem);
                    serial.BaudRate = Convert.ToInt32(BaudRatesCMB.SelectedItem);
                    serial.Open();
                    delay.Start();
                    openBTN.Text = "Disconnect"; 
                    SerialMonitorBOX.Text = "Connected";

                    //disable portnames and bautd dropdowns
                    PortNamesCMB.Enabled = !PortNamesCMB.Enabled;
                    BaudRatesCMB.Enabled = !BaudRatesCMB.Enabled;

                    InfoBOX.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                serial.Close();
                openBTN.Text = "Connect";
                SerialMonitorBOX.Text = "Connected";
                PortNamesCMB.Enabled = !PortNamesCMB.Enabled;
                BaudRatesCMB.Enabled = !BaudRatesCMB.Enabled;

                InfoBOX.Visible = false;
            }
        }
 
        public void SendToArduino(string test)
        {
            try
            {
                if (serial.IsOpen)
                {
                    serial.Write(test);
                    consoleTXT.Clear();
                }
                else
                {
                    MessageBox.Show("Make sure you have connected to serial port!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errow while sending to arduino!","Error");
            }
        }

        private void consoleTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == (char)13)
            SendToArduino(consoleTXT.Text);
        }


        public void delay_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serial.IsOpen)
                {
                    speed = int.Parse(serial.ReadLine()) * 10;
                    readTXT.AppendText("Ta RPM einai : " + speed + "\n");
                    Speedometer.Value = speed;
                    rpmInfoLBL.Text = speed.ToString();
                    rpmTXT.Text = speed.ToString();
                    if (ploti.Visible)
                    {
                        ploti.x = speed;
                    }
                    GetMaxRPMS();
                    CheckCondition();   //check the condition

                    serial.DiscardInBuffer();   //empty the serialbuffer
                }
                else
                {
                    ResetAll();
                }

            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
            

        private void serialMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSerialMonitor.Checked = !ShowSerialMonitor.Checked;
            try
            {
                if (ShowSerialMonitor.Checked)
                { 
                    serialMonitor.Show();
                }
                else { serialMonitor.Close();}
                   
            }
            catch(Exception es)
            {
                MessageBox.Show("Cannot show Serial Monitor :D");
            }
        }

        private void ShowPlotter_Click(object sender, EventArgs e)
        {
            ShowPlotter.Checked = !ShowPlotter.Checked;
            if (ShowPlotter.Checked)
            {
                ploti.Show();
            }
            else
                ploti.Dispose();
        }

        private void ShowSerialMonitor_Click(object sender, EventArgs e)
        {
            ShowSerialMonitor.Checked = !ShowSerialMonitor.Checked;
            if (ShowSerialMonitor.Checked)
            {
                serialMonitor.Show();
            }
            else
            {

                serialMonitor.Dispose();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void CheckCondition()
        {
            if (Speedometer.Value >500 && Speedometer.Value <= 2500)
            {
                conditionLBL.Text = "GOOD";
                conditionLBL.ForeColor = Color.Green;
            }
            else if (Speedometer.Value > 2500 && Speedometer.Value <= 3000)
            {
                conditionLBL.Text = "Warning";
                conditionLBL.ForeColor = Color.Orange;
            }
            else if (Speedometer.Value > 3000 && Speedometer.Value <= 4000)
            {
                conditionLBL.Text = "Danger";
                conditionLBL.ForeColor = Color.Red;
            }
            else {
                conditionLBL.Text = "VERY LOW";
                conditionLBL.ForeColor = Color.Black;
            }


        }

        public void ResetAll()
        {
            conditionLBL.Text = "";
            maxRPMLBL.Text = "";
            maxRPMS = 0;
            maxRPMLBL.Text = maxRPMS.ToString();
            serial.DiscardInBuffer();
            serial.DiscardOutBuffer();
            Speedometer.Value = 0;
        }
         
        public int maxRPMS = 0;

        void GetMaxRPMS()
        {
            if (speed >= maxRPMS)
            {
                maxRPMS = speed;
                maxRPMLBL.Text = maxRPMS.ToString();
            }
        } 

        private void InfoPanelMENU_Click(object sender, EventArgs e)
        {
            InfoPanelMENU.Checked = !InfoPanelMENU.Checked;
            if (InfoPanelMENU.Checked)
            {
                InfoBOX.Visible = true;
            }
            else
                InfoBOX.Visible = false;
        }
    }
}
