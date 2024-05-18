using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilt_detector
{
    public class Data
    {
        private int tilt;
        private int limit;
        private int lowdigit;
        private int highdigit;

        public int Tilt {  get { return tilt; } set {  tilt = value; } }
        public int Limit { get { return limit; } set { limit = value; } }
        public int Lowdigit { get {  return lowdigit; } set {  lowdigit = value; } }
        public int Highdigit { get { return highdigit; } set {  highdigit = value; } }

    }
}
