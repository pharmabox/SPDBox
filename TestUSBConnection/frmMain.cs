using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace USBCon
{
    public partial class frmMain : Form
    {
        int cont;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write("hello" + ++cont);
                    lbData.Items.Add("RASPBERRY: " + "hello" + cont);
                    
                    string s  =  "";
                    DateTime now = System.DateTime.Now;
                    while (System.DateTime.Now.Subtract(now).Milliseconds < 500)
                    {
                        s += serialPort.ReadExisting();
                        if (s.Length  == 2)
                        {
                            lbData.Items.Add("ARDUINO: " + s);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                btnSend.Enabled = true;
            }
        }

        private static string[] GetPortNames()
        {
            int version_os = (int)Environment.OSVersion.Platform;
            List<string> serial_ports = new List<string>();

            try 
            {
               // Are we on Unix?
                if (version_os == 4 || version_os == 128 || version_os == 6)
                {
                    string[] ttys = System.IO.Directory.GetFiles("/dev/", "tty*");
                    foreach (string dev in ttys)
                    {
                        //Arduino MEGAs show up as ttyACM due to their different USB<->RS232 chips
                        if (dev.StartsWith("/dev/ttyS") || dev.StartsWith("/dev/ttyUSB") || dev.StartsWith("/dev/ttyACM"))
                        {
                            serial_ports.Add(dev);
                        }
                    }
                }
                else
                {
                    serial_ports.AddRange(SerialPort.GetPortNames());
                }
              }
            catch { }
            return serial_ports.ToArray();
        }

        private void btnGetPortNames_Click(object sender, EventArgs e)
        {
            try
            {
               lbPorts.Items.Clear();

               string[] ports = GetPortNames();

               if (ports.Length > 0)
               {
                   lbPorts.Items.Add(ports[ports.Length -1]);
                   serialPort.PortName = ports[ports.Length - 1];
                   serialPort.Handshake = Handshake.None;
                   //serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                   serialPort.Open();
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        //private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        //{
        //   this.Invoke(new EventHandler(DoUpdate));
        //}

        //private void DoUpdate(object s, EventArgs e) 
        //{ 
        //    string[] c = serialPort.ReadExisting().Split(',');
        //    if (c.Length > 0)
        //    {
        //        s = "ARDUINO: " + c[0];
        //        lbData.Items.Add(s);
        //    }
        //    else
        //    {
        //        lbData.Items.Add("ARDUINO: null");
        //    }
        //} 
        private void btnComPortInfo_Click(object sender, EventArgs e)
        {
            try
            {
                lbPorts.Items.Clear();
                List<COMPortInfo> ports = COMPortInfo.GetCOMPortsInfo();

                for (int i = 0; i < ports.Count; i++)
                {
                    lbPorts.Items.Add(ports[i].Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}
