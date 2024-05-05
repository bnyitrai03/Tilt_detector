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
            try
            {
                while (communicate)
                {
                    bool newdata = false;
                    string tilt = string.Empty;
                    string limit = string.Empty;

                    while (!newdata)
                    {
                        tilt = serialport.ReadLine();
                        limit = serialport.ReadLine();
                        if (!string.IsNullOrEmpty(tilt) && !string.IsNullOrEmpty(limit))
                        {
                            newdata = true;
                        }
                    }

                    // Update the UI from the main thread
                    DisplayCOM(tilt, limit);

                    Thread.Sleep(400);
                }
            }
            catch
            {
                MessageBox.Show("Communication timed out.", "Communication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stop.Set();
                CloseCOM();
                return;
            }
            // signal to Main thread that we finished the current processing
            stop.Set();

        }

        private void DisplayCOM(string tilt, string limit)
        {
            if (InvokeRequired)
            {
                Invoke(DisplayCOM, new object[] { tilt, limit });
            }
            else if (!IsDisposed)
            {
                tbDegree.Text += "Tilt is:       " + tilt + " °" + Environment.NewLine;
                if(Int16.Parse(tilt) >= 0)
                {
                    tb7seg.Text = $"  {tilt}";
                }
                else
                {
                    tb7seg.Text = tilt;
                }
                tbMaxDegree.Text = limit + " °";  
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (serialport.IsOpen)
            {
                stop.Set();
                CloseCOM();
            }
            
        }

        private void bOpenCOM_Click(object sender, EventArgs e)
        {
            // Open a COM port if there isn't already one
            if (!communicate)
            {
                try
                {
                    serialport.ReadTimeout = 3000;
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

                    // Prepare the event, flag and thread for the communication
                    stop.Reset();
                    communicate = true;
                    ThreadPool.QueueUserWorkItem(ProccesData);
                }
                catch
                {
                    MessageBox.Show("Didn't find a COM port with matching parameters.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bStopCOM_Click(object sender, EventArgs e)
        {
            if (communicate)
            {
                CloseCOM();
            }

        }

        private void CloseCOM()
        {
            communicate = false;
            stop.WaitOne();
            serialport.Close();
        }

    }
}