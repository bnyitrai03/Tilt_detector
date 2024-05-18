using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tilt_detector
{
    public partial class SevenSegmentDisplay : UserControl
    {
        private int digit = 0;
        private Segment[] segments = new Segment[7];

        public int Digit
        {
            get => digit;
            set
            {
                digit = value;
                Invalidate();
            }
        }

        public SevenSegmentDisplay()
        {
            InitializeComponent();

            DoubleBuffered = true;

            segments[0] = new Segment('A', new Rectangle(20, 10, 40, 8));   // Segment A (Top)
            segments[1] = new Segment('B', new Rectangle(12, 18, 8, 30));   // Segment B (Top-left)           
            segments[2] = new Segment('C', new Rectangle(60, 58, 8, 30));   // Segment C (Bottom-right)
            segments[3] = new Segment('D', new Rectangle(20, 88, 40, 8));   // Segment D (Bottom)
            segments[4] = new Segment('E', new Rectangle(12, 58, 8, 30));   // Segment E (Bottom-left)
            segments[5] = new Segment('F', new Rectangle(60, 18, 8, 30));   // Segment F (Top-right)
            segments[6] = new Segment('G', new Rectangle(20, 48, 40, 8));   // Segment G (Middle)
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            UpdateActiveSegments();
            DrawSegments(e.Graphics);
        }

        private void UpdateActiveSegments()
        {
            int bit = 1;
            foreach (Segment seg in segments)
            {               
                if((bit & digit) == bit)
                {
                    seg.On = true;
                }
                else
                {
                    seg.On = false;
                }

                bit <<= 1;
            }
        }

        private void DrawSegments(Graphics graphics)
        {
            graphics.Clear(BackColor);

            Brush onBrush = new SolidBrush(Color.Red);
            Brush offBrush = new SolidBrush(Color.FromArgb(30, ForeColor));

            foreach (Segment seg in segments)
            {
                graphics.FillRectangle(seg.On ? onBrush : offBrush, seg.Position);
            }

            onBrush.Dispose();
            offBrush.Dispose();
        }

    }
}
