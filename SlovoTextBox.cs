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
            C2,
            C3,
            x2,
            x3
        }
        private FactorValue factor;

        public FactorValue Factor
        {
            get => factor;
            set
            {
                factor = value;

                switch (value)
                {
                    case FactorValue.None:
                        this.UClabel.Text = string.Empty;
                        break;
                    case FactorValue.C2:
                        this.UClabel.ForeColor = Color.Blue;
                        this.UClabel.Text = FactorValue.C2.ToString();
                        break;
                    case FactorValue.C3:
                        this.UClabel.ForeColor = Color.Blue;
                        this.UClabel.Text = FactorValue.C3.ToString();
                        break;
                    case FactorValue.x2:
                        this.UClabel.ForeColor = Color.Red;
                        this.UClabel.Text = FactorValue.x2.ToString();
                        break;
                    case FactorValue.x3:
                        this.UClabel.ForeColor = Color.Red;
                        this.UClabel.Text = FactorValue.x3.ToString();
                        break;
                    default:
                        break;
                }
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
            this.UCtextBox.Paint += new PaintEventHandler(UCPaint);

            void UCPaint(object sender, PaintEventArgs e)
            {
                //if (sender is Panel)
                 var s = sender as Panel; 
                Rectangle rectangle = new Rectangle(s.Location.X , s.Location.Y, s.Width - 2, UCPanel.Height - 2);
                ControlPaint.DrawBorder(e.Graphics, /*this.ClientRectangle*/ rectangle, Color.IndianRed, ButtonBorderStyle.Solid);
            }
        }

        private void UC_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click");
            switch (Factor)
            {
                case FactorValue.None:
                    Factor = FactorValue.C2;
                    break;
                case FactorValue.C2:
                    Factor = FactorValue.C3;
                    break;
                case FactorValue.C3:
                    Factor = FactorValue.x2;
                    break;
                case FactorValue.x2:
                    Factor = FactorValue.x3;
                    break;
                case FactorValue.x3:
                    Factor = FactorValue.None;
                    break;
            }
        }
    }
}
