using System.IO.Ports;
using System.Threading;

namespace Tilt_detector
{
    public partial class Mainform : Form
    {
        SerialPort serialport = new SerialPort();
        ManualResetEvent stop = new ManualResetEvent(false);
        bool communicate;

        public Mainform()
        {
            InitializeComponent();
            ListPorts();
        }

        public void ListPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cBoxPorts.Items.Add(port);
            }
        }

        private void ProccesData(object arg)
        {
            while (communicate)
            {
                bool newdata = false;
                string tilt = string.Empty;

                while (!newdata)
                {
                    tilt = serialport.ReadLine();
                    if (!string.IsNullOrEmpty(tilt))
                    {
                        newdata = true;
                    }
                }

                // Update the UI from the main thread
                DisplayCOM(tilt);

                Thread.Sleep(100);
            }

            // Finnish the current data processing
            stop.Set();
           
        }

        private void DisplayCOM(string tilt)
        {
            if (InvokeRequired)
            {
                Invoke(DisplayCOM, new object[] { tilt });
            }
            else if (!IsDisposed)
            {
                tbReceived.Text += "Tilt is:       " + tilt + " °" + Environment.NewLine;
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            serialport.Close();
        }

        private void bOpenCOM_Click(object sender, EventArgs e)
        {
            // Open a COM port if there isn't already one
            if (!communicate)
            {
                try
                {

                    serialport.PortName = cBoxPorts.Text;
                    serialport.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                    serialport.DataBits = Convert.ToInt32(cBoxBits.Text);

                    switch (cBoxParity.Text)
                    {
                        case "odd":
                            serialport.Parity = Parity.Odd;
                            break;

                        case "even":
                            serialport.Parity = Parity.Even;
                            break;

                        default:
                            serialport.Parity = Parity.None;
                            break;
                    }

                    switch (cBoxStop.Text)
                    {
                        case "2":
                            serialport.StopBits = System.IO.Ports.StopBits.Two;
                            break;
                        default:
                            serialport.StopBits = System.IO.Ports.StopBits.One;
                            break;
                    }
              
                    serialport.Open();
                }
                catch
                {
                    MessageBox.Show("Didn't find a COM port with matching parameters.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                communicate = true;
                ThreadPool.QueueUserWorkItem(ProccesData);
            }

        }

        private void bStopCOM_Click(object sender, EventArgs e)
        {
            if (communicate)
            {
                communicate = false;
                stop.WaitOne();
                serialport.Close();
                stop.Reset();
            }

        }

    }
}