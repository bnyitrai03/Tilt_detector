using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Linq.Expressions;

namespace Tilt_detector
{
    public delegate void DataReceivedHandler(Data values);

    public class SerialCommunication
    {
        private SerialPort serialPort;
        private bool communicate;
        private ManualResetEvent stop;

        private Data values = new Data();

        public event DataReceivedHandler OnDataReceived;

        public bool Communicate
        {
            get => communicate;
        }

        public ManualResetEvent Stop
        {
            get => stop;
            set => stop = value;
        }

        public SerialCommunication()
        {
            serialPort = new SerialPort();
            stop = new ManualResetEvent(false);
        }

        public void OpenPort(string portName, int baudRate, int dataBits, Parity parity, StopBits stopBits)
        {
                try
                {
                    serialPort.ReadTimeout = 3000;
                    serialPort.PortName = portName;
                    serialPort.BaudRate = baudRate;
                    serialPort.DataBits = dataBits;
                    serialPort.Parity = parity;
                    serialPort.StopBits = stopBits;
                    serialPort.DtrEnable = true;

                    if (stop.Equals(true))
                    {
                        stop.Reset();
                    }
               
                    communicate = true;
                    serialPort.Open();
                    ThreadPool.QueueUserWorkItem(ProcessData);
                }
                catch
                {
                    MessageBox.Show("Didn't find a COM port with matching parameters.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
        }

        public void ClosePort()
        {
            communicate = false;
            if (!stop.WaitOne(500))
            {
                MessageBox.Show("There was an error while closing the serial port.", " Communication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void ProcessData(object arg)
        {
            try
            {
                while (communicate)
                {
                    string tilt = string.Empty, limit = string.Empty, lowdigit = string.Empty, highdigit = string.Empty;
                    
                    if(serialPort.ReadLine() == "Start of Frame" && serialPort.IsOpen)
                    {
                        try
                        {
                            tilt = serialPort.ReadLine();
                            values.Tilt = Int16.Parse(tilt);

                            limit = serialPort.ReadLine();
                            values.Limit = Int16.Parse(limit);

                            lowdigit = serialPort.ReadLine();
                            values.Lowdigit = Int16.Parse(lowdigit);

                            highdigit = serialPort.ReadLine();
                            values.Highdigit = Int16.Parse(highdigit);

                            // Update the UI from the main thread
                            OnDataReceived?.Invoke(values);
                        }
                        catch(FormatException e) 
                        {
                            continue;
                        }                          
                    }                                                        
                }
            }
            catch(TimeoutException)
            {
                MessageBox.Show("Communication timed out.", "Communication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialPort.Close();
            }
            catch (OperationCanceledException)
            {
                serialPort.Close();
            }
            finally
            {
                stop.Set();
            }
                        
        }

    }
}
