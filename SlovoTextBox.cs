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
        public bool Highlight;

        private FactorValueClass factor;

        internal FactorValueClass Factor
        {
            get => factor;
            set
            {
                factor = value;
                this.UClabel.Text = factor.Name;
                this.UClabel.ForeColor = factor.ColorValue;
            }
        }

        override public string Text { get => UCtextBox.Text; set => UCtextBox.Text = value; }


        public SlovoTextBox()
        {
            InitializeComponent();

            this.UCPanel.Paint += new PaintEventHandler(UCPaint);

            void UCPaint(object sender, PaintEventArgs e)
            {
                if (Highlight)
                {
                    var s = sender as Panel;
                    Rectangle rectangle = new Rectangle(s.Location.X, s.Location.Y, s.Width - 2, UCPanel.Height - 2);
                    ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Tomato, ButtonBorderStyle.Solid);
                }
            }
        }

        private void UC_Click(object sender, EventArgs e)
        {
            Factor = FactorValueContainer.Next();
        }

        private void UC_KeyWhell(object sender, MouseEventArgs e)
        {
            Factor = (e.Delta < 0)? FactorValueContainer.Next() : FactorValueContainer.Prev();
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
