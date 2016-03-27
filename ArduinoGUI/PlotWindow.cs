using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoGUI
{
    public partial class PlotWindow : Form
    {
        public int x;
        public PlotWindow()
        { 
            InitializeComponent(); 
        }


        private void PlotWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }
        int xi = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series["RPM"].Points.AddY(x); ;
            xi++;
            if (xi > 4000)
                chart1.Series["RPM"].Points.Clear();
        }

        private void PlotWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(":(");
        }
    }
}
