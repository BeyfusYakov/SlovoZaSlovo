using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class FactorValueClass
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

        private static readonly (string, Color)[] FactorProp = new (string, Color)[]
        { (string.Empty, Color.Black),
          ("С3", Color.Blue),
          ("С2", Color.Red),
          ("x3", Color.Blue),
          ("x2", Color.Red)};





    }
}
