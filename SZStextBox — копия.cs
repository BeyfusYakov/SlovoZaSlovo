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
        public bool UnderLinedStyle { get => underLinedStyle; set { underLinedStyle = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            //Graphics graph = e.Graphics;    
            //using (Pen penBorder = new Pen(borderColor, borderSize))
            //{
            //    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            //     if (underLinedStyle) 
            //    {
            //        graph.DrawLine(penBorder, 0, this.Height-1, this.Width, this.Height - 1);
            //    }
            //     else
            //    {
            //        graph.DrawRectangle(penBorder, 0, 0, this.Width-1, this.Height - 1);
            //    }
            //}

            base.OnPaint(e);
            Graphics graph = e.Graphics;


           // graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
           // graph.Clear(Parent.BackColor);

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                //               if (isFocused) penBorder.Color = borderFocusColor;//Set Border color in focus. Otherwise, normal border color
                if (!underLinedStyle) //Line Style
                    graph.DrawLine(penBorder, 2, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                {
                    // graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    graph.DrawRectangle(penBorder, 0, 0, 100, 100);
                    // graph.FillRectangle(new SolidBrush(Color.Red), 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }

            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
    }
}
