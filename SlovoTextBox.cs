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

        public FactorValue Factor { get => factor; set => factor = value; }

        public SlovoTextBox()
        {
            InitializeComponent();
            this.UClabel.Text = ((int)FactorValue.C2).ToString();
        }
    }
}
