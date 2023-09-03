using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SlovoZaSlovo
{
    internal class SZS2TextBox: TextBox
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nheightRect, int nweightRect);

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;

        public Color BorderColor { get => borderColor; set => borderColor = value; }
        public int BorderSize { get => borderSize; set => borderSize = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Graphics graph = e.Graphics;

            //using (Pen penBorder = new Pen(BorderColor, BorderSize))
            //{
            //    graph.DrawRectangle(penBorder, 0, 0, 5, 5);

            //    graph.FillRectangle(new SolidBrush(Color.AliceBlue), 0, 0, 5, 5);
            //}

            Pen redPen = new Pen(Color.Red, 3);
            e.Graphics.DrawRectangle(redPen, this.Location.X,
                                      this.Location.Y, this.Width, this.Height);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
          //  this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happ
        }
    }
}
