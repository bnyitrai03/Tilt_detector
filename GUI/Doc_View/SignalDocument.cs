using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Signals
{ 

    public class SignalDocument : Document
    {
        List<SignalValue> signalValues = new List<SignalValue>();

        public List<SignalValue> SignalValues
        {
            get
            {
                return signalValues;
            }
        }

        public SignalDocument(string name) : base(name)
        {
            SignalValue test1 = new SignalValue(10, new DateTime(2024, 05, 08, 10, 30, 50));
            SignalValue test2 = new SignalValue(1, new DateTime(2024, 05, 08, 11, 30, 50));
            SignalValue test3 = new SignalValue(9, new DateTime(2024, 05, 08, 13, 30, 50));

            signalValues.Add(test1);
            signalValues.Add(test2);
            signalValues.Add(test3);
        }

        public override void SaveDocument(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var signal in signalValues)
                {
                    string date = signal.TimeStamp.ToUniversalTime().ToString("o");
                    sw.WriteLine(signal.Value + "\t" + date);
                }
            }
        }

        void TraceValues()
        {
            foreach (SignalValue value in signalValues)
                Trace.WriteLine(value.ToString());
        }


        public override void LoadDocument(string filePath)
        {
            signalValues.Clear();

            string[] lines = File.ReadAllLines(filePath);
           foreach (var line in lines)
           {
               string[] data = line.Split('\t');
               double val = double.Parse(data[0]);
               DateTime utcDt = DateTime.Parse(data[1]);
               DateTime localDt = utcDt.ToLocalTime();
               SignalValue newvalue = new SignalValue(val, localDt);
               signalValues.Add(newvalue);
           }

           TraceValues();

        }

    }
}
