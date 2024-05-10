using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signals
{
    public partial class GraphicsSignalView : UserControl, IView
    {
        private SignalDocument document;

        public SignalDocument Document 
        { 
            get { return document; } 
            set { document = value; }
        }
        public GraphicsSignalView(Document document)
        {
            InitializeComponent();
            
            Document = (SignalDocument)document;
        }

        public Document GetDocument()
        {
            return Document;
        }

        public void Update()
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, 0, 300, ClientSize.Width, 300); // x tengely
            e.Graphics.DrawLine(pen, 100, ClientSize.Height, 100, 0); // y tengely

            foreach (var signal in document.SignalValues)
            {
               // e.Graphics.FillRectangle(new Brush(Color.Black),signal.)
            }

        }
    }
}
