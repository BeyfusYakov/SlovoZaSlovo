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


        //public SZStextBox()
        //{
        //    Controls.Add(new Label() { Height = 40,  /*Dock= DockStyle.Bottom,*/ BackColor = Color.Aqua, Text = "2" });
        //    InitializeComponent();
        //}

        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public bool UnderLinedStyle { get => underLinedStyle; set { underLinedStyle = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Graphics graph = textBox1.CreateGraphics();

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                graph.DrawRectangle(penBorder, 15, 15, 15, 15);

                graph.FillRectangle(new SolidBrush(Color.AliceBlue), 15, 15, 15, 15);

            }
        }

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    if (this.DesignMode)
        //        UpdateControlHeight();
        //}

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }

        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    UpdateControlHeight();
        //}
    }
}
