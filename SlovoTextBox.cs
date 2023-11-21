using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SlovoZaSlovo
{
    public partial class SlovoTextBox : UserControl
    {
        public enum FactorValue
        {
            None = 0,
            C3,
            C2,
            x3,
            x2
        }
        private static readonly (string, Color)[] FactorProp = new (string, Color)[] 
        { (string.Empty, Color.Black),
          ("С3", Color.Blue),
          ("С2", Color.Red),
          ("x3", Color.Blue),
          ("x2", Color.Red)};

        private FactorValue factor;
        public bool Highlight;
        public static FactorValue CurentFactorValue = FactorValue.None;

        public FactorValue Factor
        {
            get => factor;
            set
            {
                factor = value;
                this.UClabel.Text = FactorProp[(int)factor].Item1;
                this.UClabel.ForeColor = FactorProp[(int)factor].Item2;
            }
        }

        override public string Text { get => UCtextBox.Text; set => UCtextBox.Text = value; }


        public SlovoTextBox()
        {
            InitializeComponent();
            if (factor != FactorValue.None)
                this.UClabel.Text = factor.ToString();
            else
            {
                this.UClabel.Text = "";
            }

            this.UCtextBox.Text = "";

            this.UCPanel.Paint += new PaintEventHandler(UCPaint);
            //this.UCtextBox.Paint += new PaintEventHandler(UCPaint);
            //this.UClabel.Paint += new PaintEventHandler(UCPaint);

            void UCPaint(object sender, PaintEventArgs e)
            {
                //if (sender is Panel)
                if (Highlight)
                {
                    var s = sender as Panel;
                    Rectangle rectangle = new Rectangle(s.Location.X, s.Location.Y, s.Width - 2, UCPanel.Height - 2);
                    ControlPaint.DrawBorder(e.Graphics, /*this.ClientRectangle*/ rectangle, Color.Tomato, ButtonBorderStyle.Solid);
                }
            }
        }

        private void UC_Click(object sender, EventArgs e)
        {
            CurentFactorValue = CurentFactorValue.Next();
            Factor = CurentFactorValue;
        }

        private void UC_KeyWhell(object sender, MouseEventArgs e)
        {
            if (e.Delta<0)
            {
                CurentFactorValue = CurentFactorValue.Next();
                Factor = CurentFactorValue;
            }
            else
            {
                CurentFactorValue = CurentFactorValue.Prev();
                Factor = CurentFactorValue;
            }
        }


        private void UC_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (number == 8)
            {
                this.Parent.SelectNextControl(((Control)sender).Parent.Parent, false, false, false, false);
                e.Handled = true;
            }
            else if (number < 'А' || number > 'я') 
            {
                e.Handled = true;
            }
            else
            { 
                this.Parent.SelectNextControl(((Control)sender).Parent.Parent, true, false, false, false);
            }
        }
    }
}
