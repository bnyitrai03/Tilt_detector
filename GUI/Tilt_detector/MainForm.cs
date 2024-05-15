using System.IO.Ports;
using System.Threading;

namespace Tilt_detector
{
    public partial class Mainform : Form
    {
        private SerialCommunication serialCom = new SerialCommunication();
        private Data data = new Data();

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

        public void DisplayComm(string tilt, string limit)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => DisplayComm(tilt, limit)));               
            }
            else
            {
                tbDegree.Text += "Tilt is:       " + tilt + " °" + Environment.NewLine;
                if (Int16.Parse(tilt) >= 0)
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
            serialCom.ClosePort();
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
                //serialCom.ClosePort();
                NonBlockingClose();
            }
        }

        private async void NonBlockingClose()
        {
            await Task.Run(() => serialCom.ClosePort());
        }
    }
}