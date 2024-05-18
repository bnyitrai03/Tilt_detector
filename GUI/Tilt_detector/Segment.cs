using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilt_detector
{
    public class Segment
    {
        private bool on = false;
        private char name;
        private Rectangle position;

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public char Name
        {
            get => name;
        }

        public Rectangle Position
        {
            get => position;
        }

        public Segment(char Name, Rectangle rect) 
        {
            name = Name;
            position = rect;
        }
    }
}
