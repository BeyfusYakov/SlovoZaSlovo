using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlovoZaSlovo
{
    public partial class SZStextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;


        public SZStextBox()
        {
            InitializeComponent();
        }

        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public bool UnderLine { get => underLinedStyle; set { underLinedStyle = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;    
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                 if (underLinedStyle) 
                {
                    graph.DrawLine(penBorder, 0, this.Height-1, this.Width, this.Height - 1);
                }
                 else
                {
                    graph.DrawRectangle(penBorder, 0, 0, this.Width-1, this.Height - 1);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {

        }
    }
}
