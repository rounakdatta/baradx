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
            Get_Port_2.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maps_w.Url = new System.Uri("http://maps.google.com/maps?q=" + latitude_disp.Text + "," + longitude_disp.Text);
        }

        
        public float a = 0; //test only

        public SerialPort port1;
        public SerialPort port2;

        private void gauge_timer_Tick(object sender, EventArgs e)
        {
            int x = sat_img.Location.X;
            int y = sat_img.Location.Y;
            /*speed_gauge.Value = a;
            a = a + 10;
            if(y >= 171)
                sat_img.Location = new Point(x, y - 34);*/
        }

        private void parsePacket(string idata, int sizex)
        {
            String sign;
            if (sizex == 36)
            {
                sign = (idata[3] == 0) ? "+" : "-";
                time_disp.Text = sign + idata[4].ToString() + idata[5].ToString() + idata[6].ToString();

                sign = (idata[11] == 0) ? "+" : "-";
                int velocity = Int32.Parse(sign + idata[12].ToString() + idata[13].ToString() + idata[14].ToString() + idata[15].ToString());
                speed_gauge.Value = velocity;

                sign = (idata[16] == 0) ? "+" : "-";
                int altitude = Int32.Parse(sign + idata[17].ToString() + idata[18].ToString() + idata[19].ToString() + idata[20].ToString() + idata[21].ToString() + idata[22].ToString() + idata[23].ToString());
                altitude_gauge.Value = altitude;

                sign = (idata[24] == 0) ? "+" : "-";
                int thrust = Int32.Parse(sign + idata[25].ToString() + idata[26].ToString() + idata[27].ToString() + idata[28].ToString());
                thrust_gauge.Value = thrust;

                sign = (idata[29] == 0) ? "+" : "-";
                float battery = float.Parse(sign + idata[30].ToString() + idata[30].ToString() + "." + idata[30].ToString() + idata[30].ToString());
                battery_voltage.Text = battery.ToString();
            }

            if (sizex == 19)
            {
                sign = (idata[3] == 0) ? "+" : "-";
                float latitudev = float.Parse(sign + idata[4].ToString() + idata[5].ToString() + idata[6].ToString() + "." + idata[7].ToString() + idata[8].ToString() + idata[9].ToString());
                latitude_disp.Text = latitudev.ToString();

                sign = (idata[10] == 0) ? "+" : "-";
                float longitudev = float.Parse(sign + idata[11].ToString() + idata[12].ToString() + idata[13].ToString() + "." + idata[14].ToString() + idata[15].ToString() + idata[16].ToString());
                longitude_disp.Text = longitudev.ToString();

                maps_w.Url = new System.Uri("http://maps.google.com/maps?q=" + latitude_disp.Text + "," + longitude_disp.Text);

            }
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

                //port1.ReceivedBytesThreshold = 36;
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

                port2.ReceivedBytesThreshold = 19;
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
            if(indata.Length == 36)
                BeginInvoke((MethodInvoker)delegate { parsePacket(indata, 36); });
            else if(indata.Length == 19)
                BeginInvoke((MethodInvoker)delegate { parsePacket(indata, 19); });
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            parsePacket(textBox1.Text, 19);
        }

    }
}
