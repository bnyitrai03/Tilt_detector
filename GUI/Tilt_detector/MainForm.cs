using System.IO.Ports;
using System.Threading;

namespace Tilt_detector
{
    public partial class Mainform : Form
    {
        private SerialCommunication serialCom = new SerialCommunication();

        public Mainform()
        {
            InitializeComponent();
            ListPorts();
            serialCom.OnDataReceived += DisplayComm;           
        }

        private void ListPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cBoxPorts.Items.Add(port);
            }
        }

        public void DisplayComm(Data values)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => DisplayComm(values)));
                }
                else
                {
                    tbTiltlog.Text = "Tilt is:       " + values.Tilt + " °          " + DateTime.Now.ToString() + Environment.NewLine + tbTiltlog.Text;

                    if (values.Tilt >= 0)
                    {
                        tbTilt.Text = $"  {values.Tilt} °";
                    }
                    else
                    {
                        tbTilt.Text = values.Tilt + " °";
                    }

                    tbMaxDegree.Text = $" {values.Limit} °";

                    DisplayHigh.Digit = values.Highdigit;
                    tbHigh.Text = values.Highdigit.ToString("X");
                    DisplayLow.Digit = values.Lowdigit;
                    tbLow.Text = values.Lowdigit.ToString("X");
                }

            }
            catch (Exception e)
            {
                return;
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            serialCom.Stop.Set();
            serialCom.ClosePort();
            base.OnFormClosing(e);
        }

        private void bOpenCOM_Click(object sender, EventArgs e)
        {
            if (!serialCom.Communicate)
            {
                Parity parity;
                StopBits stopbits;

                switch (cBoxParity.Text)
                {
                    case "odd":
                        parity = Parity.Odd;
                        break;

                    case "even":
                        parity = Parity.Even;
                        break;

                    default:
                        parity = Parity.None;
                        break;
                }

                switch (cBoxStop.Text)
                {
                    case "2":
                        stopbits = System.IO.Ports.StopBits.Two;
                        break;
                    default:
                        stopbits = System.IO.Ports.StopBits.One;
                        break;
                }

                serialCom.OpenPort(cBoxPorts.Text, Convert.ToInt32(cBoxBaudRate.Text), Convert.ToInt32(cBoxBits.Text), parity, stopbits);
            }

        }

        private void bStopCOM_Click(object sender, EventArgs e)
        {
            if (serialCom.Communicate)
            {
                NonBlockingCloseCom();
            }
        }

        private async void NonBlockingCloseCom()
        {
            await Task.Run(() => serialCom.ClosePort());
        }
    }
}