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
                logbox.AppendText("A1 : " + idata + Environment.NewLine);
                sign = (idata[3] == '0') ? "+" : "-";
                time_disp.Text = sign + idata[4].ToString() + idata[5].ToString() + idata[6].ToString();

                int velocity = Int32.Parse(idata[12].ToString() + idata[13].ToString() + idata[14].ToString() + idata[15].ToString());
                velocity = (idata[11] == '0') ? velocity : -velocity;
                speed_gauge.Value = velocity;

                int altitude = Int32.Parse(idata[17].ToString() + idata[18].ToString() + idata[19].ToString() + idata[20].ToString() + idata[21].ToString() + idata[22].ToString() + idata[23].ToString());
                altitude = (idata[16] == '0') ? altitude : -altitude;
                altitude_gauge.Value = altitude;

                int thrust = Int32.Parse(idata[25].ToString() + idata[26].ToString() + idata[27].ToString() + idata[28].ToString());
                thrust = (idata[24] == '0') ? thrust : -thrust;
                thrust_gauge.Value = thrust;

                int x = sat_img.Location.X;
                int y = sat_img.Location.Y;
                String str = idata[8].ToString() + idata[9].ToString() + idata[10].ToString();
                switch (str)
                {
                    case "001":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "009":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "013":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "048":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "088":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "091":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "103":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "106":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "123":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                    case "139":
                        sat_img.Location = new Point(x, y - 34);
                        break;
                }

                battery_voltage.Text = idata[30].ToString() + idata[31].ToString() + "." + idata[32].ToString() + idata[33].ToString();
            }

            if (sizex == 19)
            {
                logbox.AppendText("A2 : " + idata + Environment.NewLine);
                sign = (idata[3] == '0') ? "+" : "-";
                float latitudev = float.Parse(sign + idata[4].ToString() + idata[5].ToString() + idata[6].ToString() + "." + idata[7].ToString() + idata[8].ToString() + idata[9].ToString());
                latitude_disp.Text = latitudev.ToString();

                sign = (idata[10] == '0') ? "+" : "-";
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

                port1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler1);

                port1.ReceivedBytesThreshold = 36;
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

                port2.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler2);

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

        private void DataRecievedHandler1(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            BeginInvoke((MethodInvoker)delegate { parsePacket(indata, 36); });
        }

        private void DataRecievedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            BeginInvoke((MethodInvoker)delegate { parsePacket(indata, 19); });
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(testpacket_field.Text.Length == 36)
                parsePacket(testpacket_field.Text, 36);
            if (testpacket_field.Text.Length == 19)
                parsePacket(testpacket_field.Text, 19);
        }

    }
}
