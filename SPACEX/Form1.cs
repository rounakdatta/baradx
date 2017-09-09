using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private void maps_w_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //redundant
        }

        private void speed_gauge_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {
            //redundant
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //redundant
        }

        private void longitude_TextChanged(object sender, EventArgs e)
        {
            //redundant
        }

        private void latitude_TextChanged(object sender, EventArgs e)
        {
            //redundant
        }

        //USEFUL CODE STARTS HERE

        public Form1()
        {
            InitializeComponent();
            Get_Port_1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maps_w.Url = new System.Uri("http://maps.google.com/maps?q=" + latitude.Text + "," + longitude.Text);
        }

        
        public float a = 0; //test only

        public SerialPort port1;
        public SerialPort port2;

        private void gauge_timer_Tick(object sender, EventArgs e)
        {
            int x = sat_img.Location.X;
            int y = sat_img.Location.Y;
            speed_gauge.Value = a;
            a = a + 10;
            if(y >= 171)
                sat_img.Location = new Point(x, y - 34);
        }

        private void parsePacket(string idata1)
        {
            //to be written in lab
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            string Port_Name_1 = Get_Port_1.SelectedItem.ToString(); //get port name
            string Port_Name_2 = Get_Port_2.SelectedItem.ToString();
            int Baud_Rate = 9600; //get the baud rate

            if (openport1(Port_Name_1, Baud_Rate) == true && openport2(Port_Name_2, Baud_Rate) == true)
            {
                //MessageBox.Show("Port opened");
            }
            else
            {
                MessageBox.Show("Port open error");
            }
        }

        public bool openport1(string Port_Name, int Baud_Rate)
        {
            try
            {
                port1 = new SerialPort(Port_Name, Baud_Rate);
                port1.DtrEnable = false;

                port1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);

                port1.ReceivedBytesThreshold = 32;
                port1.Open();
                Thread.Sleep(300);
                if (port1.IsOpen == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

        } // openport1

        public bool openport2(string Port_Name, int Baud_Rate)
        {
            try
            {
                port2 = new SerialPort(Port_Name, Baud_Rate);
                port2.DtrEnable = false;

                port2.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);

                port2.ReceivedBytesThreshold = 32;
                port2.Open();
                Thread.Sleep(300);
                if (port2.IsOpen == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

        } // openport2

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            BeginInvoke((MethodInvoker)delegate { parsePacket(indata); });
        }

    }
}
