using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Signals
{
    public class SignalValue
    {
        private double value;
        private DateTime timeStamp;

        public SignalValue(double signal, DateTime time)
        {
            Value = signal;
            TimeStamp = time;
        }

        public double Value
        {
            set
            {
                this.value = value;
            }
            get => value;
        }

        public DateTime TimeStamp
        {
            set
            {
                this.timeStamp = value;
            }
            get => timeStamp;
            
        }

        public override string ToString()
        {
            return Value + " " + TimeStamp;
        }
    }
}
